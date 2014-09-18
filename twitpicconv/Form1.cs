using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace twitpicconv
{
    public partial class Form1 : Form
    {
        private const int tweet_id = 0, in_reply_to_status_id = 1, in_reply_to_user_id = 2;
        private const int timestamp = 3, source = 4, text = 5, retweeted_status_id = 6;
        private const int retweeted_status_user_id = 7, retweeted_status_timestamp = 8;
        private const int expanded_urls = 9;

        private const int postsizelimit = 900 * 1024;
        string[] twitpicfiles = null;
        string[] twitpicdic = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (twitpicfiles == null)
            {
                MessageBox.Show("please select twitpic folder ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxTwitlog.Text == "")
            {
                MessageBox.Show("please select twitter csv file ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string exportstr = "";
            int htmlcount = 0;
            int exportcount = 0;
            textBoxLog.AppendText("twitter log csv file:" + textBoxTwitlog.Text + Environment.NewLine);
            TextFieldParser parser = new TextFieldParser(textBoxTwitlog.Text, Encoding.GetEncoding("UTF-8"));
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (parser.EndOfData == false)
            {
                string[] tweetdata = parser.ReadFields();
                if ((!CheckRT(tweetdata)) && (CheckTwitpic(tweetdata)))
                {
                    string[] picstr = CheckPicDict(tweetdata, twitpicdic, twitpicfiles);
                    if (picstr.Length > 0)
                    {
                        string htm = GenHtml(tweetdata,
                            textBoxpicurl.Text,
                            textBoxTwitterurl.Text,
                            textBoxTwilogurl.Text,
                            textBoxSearchdomain.Text,
                            textBoxSearchname.Text,
                            twitpicdic,
                            twitpicfiles);
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(tweetdata[tweet_id] + ".htm", false, System.Text.Encoding.GetEncoding("UTF-8"));
                        sw.Write(htm);
                        sw.Close();
                        htmlcount++;
                        exportstr += GenExport(textBoxAuthor.Text,
                            textBoxTitle.Text,
                            textBoxStatus.Text,
                            textBoxAllowComments.Text,
                            textBoxConvertBreaks.Text,
                            textBoxAllowPings.Text,
                            textBoxCategory.Text,
                            tweetdata[timestamp],
                            htm,
                            "",
                            "",
                            textBoxKeywords.Text);
                    }

                }
                if ((htmlcount % 100) == 0)
                {
                    System.Text.Encoding utfenc = new System.Text.UTF8Encoding(false);
                    int utfsize = utfenc.GetByteCount(exportstr);
                    if (utfsize > postsizelimit)
                    {
                        System.IO.StreamWriter swexportdivided =
                            new System.IO.StreamWriter(
                                "post" + exportcount.ToString("00") + ".txt",
                                false, utfenc);
                        swexportdivided.Write(exportstr);
                        swexportdivided.Close();
                        exportstr = "";
                        exportcount++;
                    }
                    labelline.Text = htmlcount + " html files " + exportcount + " text files";
                    Application.DoEvents();
                }
            }
            parser.Close();

            System.Text.Encoding enc = new System.Text.UTF8Encoding(false); // without BOM
            System.IO.StreamWriter swexport = new System.IO.StreamWriter(
                    "post" + exportcount.ToString("00") + ".txt", false, enc);
            swexport.Write(exportstr);
            swexport.Close();
            exportcount++;
            labelline.Text = htmlcount + " html files " + exportcount + " text files";
            textBoxLog.Text += htmlcount + " html files " + exportcount + " text files" + Environment.NewLine;
        }

        private void buttonTwetopen_Click(object sender, EventArgs e)
        {
            openFileDialogTwit.FileName = "tweets.csv";
            openFileDialogTwit.Filter = "csv file|*.csv";
            if (openFileDialogTwit.ShowDialog() == DialogResult.OK)
            {
                textBoxTwitlog.Text = openFileDialogTwit.FileName;
            }
        }

        private void buttonPicFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialogPic.Description = "Please select twitpic jpeg file folder";
            if (folderBrowserDialogPic.ShowDialog() == DialogResult.OK)
            {
                textBoxPicFolder.Text = folderBrowserDialogPic.SelectedPath;
                twitpicfiles = ReadFilename(folderBrowserDialogPic.SelectedPath);
                twitpicdic = new string[twitpicfiles.Length];
                for (int i = 0; i < twitpicfiles.Length; i++)
                    twitpicdic[i] = twitpicfiles[i].Substring(0, 6);
                Array.Sort(twitpicdic); //sort filename for binary search
                Array.Sort(twitpicfiles);
            }
        }

        private bool CheckRT(string[] tweet)
        {
            if ((tweet[text][0] == 'R') && (tweet[text][1] == 'T'))
                return (true);
            return (false);
        }

        private bool CheckTwitpic(string[] tweet)
        {
            if (tweet[expanded_urls].IndexOf("http://twitpic.com") >= 0)
                return (true);
            return (false);
        }

        private string ChangeLFBR(string str)
        {
            string ret = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 0x0a)
                    ret += "<br>";
                else
                    ret += str[i];
            }
            return (ret);
        }

        private string GenHtml(string[] tweet, string picurl, string twitterurl, string twilogurl,
            string searchdomain, string searchname, string[] dic, string[] files)
        {
            string htm = "";
            string[] picstr = CheckPicDict(tweet, dic, files);
            DateTime dt = GetDatetime(tweet[timestamp]);
            htm += "<p>";
            htm += ChangeLFBR(tweet[text]);
            htm += "<br>";
            for (int i = 0; i < picstr.Length; i++)
            {
                htm += "<img src=\"" + picurl + picstr[i] + "\" ";
                htm += "alt=\"" + picstr[i] + "\" ><br>" + picstr[i] + "<br>";
            }
            if ((twitterurl != "") || (twilogurl != ""))
            {
                htm += "posted at ";
                if (twitterurl != "")
                {
                    htm += "<a href=\"" + twitterurl + tweet[tweet_id];
                    htm += "\" target=\"_blank\">twitter " + dt + "</a>";
                }
                if ((twitterurl != "") && (twilogurl != ""))
                {
                    htm += " / ";
                }
                if (twilogurl != "")
                {
                    htm += "<a href=\"" + twilogurl + "date-" + dt.ToString("yyMMdd");
                    htm += "\" target=\"_blank\">" + "twilog " + dt.ToString("d") + "</a>";
                }
                if (searchdomain != "")
                {
                    htm += "<form method=\"get\" action=\"http://www.google.co.jp/search\">";
                    htm += "<p><input type=\"hidden\" name=\"hl\" value=\"UTF-8\" >";
                    htm += "<input type=\"hidden\" name=\"ie\" value=\"UTF-8\" >";
                    htm += "<input type=\"text\" name=\"q\" size=\"10\" maxlength=\"255\" >";
                    htm += "<input type=\"hidden\" name=\"as_sitesearch\" value=\"";
                    htm += searchdomain + "\" >";
                    htm += "<input type=\"submit\" name=\"btnG\" value=\"";
                    if (searchname == "")
                        searchname = "google search";
                    htm += searchname + "\" ></p></form>";
                }
            }
            htm += "</p>";
            return (htm);
        }

        private string GenExport(string Author, string Title, string Status, string AllowComments,
            string ConvertBreaks, string AllowPings, string Category, string Datetimestr,
            string Body, string ExtendedBody, string Excerpt, string Keywords)
        {
            string ret = "";
            DateTime dt = GetDatetime(Datetimestr);
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
            ret += "AUTHOR: " + Author + "\n";
            ret += "TITLE: " + Title + "\n";
            ret += "STATUS: " + Status + "\n";
            ret += "ALLOW COMMENTS: " + AllowComments + "\n";
            ret += "CONVERT BREAKS: " + ConvertBreaks + "\n";
            ret += "ALLOW PINGS: " + AllowPings + "\n";
            ret += "CATEGORY: " + Category + "\n";
            ret += "\n";
            ret += "DATE: " + dt.ToString("MM/dd/yyyy hh:mm:ss tt", ci) + "\n";
            ret += "-----\n";
            ret += "BODY:\n";
            ret += Body + "\n";
            ret += "-----\n";
            ret += "EXTENDED BODY:\n" + ExtendedBody + "\n";
            ret += "-----\n";
            ret += "EXCERPT:\n" + Excerpt + "\n";
            ret += "-----\n";
            ret += "KEYWORDS:\n" + Keywords + "\n";
            ret += "-----\n";
            ret += "\n\n--------\n";
            return (ret);
        }

        private DateTime GetDatetime(string str)
        {
            DateTime dt = System.DateTime.ParseExact(str,
                "yyyy-MM-dd HH':'mm':'ss zzz",
                System.Globalization.DateTimeFormatInfo.InvariantInfo,
                System.Globalization.DateTimeStyles.None);
            return (dt);
        }

        private string[] ReadFilename(string folder)
        {
            string[] ret, files = System.IO.Directory.GetFiles(folder, "??????.*", System.IO.SearchOption.AllDirectories); //new string[0];
            ret = new string[files.Length];
            textBoxLog.Text += "twitpic file folder:" + folder + Environment.NewLine;
            textBoxLog.Text += ret.Length + " files." + Environment.NewLine;

            for (int i = 0; i < ret.Length; i++)
                ret[i] = System.IO.Path.GetFileName(files[i]);
            return (ret);
        }

        private string[] CheckPicDict(string[] tweet, string[] dic, string[] files)
        {
            string[] ret, links = tweet[expanded_urls].Split(',');
            int[] index = new int[links.Length];
            int count = 0;
            for (int i = 0; i < links.Length; i++)
            {
                index[i] = -1;
                if (links[i].IndexOf("http://twitpic.com") >= 0)
                {
                    string tag = links[i].Substring(19, 6);
                    index[i] = Array.BinarySearch(dic, tag);
                    if (index[i] >= 0)
                        count++;
                }
            }
            ret = new string[count];
            count = 0;
            for (int i = 0; i < links.Length; i++)
            {
                if (index[i] >= 0)
                    ret[count++] = files[index[i]];
            }
            return (ret);
        }

    }
}

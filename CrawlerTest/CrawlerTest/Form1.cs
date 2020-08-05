using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerTest
{
    public partial class Form1 : Form
    {
        private string GeneratedSource { get; set; }
        private string URL { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        string Rstring; 
        private void btnStart_Click(object sender, EventArgs e)
        {
            //WebRequest myWebRequest;
            //WebResponse myWebResponse;
            //String URL = txtUrl.Text;

            //myWebRequest = WebRequest.Create(URL);
            //myWebResponse = myWebRequest.GetResponse();//Returns a response from an Internet resource

            //Stream streamResponse = myWebResponse.GetResponseStream();//return the data stream from the internet
            //                                                          //and save it in the stream

            //StreamReader sreader = new StreamReader(streamResponse);//reads the data stream
            //Rstring = sreader.ReadToEnd();//reads it to the end
            //var Links = GetNewLinks(Rstring);//gets the links only

            ////textBox2.Text = Rstring;
            ////textBox3.Text = Links;
            //streamResponse.Close();
            //sreader.Close();
            //myWebResponse.Close();

            ////////////////////////////////////////////////////

            GetGeneratedHTML(txtUrl.Text); 
        }

        public string GetGeneratedHTML(string url)
        {
            string URL = url;

            Thread t = new Thread(new ThreadStart(WebBrowserThread));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

            return GeneratedSource;
        }

        private void WebBrowserThread()
        {
            WebBrowser wb = new WebBrowser();
            wb.Navigate(URL);

            wb.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(
                    wb_DocumentCompleted);

            while (wb.ReadyState != WebBrowserReadyState.Complete)
                Application.DoEvents();

            //Added this line, because the final HTML takes a while to show up
            GeneratedSource = wb.Document.Body.InnerHtml;

            wb.Dispose();
        }

        private void wb_DocumentCompleted(object sender,
            WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;
            GeneratedSource = wb.Document.Body.InnerHtml;
        }



        public ISet<string> GetNewLinks(string content)
        {
            Regex regexLink = new Regex("(?<=<a\\s*?href=(?:'|\"))[^'\"]*?(?=(?:'|\"))");

            ISet<string> newLinks = new HashSet<string>();
            foreach (var match in regexLink.Matches(content))
            {
                if (!newLinks.Contains(match.ToString()))
                    newLinks.Add(match.ToString());
            }

            return newLinks;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnGetTse_Click(object sender, EventArgs e)
        {
            string html = string.Empty;
            string url = @"http://tsetmc.com/tsev2/data/instinfofast.aspx?i=7745894403636165&c=23+";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            string url = "http://www.tsetmc.com/loader.aspx?ParTree=111C1115";
        }
    }
}

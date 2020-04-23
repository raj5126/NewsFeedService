using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsFeedclient
{
    public partial class AddNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!Page.IsPostBack)
            {
                newsId.Text = "";
                author.Text = "";
                ntitle.Text = "";
                publishdate.Text = "";
                content.Text = "";
                link.Text = "";
                newsId.Focus();
            }
        }

        protected void add_news_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes;
                NewsService.News nw = new NewsService.News();
                nw.NewsID = newsId.Text;
                nw.Authorname = author.Text;
                nw.Title = ntitle.Text;
                nw.PublishDate = Convert.ToDateTime(publishdate.Text);
                nw.Content = content.Text;
                HttpPostedFile postedFile = imageUpload.PostedFile;
                string filename = Path.GetFileName(postedFile.FileName);
                string fileExtension = Path.GetExtension(filename);
                int fileSize = postedFile.ContentLength;
                nw.Category = categorylist.SelectedValue;
                nw.VideoLink = link.Text;
                Console.WriteLine(fileExtension);
                if (fileExtension.ToLower() == ".jpeg" || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".jfif")
                {
                    Stream stream = postedFile.InputStream;
                    BinaryReader binaryReader = new BinaryReader(stream);
                    bytes = binaryReader.ReadBytes((int)stream.Length);
                    nw.NewsImage = bytes;
                    Console.WriteLine(bytes);
                    NewsService.FeedServiceClient client = new NewsService.FeedServiceClient();
                    success.Text = "News Id : " + nw.NewsID + " " + client.AddNews(nw);
                }
                else
                {
                    error.Text = "Image may be not in proper format.";
                }
                
            }
            catch(Exception ex)
            {
                success.Text = "News ID must be unique! or Error";
            }

        }
    }
}
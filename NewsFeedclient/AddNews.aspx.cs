using System;
using System.Collections.Generic;
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
            if (!Page.IsPostBack)
            {
                newsId.Text = "";
                author.Text = "";
                ntitle.Text = "";
                publishdate.Text = "";
                content.Text = "";
                newsId.Focus();
            }
        }

        protected void add_news_Click(object sender, EventArgs e)
        {
            try
            {
                NewsService.News nw = new NewsService.News();
                nw.NewsID = newsId.Text;
                nw.Authorname = author.Text;
                nw.Title = ntitle.Text;
                nw.PublishDate = Convert.ToDateTime(publishdate.Text);
                nw.Content = content.Text;

                NewsService.FeedServiceClient client = new NewsService.FeedServiceClient();
                success.Text = "News Id : " + nw.NewsID + " " + client.AddNews(nw);

            }
            catch(Exception ex)
            {
                success.Text = "News ID must be unique! ";
            }

        }
    }
}
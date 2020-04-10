using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsFeedclient
{
    public partial class DeleteNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bindgriddata();
        }

        public void bindgriddata()
        {
            DataSet ds = new DataSet();
            NewsService.FeedServiceClient client = new NewsService.FeedServiceClient();
            ds = client.GetNews();
            newsgrid.DataSource = ds;
            newsgrid.DataBind();

        }
        protected void dltbtn_Click(object sender, EventArgs e)
        {
            NewsService.FeedServiceClient client = new NewsService.FeedServiceClient();
            NewsService.News news = new NewsService.News();
            news.NewsID = TextBox.Text.Trim();
            string result = client.DeleteNews(news);
            if (result == "News Deleted Successfully!")
            {
                bindgriddata();
                deletelabel.Text = "News ID : " + TextBox.Text.Trim() + " Deleted Successfully !";
            }
            else
            {
                deletelabel.Text = "News ID : " + TextBox.Text.Trim() + " Not Found !";
            }

        }
    }
}
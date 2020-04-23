using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsFeedclient
{
    public partial class UpdateNews : System.Web.UI.Page
    {
        NewsService.News nw = new NewsService.News();
        NewsService.FeedServiceClient client = new NewsService.FeedServiceClient();
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                setPanel(true, false);
            }
            bindgriddata();

        }

        public void bindgriddata()
        {
            DataSet ds = new DataSet();
            NewsService.FeedServiceClient client = new NewsService.FeedServiceClient();
            ds = client.GetNews();
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        private void setPanel(bool psearch,bool pupdate)
        {
            searchpanel.Visible = psearch;
            updatepanel.Visible = pupdate;
        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            nw.NewsID = id.Text.Trim();
            nw.Title = ntitle.Text;
            nw.Content = ncontent.Text;
            nw.VideoLink = nvideo.Text;

            string result = client.UpdateNews(nw);
            searchmessage.Text = result;
            bindgriddata();
            setPanel(true, false);
            id.Text = "";
            ntitle.Text = "";
            ncontent.Text = "";
            nvideo.Text = "";
        }
    
        protected void searchbtn_Click(object sender, EventArgs e)
        {
            if (nid.Text != "")
            {
                nw.NewsID = nid.Text.Trim();
                ds = new DataSet();
                ds = client.SearchNewsRecord(nw);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    id.Text = ds.Tables[0].Rows[0]["NewsID"].ToString();
                    ntitle.Text = ds.Tables[0].Rows[0]["Title"].ToString();
                    ncontent.Text = ds.Tables[0].Rows[0]["Content"].ToString();
                    nvideo.Text = ds.Tables[0].Rows[0]["VideoLink"].ToString();
                    setPanel(false, true);
                }
                else
                {
                    searchmessage.Text = "Please Enter Proper News ID!.";
                }
            }
            else
            {
                  
                searchmessage.Text = "Please Enter Proper News ID!.";
            }
        }
    }
}
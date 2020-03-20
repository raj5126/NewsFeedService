using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsFeedclient
{
    public partial class DisplayNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();
                NewsService.FeedServiceClient client = new NewsService.FeedServiceClient();
                ds = client.GetNews();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    try
                    {
            
                        DataRow r = ds.Tables[0].Rows[i];
                        Label author = new Label();
                        author.Text = "By <b>" + r.Field<String>(1)+"</b><br>";
                        newspanel.Controls.Add(author);

                        Label date = new Label();
                        date.Text = "<b>Publish Date : </b>" + r.Field<DateTime>(3) + "<br>";
                        newspanel.Controls.Add(date);

                        Label title = new Label();
                        title.Text = "<b>Title : "+r.Field<String>(2)+"</b><br>";
                        newspanel.Controls.Add(title);

                        Label content = new Label();
                        content.Text = "<b>Description : </b>" + r.Field<String>(4) + "<br>";
                        newspanel.Controls.Add(content);

                        Label newline = new Label();
                        newline.Text = "<br>";
                        newspanel.Controls.Add(newline);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }

            }
        }
    }
}
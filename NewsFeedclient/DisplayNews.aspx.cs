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

                        date.Text = r.Field<DateTime>(3) + "<br><br>";
                        newspanel.Controls.Add(date);

                        Label title = new Label();
                        title.Text = "<b>"+r.Field<String>(2)+"</b><br><br>";
                        newspanel.Controls.Add(title);

                        Image image = new Image();
                        byte[] bytes = r.Field<byte[]>(6);
                        string strBase64 = Convert.ToBase64String(bytes);
                        image.ImageUrl = "data:Image/png;base64,"+strBase64;
                        image.Width = 300;
                        image.Height = 300;
                        newspanel.Controls.Add(image);

                        Label newline1 = new Label();
                        newline1.Text = "<br><br>";
                        newspanel.Controls.Add(newline1);

                        Label content = new Label();
                        content.Text = r.Field<String>(4) + "<br><br>";
                        newspanel.Controls.Add(content);

                        Label newline2 = new Label();
                        newline2.Text = "<br><br>";
                        newspanel.Controls.Add(newline2);

                        Label hrline = new Label();
                        hrline.Text = "<hr>";
                        newspanel.Controls.Add(hrline);
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
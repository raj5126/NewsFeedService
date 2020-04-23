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

                        Label title = new Label();
                        title.Text = "<b><p style=font-size:30px;font-family:verdana>" + r.Field<String>(2) + "</p></b>";
                        newspanel.Controls.Add(title);

                        Label author = new Label();
                        author.Text = "<p style=color:red;font-size:12px>By " + r.Field<String>(1)+ "</p>";
                        newspanel.Controls.Add(author);

                        Label date = new Label();
                        date.Text =  "<p>Updated on : " + r.Field<DateTime>(3) + "</p>";
                        newspanel.Controls.Add(date);

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
                        content.Text = "<p width:500px;height:100px;border:1px solid #000; style=color:grey;font-family:Courier New>" + r.Field<String>(4) + "</p>";
                        newspanel.Controls.Add(content);

                        string url = r.Field<String>(7);
                        Label link = new Label();
                        link.Text = "Video Link : <a href=" + url + " target = blank>" + url + "</a>" + "<br><br>";
                        newspanel.Controls.Add(link);

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            NewsService.FeedServiceClient client = new NewsService.FeedServiceClient();
            ds = client.FilterNewsRecord(DropDownList1.SelectedValue);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                try
                {

                    DataRow r = ds.Tables[0].Rows[i];

                    Label title = new Label();
                    title.Text = "<b><p style=font-size:30px;font-family:verdana>" + r.Field<String>(2) + "</p></b>";
                    newspanel.Controls.Add(title);

                    Label author = new Label();
                    author.Text = "<p style=color:red;font-size:12px>By " + r.Field<String>(1) + "</p>";
                    newspanel.Controls.Add(author);

                    Label date = new Label();
                    date.Text = "<p>Updated on : " + r.Field<DateTime>(3) + "</p>";
                    newspanel.Controls.Add(date);

                    Image image = new Image();
                    byte[] bytes = r.Field<byte[]>(6);
                    string strBase64 = Convert.ToBase64String(bytes);
                    image.ImageUrl = "data:Image/png;base64," + strBase64;
                    image.Width = 300;
                    image.Height = 300;
                    newspanel.Controls.Add(image);

                    Label newline1 = new Label();
                    newline1.Text = "<br><br>";
                    newspanel.Controls.Add(newline1);

                    Label content = new Label();
                    content.Text = "<p width:500px;height:100px;border:1px solid #000; style=color:grey;font-family:Courier New>" + r.Field<String>(4) + "</p>";
                    newspanel.Controls.Add(content);

                    string url = r.Field<String>(7);
                    Label link = new Label();
                    link.Text = "Video Link : <a href=" + url + " target = blank>" + url + "</a>" + "<br><br>";
                    newspanel.Controls.Add(link);

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
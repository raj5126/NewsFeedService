using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;

namespace NewsFeed
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class    FeedService : IFeedService
    {
        public string AddNews(News nw)
        {
            string result = "";
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Desktop\SOA\NewsFeed\NewsFeed.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                string query = @"INSERT INTO NEWS(NewsID, Authorname, Title, PublishDate, Content,  Category, NewsImage, VideoLink) VALUES(@NewsID, @Authorname, @Title, @PublishDate, @Content, @Category, @NewsImage, @VideoLink)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NewsID", nw.NewsID);
                cmd.Parameters.AddWithValue("@Authorname", nw.Authorname);
                cmd.Parameters.AddWithValue("@Title", nw.Title);
                cmd.Parameters.AddWithValue("@PublishDate", nw.PublishDate);
                cmd.Parameters.AddWithValue("@Content", nw.Content);
                cmd.Parameters.AddWithValue("@Category", nw.Category);
                cmd.Parameters.AddWithValue("@NewsImage", nw.NewsImage);
                cmd.Parameters.AddWithValue("@VideoLink", nw.VideoLink);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "News Added Successfully.";

            }
            catch (FaultException)
            {
                result = "Error";
            }

            return result;
        }

        public string DeleteNews(News nw)
        {
            string result = "";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Desktop\SOA\NewsFeed\NewsFeed.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            string query = "DELETE FROM News WHERE NewsID=@NewsID";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NewsID", nw.NewsID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            result = "News Deleted Successfully!";
            return result;
        }

        public DataSet GetNews()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Desktop\SOA\NewsFeed\NewsFeed.mdf;Integrated Security=True");
                string query = "SELECT * FROM News";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(ds);
             }
            catch(FaultException fex)
            {
                throw new FaultException<string>("Error : " + fex);
            }
            return ds;
        }

        public DataSet SearchNewsRecord(News nw)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Desktop\SOA\NewsFeed\NewsFeed.mdf;Integrated Security=True");
                string query = "SELECT * FROM News WHERE NewsID=@NewsID";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@NewsID", nw.NewsID);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }
            return ds;
        }

        public DataSet FilterNewsRecord(string category)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Desktop\SOA\NewsFeed\NewsFeed.mdf;Integrated Security=True");
                if (category == "All")
                {
                    string query = "SELECT * FROM News";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.Fill(ds);
                }
                else
                {
                    string query = "SELECT * FROM News WHERE Category=@Category";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.Parameters.AddWithValue("@Category", category);
                    sda.Fill(ds);

                }
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }
            return ds;
        }

        public string UpdateNews(News nw)
        {
            string result = " ";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Desktop\SOA\NewsFeed\NewsFeed.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            string query = "UPDATE NEWS SET Title = @Title, Content = @Content, VideoLink = @VideoLink where NewsID=@NewsID";
            cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@Authorname", nw.Authorname);
            cmd.Parameters.AddWithValue("@Title", nw.Title);
            cmd.Parameters.AddWithValue("@Content", nw.Content);
            cmd.Parameters.AddWithValue("@VideoLink", nw.VideoLink);
            cmd.Parameters.AddWithValue("@NewsID", nw.NewsID);
            con.Open();
            cmd.ExecuteNonQuery();
            result = "News Updated Successfully";
            con.Close();
            return result;
        }
    }
}

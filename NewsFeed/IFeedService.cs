using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NewsFeed
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFeedService
    {
        [OperationContract]
        string AddNews(News nw);

        [OperationContract]
        DataSet GetNews();

        [OperationContract]
        string DeleteNews(News nw);

        [OperationContract]
        DataSet SearchNewsRecord(News nw);

        [OperationContract]
        string UpdateNews(News nw);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "NewsFeedService.ContractType".
    [DataContract]
    public class News
    {
        string _newsID = "";
        string _authorname = "";
        string _title = "";
        DateTime _publishdate;
        string _content = "";

        [DataMember]
        public string NewsID
        {
            get { return _newsID; }
            set { _newsID = value; }
        }

        [DataMember]
        public string Authorname
        {
            get { return _authorname; }
            set { _authorname = value; }
        }

        [DataMember]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        [DataMember]
        public DateTime PublishDate
        {
            get { return _publishdate; }
            set { _publishdate = value; }
        }

        [DataMember]
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}

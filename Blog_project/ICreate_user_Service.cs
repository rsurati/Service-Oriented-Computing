using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Blog_project
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICreate_user_Service" in both code and config file together.
    [ServiceContract]
    public interface ICreate_user_Service
    {


        [OperationContract]
        User addUser(User u);

        [OperationContract]
        User checkUser(User u);

        [OperationContract]
        int addBlog(Blog_detail b);

        [OperationContract]
        List<Blog_detail> displayBlog();

        [OperationContract]
        List<Blog_detail> displayBlogbyUser(User u);

        [OperationContract]
        Blog_detail updateBlog(User u, String topic);

        [OperationContract]
        int updateBlogbyclick(Blog_detail b);

        [OperationContract]
        int deleteBlog(User u, int blog_id);




    }


    [DataContract]
    public class User
    {

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string email { get; set; }

        [DataMember]
        public string password { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string birthdate { get; set; }

        [DataMember]
        public string city { get; set; }

        [DataMember]
        public string interests { get; set; }




    }


    [DataContract]
    public class Blog_detail
    {

        [DataMember]
        public int Blog_detailId { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string topic { get; set; }

        [DataMember]
        public string description { get; set; }



        




    }
}

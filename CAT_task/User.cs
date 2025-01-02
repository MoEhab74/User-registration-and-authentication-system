using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_task
{
    internal class User
    {
        public string email { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        public static List<User> users = new List<User>();

        public User(string username_,string email_,string password_)
        {
            this.username = username_;
            this.email = email_;
            this.password = password_;
        }


        
    }
}

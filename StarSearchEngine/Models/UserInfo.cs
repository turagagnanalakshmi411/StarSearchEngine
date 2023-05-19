using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarSearchEngine.Models
{
    public class UserInfo
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string GetFullName()
        {
            string fullname = first_name.ToUpper() +" "+ last_name.ToUpper();
            return fullname;
        }
      

    }
}
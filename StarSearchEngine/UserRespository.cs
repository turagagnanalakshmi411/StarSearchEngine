using StarSearchEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarSearchEngine
{
    public class UserRespository : IUserRepository
    {
   

        public List<UserInfo> GetUserData(string name, List<UserInfo> users)
        {
            List<UserInfo> filteredUsers = new List<UserInfo>();
            if (!string.IsNullOrEmpty(name))
            {
                string searchstring = name.ToUpper();
                users.ForEach(u =>
                {
                    if (u.GetFullName().Contains(searchstring)||
                        u.first_name.ToUpper().Contains(searchstring) ||
                        u.last_name.ToUpper().Contains(searchstring) ||
                        u.email.ToUpper().Contains(searchstring))
                    {
                        filteredUsers.Add(u);
                    }
                });
                
            }
            return filteredUsers;
        }
    }
}
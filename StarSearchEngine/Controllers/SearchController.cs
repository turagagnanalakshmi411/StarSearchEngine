using Newtonsoft.Json;
using StarSearchEngine.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
namespace StarSearchEngine.Controllers
{
    public class SearchController : ApiController
    {
        private IUserRepository _userRepository;
        public SearchController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public List<UserInfo> GetUser(string name)
        {
          
                //List of variables
                List<UserInfo> users = new List<UserInfo>();
                List<UserInfo> filteredUsers = new List<UserInfo>();

                //Logic to parse json to list

                var mappedPath = System.Web.Hosting.HostingEnvironment.MapPath("~/Content/userdata.json");
                using (StreamReader r = new StreamReader(mappedPath))
                {
                    string json = r.ReadToEnd();
                    users = JsonConvert.DeserializeObject<List<UserInfo>>(json);
                }

                //method to get list of user records matching enterd name value
                filteredUsers= _userRepository.GetUserData(name, users);
                return filteredUsers;

        }
    }
}

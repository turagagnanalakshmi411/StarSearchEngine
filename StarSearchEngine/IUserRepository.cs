using StarSearchEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSearchEngine
{
    public interface IUserRepository
    {
         List<UserInfo> GetUserData(string name, List<UserInfo> users);
    }
}

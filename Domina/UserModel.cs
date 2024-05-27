using DataAccess;
using Common.Cache;

namespace Domian
{
    public class UserModel
    {
        UserData userData = new UserData();

        public bool LoginUser(string user, string password)
        {
            return userData.Login(user, password);
        }

     

    }
}

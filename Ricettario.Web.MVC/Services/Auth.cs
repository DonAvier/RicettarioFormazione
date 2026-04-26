using Ricettario.Web.MVC.Models;

namespace Ricettario.Web.MVC.Services
{
    public class Auth
    {
        public UserRequest User { get; set; }
        public void Login(UserRequest user)
        {
            User = user;
        } 
    }
}

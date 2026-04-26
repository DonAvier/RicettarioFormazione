using Ricettario.Web.MVC.Models;

namespace Ricettario.Web.MVC.Services
{
    public class Ricetta
    {
        public ComponentiRicetta Recepit { get; set; }
        public void Login(ComponentiRicetta recepit)
        {
            Recepit = recepit;
        }
    }
}

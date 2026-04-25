using Formazione.Models;
using Formazione.Pages.Abstraction;
using System.Text;

namespace Formazione.Pages
{
    public class ListRecepit : BasePage
    {
        public List<Recepit> Recipits;
        private string[] tableTitiles = ["Nome", "Data creazione", "Cuoco", "Valutazione media"];

        public ListRecepit(List<Recepit> recipits)
            : base(EnumPages.Homepage, "Elenco delle ricette", "Guarda che belle le tue ricette!!!!")
        {
            Recipits = recipits;
        }

        public override void initPage()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Name);

            TableTitles();

            if (Recipits != null && Recipits.Count != 0)
            {
                foreach(var recepit in Recipits)
                {
                    sb.AppendLine($"{recepit.Nome}       |{recepit.DataCreazione.ToString()}       |{recepit.Cuoco}       |{recepit.ValutazioneMedia}       |");
                }
            }
            Page = sb.ToString();
        }

        private string TableTitles()
        {
            string toReturn = string.Empty;

            foreach (var t in tableTitiles)
            {
                toReturn += $"{t}       |";
            }

            return toReturn;
        }
    }
}

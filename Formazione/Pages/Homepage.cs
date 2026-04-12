using Formazione.Pages.Abstraction;
using System.Text;

namespace Formazione.Pages
{
    public class Homepage : BasePage
    {
        public Homepage() 
            : base(EnumPages.Homepage, "Homepage", "Trovi qui la lista delle tue ricette, puoi leggerle o crearne una nuova")
        {
        }

        private string[] tableTitiles = ["Nome", "Data creazione", "Cuoco", "Valutazione media"];

        public override void initPage()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Name);
            sb.AppendLine(base.Description);
            sb.AppendLine("Qui l'elenco di ricette");
            sb.AppendLine(TableTitles());
            sb.AppendLine("Righe: TODO");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("-----------");
            sb.AppendLine("PREMI:");
            sb.AppendLine("1. Per leggere una ricetta");
            sb.AppendLine("2. Per scrivere una ricetta");
            sb.AppendLine("3. Esci");

            Page = sb.ToString();
        }

        private string TableTitles()
        {
            string toReturn = string.Empty;

            foreach (var t in tableTitiles) {
                toReturn += $"{t}       |";
            }

            return toReturn;
        }
    }
}

using Formazione.Models;
using Formazione.Pages.Abstraction;
using System.Text;

namespace Formazione.Pages
{
    public class CreateRecepit : BasePage
    {
        public Recepit ToBuildrecepit;
        public Chef Chef;

        public CreateRecepit(Chef chef) 
            : base(EnumPages.Homepage, "Crea la tua ricetta", "Ricetta dello chef {0} {1}")
        {
            Chef = chef;
            ingredientList = new List<Ingredient>();
        }

        string nome;
        string ricetta;
        List<Ingredient> ingredientList;

        public override void initPage()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Name);
            sb.AppendLine(string.Format(base.Description, Chef.Name, Chef.Surname));

            readFromLine(nome, "Fornisci il nome della ricetta:", sb);
            readFromLine(ricetta, "Fornisci la ricetta:", sb);

            sb.AppendLine("ingredienti:");

            var isWrtingIngridents = true;

            while (isWrtingIngridents)
            {
                sb.AppendLine("Fornisci nome e peso separati da uno spazio, una la , per i decimali");
                var input = Console.ReadLine();

                var inputSplitted = input.Split(" ");

                var nome = inputSplitted[0];
                double w = 0;
                var isOk = double.TryParse(inputSplitted[1], out w);

                if (isOk)
                {

                    ingredientList.Add(new Ingredient
                    {
                        Name = nome,
                        GramsAmount = w,
                    });
                }
                else
                {
                    //todo
                }

            }


            Page = sb.ToString();
        }

        private void readFromLine(string value, string description, StringBuilder sb)
        {
            sb.AppendLine(description);
            value = Console.ReadLine();
        }
    }
}

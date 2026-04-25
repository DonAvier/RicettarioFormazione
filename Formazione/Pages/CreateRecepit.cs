using Formazione.Models;
using Formazione.Pages.Abstraction;
using System.Text;

namespace Formazione.Pages
{
    public class CreateRecepit : BasePage
    {
        public List<Recepit> Recipits;
        public Chef Chef;

        public CreateRecepit(Chef chef, List<Recepit> recipits)
            : base(EnumPages.Homepage, "Crea la tua ricetta", "Ricetta dello chef {0} {1}")
        {
            Chef = chef;
            Recipits = recipits;
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
            Page = sb.ToString();
        }

        public void Compile()
        {
            readFromLine(nome, "Fornisci il nome della ricetta:");
            readFromLine(ricetta, "Fornisci il procedimento della ricetta:");

            Console.WriteLine("ingredienti:");
            Console.WriteLine("quanti ingredienti dobbiamo inserire?:");


            int numIngredienti = int.Parse(Console.ReadLine());

            for (var indice = 0; indice < numIngredienti; indice++)
            {
                addIngridient();
                Recipits.Add(new Recepit(Chef, ingredientList, nome, ricetta));
            }
        }

        private void readFromLine(string value, string description)
        {
            Console.WriteLine(description);
            value = Console.ReadLine();
        }

        private void addIngridient()
        {
            Console.WriteLine("Fornisci nome e peso in grammi separati da uno spazio, una la , per i decimali");
            var inputSplitted = (Console.ReadLine()).Split(" ");
            var nome = inputSplitted[0];

            if(inputSplitted.Length != 2)
            {
                addIngridient();
            }else 
            {
                double weigth = 0;
                var newIngredientValid = double.TryParse(inputSplitted[1], out weigth);

                if (newIngredientValid)
                    ingredientList.Add(new Ingredient
                    {
                        Name = nome,
                        GramsAmount = weigth,
                    });
                else
                {
                    Console.WriteLine("Input non valido, inserisci nuovamente il peso in grammi con una , per i decimali");
                    addIngridient();
                }
            }
        }
    }
}

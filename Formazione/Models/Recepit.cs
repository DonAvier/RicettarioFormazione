namespace Formazione.Models
{
    public class Recepit
    {
        public Recepit(Chef chef,List<Ingredient> ingredients, string nomeRicetta, string ricetta)
        {
            Nome = nomeRicetta;
            Ricetta = ricetta;
            DataCreazione = DateTime.Now;

            Cuoco = chef;
            Ingredienti = ingredients;

            Recensioni = new List<Review>();
        }

        public string Nome { get; set; }
        public string Ricetta { get; set; }
        public DateTime DataCreazione { get; set; }
        public double ValutazioneMedia => Recensioni.Sum(r => r.Stars) / Recensioni.Count;


        public Chef Cuoco { get; set; }
        public List<Review> Recensioni { get; set; }
        public List<Ingredient> Ingredienti { get; set; }
        
    }
}

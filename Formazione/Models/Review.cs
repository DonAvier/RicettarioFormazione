namespace Formazione.Models
{
    public class Review
    {
        public int Stars { get; set; }
        public string Description { get; set; }
        public Chef Reviwer { get; set; }
    }
}

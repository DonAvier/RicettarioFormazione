namespace Formazione.Pages.Abstraction
{
    public abstract class BasePage
    {
        public BasePage(EnumPages referencePage, string name, string description)
        {
            EnumPages _referencePage = referencePage;
            _name = name;
            _description = description;
            _datetime = DateTime.UtcNow;
        }

        public EnumPages ReferencePage => _referencePage;
        public DateTime DataCreazione => _datetime;
        public string Name => _name;
        public string Description => _description;
        public string Page { get; set; }
        public abstract void initPage();


        private EnumPages _referencePage;
        private DateTime _datetime;
        private string _name;
        private string _description;
    }
}

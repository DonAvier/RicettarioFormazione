using Formazione.Pages.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formazione
{
    public class Engine<TPage> where TPage : BasePage
    {
        private TPage Page;

        public Engine(TPage page) {
            Page = page;
        }

        public string RenderPage()
        {
            Page.initPage();

            return Page.Page;
        }
    }
}

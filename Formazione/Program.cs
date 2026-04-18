using Formazione;
using Formazione.Pages;
using Formazione.Pages.Abstraction;

bool isRunning = true;
EnumPages currentPage = EnumPages.Homepage;

Homepage homepage = new Homepage();
DettaglioRicetta dettaglioRicetta = new DettaglioRicetta();
NuovaRecensione nuovaRecensione = new NuovaRecensione();

//-------------------------------------------------------

Console.WriteLine("RICETTARIO!");
Console.WriteLine("Fornisci nome e cognome");
string nameInput = Console.ReadLine();
var nameInputSplitted = nameInput.Split(" ");

string name = nameInputSplitted[0];
string surname = nameInputSplitted.Length > 1 ? surname = nameInputSplitted[1] : "rossi";

Console.WriteLine($"Il tuo nome è {name} {surname}");

while(isRunning == true)
{
    if(currentPage == EnumPages.Homepage)
    {
        ShowPage(homepage);

        switch (Console.ReadLine())
        {
            case "2":
                currentPage = EnumPages.CreaRicetta;
                break;
            default:
                exitPage(isRunning);
                break;
        };

        //opz 1 -> Leggi una ricetta
        //opz 2 -> Scrivi una ricetta
        //opz 3 -> Esci
    }
    else if (currentPage == EnumPages.CreaRicetta)
    {

        CreateRecepit createRecepit = new CreateRecepit();
        ShowPage(createRecepit);

        //opz 1 -> Scrivere un commento
        //opz 2 -> Leggere ingredienti
        //opz 3 -> Leggere il procedimento
        //opz 4 -> Torna ad homepage
        //opz 5 -> Esci
    }
    else if (currentPage == EnumPages.DettaglioRicetta)
    {

        //opz 1 -> Scrivere un commento
        //opz 2 -> Leggere ingredienti
        //opz 3 -> Leggere il procedimento
        //opz 4 -> Torna ad homepage
        //opz 5 -> Esci
    }
    else if (currentPage == EnumPages.NuovaRecensione)
    {

        //opz 1 -> Conferma
        //opz 2 -> Esci
    }
}

Console.WriteLine("Premi un tasto per chiudere");
Console.ReadLine();

static void exitPage(bool isRunning)
{
    isRunning = false;
    Console.WriteLine("Grazie mille per aver usato il nostro applicativo ciao.");
}

static void ShowPage<TPage>(TPage page) where TPage : BasePage
{
    Engine<TPage> engine = new Engine<TPage>(page);
    Console.WriteLine(engine.RenderPage());
}
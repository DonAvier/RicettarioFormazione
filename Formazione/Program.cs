using Formazione;
using Formazione.Models;
using Formazione.Pages;
using Formazione.Pages.Abstraction;

bool isRunning = true;
EnumPages currentPage = EnumPages.Homepage;

Homepage homepage = new Homepage();
DettaglioRicetta dettaglioRicetta = new DettaglioRicetta();
NuovaRecensione nuovaRecensione = new NuovaRecensione();

Chef chef = new Chef();

List<Recepit> recepit = new List<Recepit>();

//-------------------------------------------------------

Console.WriteLine("RICETTARIO!");
Console.WriteLine("Fornisci nome e cognome");
string nameInput = Console.ReadLine();
var nameInputSplitted = nameInput.Split(" ");

chef.Name = nameInputSplitted[0];
chef.Surname = nameInputSplitted.Length > 1 ? nameInputSplitted[1] : "rossi";

Console.WriteLine($"Il tuo nome è {chef.Name} {chef.Surname}");

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
        CreateRecepit createRecepit = new CreateRecepit(chef, recepit);
        ShowPage(createRecepit);
        createRecepit.Compile();
        Console.WriteLine("Se vuoi aggiungere una ricetta premi 1, premi un altro tasto per tornare alla home page");
        switch (Console.ReadLine())
        {
            case "1":
                ShowPage(createRecepit);
                createRecepit.Compile();
                break;
            default:
                currentPage = EnumPages.Homepage;
                ShowPage(homepage);
                break;
        };

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
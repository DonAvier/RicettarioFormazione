using Formazione;
using Formazione.Pages;

bool isRunning = true;
EnumPages currentPage = EnumPages.Homepage;

Homepage homepage = new Homepage();
DettaglioRicetta dettaglioRicetta = new DettaglioRicetta();
NuovaRecensione nuovaRecensione = new NuovaRecensione();

//-------------------------------------------------------

Console.WriteLine("RICETTARIO!");
Console.WriteLine("Fornisci nome e cognome");
string nome = Console.ReadLine();

Console.WriteLine($"Il tuo nome è {nome}");

while(isRunning == true)
{


    if(currentPage == EnumPages.Homepage)
    {
        Engine<Homepage> engine = new Engine<Homepage>(homepage);

        Console.WriteLine(engine.RenderPage());

        var nextAction = Console.ReadLine();

        if(nextAction == "3")
        {
            isRunning = false;

            Console.WriteLine("Grazie mille per aver usato il nostro applicativo ciao.");
            break;
        }
        //opz 1 -> Leggi una ricetta
        //opz 2 -> Scrivi una ricetta
        //opz 3 -> Esci
    } else if (currentPage == EnumPages.DettaglioRicetta)
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
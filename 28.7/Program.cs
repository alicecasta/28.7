using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prenotazioni prenotazione = new Prenotazioni();
            prenotazione.Numeroprogressivo = 20;
            prenotazione.Anno = 2023;
            Clienti cliente = new Clienti();
            cliente.Nome = "Alice";
            cliente.Cognome = "Castaldi";
            prenotazione.Dataprenotazione=new DateTime(2023,3,3,0,0,0);
            Console.WriteLine("la prenotazione numero {0} dell'anno {1} del cliente {2} {3} della giorno {4}", prenotazione.Numeroprogressivo, prenotazione.Anno, cliente.Nome, cliente.Cognome, prenotazione.Dataprenotazione);

            prenotazione.Caparra = 100;
            prenotazione.Tariffa = 300;
            Servizi servizio = new Servizi();
            servizio.Prezzo = 150;
            servizio.Descrizione = "Colanzioni in camera";
            servizio.Quantità = 4;
            Console.WriteLine("La prenotazione numero {0}: deve pagare una caparra di {1}, il prezzo stabilito è {2}, il prezzo delle {3} {4} è {5}, il prezzo finale è {6}", prenotazione.Numeroprogressivo, prenotazione.Caparra, prenotazione.Tariffa, servizio.Quantità, servizio.Descrizione,servizio.Prezzo, (prenotazione.Tariffa+servizio.Prezzo));
            Console.ReadLine();
        }
    }
}

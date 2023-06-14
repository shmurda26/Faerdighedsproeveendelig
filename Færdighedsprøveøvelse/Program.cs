using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøveøvelse
{
    public class Program
    { Reservationer reservationer;
        static void Main(string[] args)
        {
            
            BoerneGruppe boerneGruppe1 = new BoerneGruppe() {ID = 33, Navn = "somsom", Aldersgruppe = "2", AntalDeltagere = 92 };
            
            BoerneGruppe boerneGruppe2 = new BoerneGruppe() { ID = 32, Navn = "som", Aldersgruppe = "5", AntalDeltagere = 42 };

            Console.WriteLine($"Børnegruppe Identificatons nummer : {boerneGruppe1.ID}");
            Console.WriteLine($"Børnegruppe hold navn: {boerneGruppe1.Navn}");
            Console.WriteLine($"Børnegruppe gennemsnitsAlder: {boerneGruppe1.Aldersgruppe}");
            Console.WriteLine($"Børnegruppe Deltagere {boerneGruppe1.AntalDeltagere}");
            Console.WriteLine($"Børnegruppe Identificatons nummer: {boerneGruppe2.ID}");
            Console.WriteLine($"Børnegruppe hold navn: {boerneGruppe2.Navn}");
            Console.WriteLine($"Børnegruppe gennemsnitsAlder: {boerneGruppe2.Aldersgruppe}");
            Console.WriteLine($"Børnegruppe Deltagere {boerneGruppe2.AntalDeltagere}");
            //foreach (var reservation in reservationer)
            //{
            //    Console.WriteLine($"{reservation}");
            //}

            DateTime time = new DateTime(2023, 06, 13);
            Reservation reservation = new Reservation() { ID = 20,Tidspunkt=time };
            Reservationer reservationer=new Reservationer();
            reservation.AddReservation(reservation );
            reservation.PrintReservation(reservation);
            
            



        }
    }
}

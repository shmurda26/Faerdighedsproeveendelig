using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøveøvelse
{
    public class Reservationer
    {
        public BoerneGruppe boerneGruppe;

        public int ID { get; set; }
        public DateTime Tidspunkt { get; }
        public List<Reservation> reservationer { get; set; }
        //public Reservationer (int id,DateTime tider)
        //{ ID=id;
        //    Tidspunkt = tider;
        //}

        public Reservationer()
        {
            DateTime time = new DateTime(2023, 06, 15);
            reservationer = new List<Reservation>();
            


            BoerneGruppe boerneGruppe1 = new BoerneGruppe() { ID = 33, Navn = "somsom", Aldersgruppe = "2", AntalDeltagere = 92 };

            BoerneGruppe boerneGruppe2 = new BoerneGruppe() { ID = 32, Navn = "som", Aldersgruppe = "5", AntalDeltagere = 42 };

            void AddReservation(Reservation reservation)
            { reservationer.Add(reservation); }
            void PrintReservation()
            {
                //_reservationer.Print(reservation);
                System.Collections.IList list = reservationer;
                for (int i = 0; i < list.Count; i++) { BoerneGruppe reservation = (BoerneGruppe)list[i]; Console.WriteLine(reservation); }
            }
            // void PrintMenu()
            //{
            //    Console.WriteLine(" Menu:");
            //    Console.WriteLine("****************************");
            //    foreach (var reservation in reservationer)
            //    {
            //        Console.WriteLine($"{reservation}");
            //    }

            //}
            void DeleteReservation(Reservation reservation)
            { reservationer.Remove(reservation); }
            reservationer.Add(new Reservation() { ID = 1, Tidspunkt = time, Boernegruppe = new BoerneGruppe() { ID = 22, Navn = "somsom", Aldersgruppe = "2", AntalDeltagere = 92 } });

            reservationer.Add(new Reservation()
            {
                ID = 1,
                Tidspunkt = time,
                Boernegruppe = new BoerneGruppe() { ID = 222, Navn = "stts", Aldersgruppe = "555", AntalDeltagere = 42 }
            });
            
            }
    }
    } 



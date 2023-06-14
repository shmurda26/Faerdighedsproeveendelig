using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøveøvelse
{
    public class Reservation
    {public int ID { get; set; }
        public DateTime Tidspunkt { get; set; }
        public BoerneGruppe Boernegruppe { get; set; }

        //public Reservation(int iD, DateTime tidspunkt, BoerneGruppe boernegruppe)
        //{
        //    ID = iD;
        //    Tidspunkt = tidspunkt;
        //    Boernegruppe = boernegruppe;
        //}

        public override string ToString()
        {
            return $"ID" + ID + "tidspunkt" + Tidspunkt + "boernegruppe" + Boernegruppe;
        }

        internal void AddReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
        internal void PrintReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}

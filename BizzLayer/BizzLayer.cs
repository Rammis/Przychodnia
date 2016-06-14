using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
namespace BizzLayer
{
    static public class DoctorFacade
    {
        public static IQueryable GetVisits()
        {
            PrzychodniaDataContext dc = new PrzychodniaDataContext();
            var res = from vis in dc.Wizytas
                      select
                       new
                       {
                           vis.id_pac,
                           FirstName = vis.Pacjent.imie,
                           LastName = vis.Pacjent.nazwisko,
                           vis.data_rej,
                           vis.stan
                       };
            return res;
        }
        public static void UpdateVisitData(Wizyta vis)
        {
            return;
        }
    }

    static public class SlownikBadanFacade
    {
        public static IQueryable GetBadania()
        {
            PrzychodniaDataContext dc = new PrzychodniaDataContext();
            var res = from bad in dc.Slownik_badans
                      select
                       new
                       {
                           ID_Badania = bad.typ,
                           KOD = bad.kod,
                           Nazwa = bad.nazwa
                       };
            return res;
        }
        public static void UpdateVisitData(Wizyta vis)
        {
            return;
        }
    }
}

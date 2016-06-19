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
            Przychodnia1DataContext dc = new Przychodnia1DataContext();
            var res = from vis in dc.Wizytas
                      select
                       new
                       {
                           vis.id_wizyty,
                           vis.id_pac,
                           FirstName = vis.Pacjent.imie,
                           LastName = vis.Pacjent.nazwisko,
                           vis.data_rej,
                           vis.stan
                       };
            return res;
        }
        public static IQueryable GetVisits(String _nazwisko, String _imie, DateTime _data)
        {
            Przychodnia1DataContext dc = new Przychodnia1DataContext();

            var res = from vis in dc.Wizytas
                      where (vis.Pacjent.nazwisko == _nazwisko && vis.Pacjent.imie == _imie)
                      select
                      new
                      {
                          vis.id_wizyty,
                          vis.id_pac,
                          FirstName = vis.Pacjent.imie,
                          LastName = vis.Pacjent.nazwisko,
                          vis.data_rej,
                          vis.stan
                      };
            return res;

        }

        public static IQueryable GetVisits(String _nazwisko, String _stan)
        {
            Przychodnia1DataContext dc = new Przychodnia1DataContext();
            if (_stan == "Wszystkie")
            {
                if (_nazwisko == "")
                {
                    var res = from vis in dc.Wizytas
                              select
                              new
                              {
                                  vis.id_wizyty,
                                  vis.id_pac,
                                  FirstName = vis.Pacjent.imie,
                                  LastName = vis.Pacjent.nazwisko,
                                  vis.data_rej,
                                  vis.stan
                              };
                    return res;
                }
                else
                {
                    var res = from vis in dc.Wizytas
                              where (vis.Pacjent.nazwisko == _nazwisko)
                              select
                              new
                              {
                                  vis.id_wizyty,
                                  vis.id_pac,
                                  FirstName = vis.Pacjent.imie,
                                  LastName = vis.Pacjent.nazwisko,
                                  vis.data_rej,
                                  vis.stan
                              };
                    return res;
                }
            }
            else
            {
                if (_nazwisko == "")
                {
                    var res = from vis in dc.Wizytas
                              where (vis.stan == _stan)
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
                else
                {
                    var res = from vis in dc.Wizytas
                              where (vis.Pacjent.nazwisko == _nazwisko && vis.stan == _stan)
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

            }

        }
        public static IQueryable GetVisits(DateTime _data, String _stan)
        {
            Przychodnia1DataContext dc = new Przychodnia1DataContext();
            if (_stan == "Wszystkie")
            {
                var res = from vis in dc.Wizytas
                          where (vis.data_wyk_wizyty == _data)
                          select
                          new
                          {
                              vis.id_wizyty,
                              vis.id_pac,
                              FirstName = vis.Pacjent.imie,
                              LastName = vis.Pacjent.nazwisko,
                              vis.data_rej,
                              vis.stan
                          };
                return res;
            }
            else
            {
                var res = from vis in dc.Wizytas
                          where (vis.data_wyk_wizyty == _data && vis.stan == _stan)
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
        }
        public static IQueryable GetVisits(DateTime _data)
        {
            Przychodnia1DataContext dc = new Przychodnia1DataContext();

            var res = from vis in dc.Wizytas
                      where (vis.data_wyk_wizyty == _data)
                      select
                      new
                      {
                          vis.id_wizyty,
                          vis.id_pac,
                          FirstName = vis.Pacjent.imie,
                          LastName = vis.Pacjent.nazwisko,
                          vis.data_rej,
                          vis.stan
                      };
            return res;
        }

        public static Wizyta GetVisit(int id)
        {

            using (Przychodnia1DataContext dc = new Przychodnia1DataContext())
            {

                var res = (from vis in dc.Wizytas
                           where vis.id_wizyty == id
                           select vis).SingleOrDefault();

                return res;
            }
        }

        public static void UpdateVisitData(Wizyta vis)
        {
            using (Przychodnia1DataContext dc = new Przychodnia1DataContext())
            {
                var res = (from el in dc.Wizytas
                           where el.id_wizyty == vis.id_wizyty
                           select el).SingleOrDefault();
                if (res == null)
                    return;
                res.opis = vis.opis;
                res.diagnoza = vis.diagnoza;
                res.stan = vis.stan;
                dc.SubmitChanges();

            }
        }
    }

    static public class BadaniaFizykalneFacade
    {
        public static IQueryable GetBadania(int id_wizyty)
        {
            Przychodnia1DataContext dc = new Przychodnia1DataContext();
            var res = from bad in dc.Badanie_fizykalnes
                      where bad.id_wizyty == id_wizyty
                      select
                       new
                       {
                           ID_Badania = bad.id_bad_fiz,
                           KOD = bad.kod,
                           Nazwa = bad.Slownik_badan.nazwa
                       };
            return res;
        }
        public static void InsertBadaniaFizykalne(Badanie_fizykalne bad)
        {
            Przychodnia1DataContext dc = new Przychodnia1DataContext();
            dc.Badanie_fizykalnes.InsertOnSubmit(bad);
            dc.SubmitChanges();
            return;
        }
        public static Badanie_fizykalne GetBadanie(int _id_badanie)
        {
            Przychodnia1DataContext dc = new Przychodnia1DataContext();
            var res = (from bad in dc.Badanie_fizykalnes
                       where (bad.id_bad_fiz == _id_badanie)
                       select bad).SingleOrDefault();
                      
            return res;
        }
    }
    static public class SlownikBadanFizykalnychFacade
    {
        public static IQueryable GetSlownikBadan()
        {
            Przychodnia1DataContext dc = new Przychodnia1DataContext();
            var res = from bad in dc.Slownik_badans
                      where bad.typ=="BF"
                      select
                       new
                       {
                           kod = bad.kod,
                           typ = bad.typ,
                           nazwa = bad.nazwa
                       };
            return res;
        }
        public static Slownik_badan GetBadanie(int kod)
        {
            using (Przychodnia1DataContext dc = new Przychodnia1DataContext())
            {

                var res = (from bad in dc.Slownik_badans
                           where bad.kod == kod
                           select bad).SingleOrDefault();

                return res;
            }
        }
    }

    }

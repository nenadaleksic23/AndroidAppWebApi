using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolovniAutomobili
{
    public class UserModel
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Blokiran { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public List<CarModel> Automobili { get; set; }
        public string Message { get; set; }
    }


    public class CarModel
    {
        public int Id { get; set; }
        public string NazivAutomobila { get; set; }
        public int BrendAutomobilaID { get; set; }
        public byte[] SlikaAutomobila { get; set; }
        public string Kubikaza { get; set; }
        public string SnagaMotora { get; set; }
        public bool? KoznaSedista { get; set; }
        public bool? MultifunkcionalniVolan { get; set; }
        public bool? MehanickaZastita { get; set; }
        public bool? BlokadaMotora { get; set; }
        public DateTime? DatumDodavanja { get; set; }
        public DateTime? DatumIsticanja { get; set; }
        public int KorisnikID { get; set; }
        public string Opis { get; set; }
        public bool? Blokiran { get; set; }
        public string BrendAutomobila { get; set; }
        public string Vlasnik { get; set; }
    }
    
    public class BrendAutomobilaModel
    {
        public int BrendID { get; set; }
        public string NazivBrenda { get; set; }
        public string Message { get; set; }
    }
    public class AutomobiliModel
    {
        public string NazivAutomobila { get; set; }
        public string PostavioKorisnik { get; set; }
        public string BrendAutomobila { get; set; }
        public int AutomobilID { get; set; }
        public int BrendAutomobilaID { get; set; }
        public string SlikaAutomobila { get; set; }
        public Nullable<double> Kubikaza { get; set; }
        public Nullable<double> SnagaMotora { get; set; }
        public Nullable<bool> KoznaSedista { get; set; }
        public Nullable<bool> MultifunkcionalniVolan { get; set; }
        public Nullable<bool> MehanickaZastita { get; set; }
        public Nullable<bool> BlokadaMotora { get; set; }
        public Nullable<System.DateTime> DatumDodavanja { get; set; }
        public Nullable<System.DateTime> DatumIsticanja { get; set; }
        public int KorisnikID { get; set; }
        public string Opis { get; set; }
        public string Godiste { get; set; }
        public Nullable<bool> Blokiran { get; set; }
        public List<KomentariModel> KomentariZaAutomobil { get; set; }


    }
    public class KomentariModel
    {
        public int KomentarID { get; set; }
        public Nullable<int> ParentKomentarID { get; set; }
        public string Komentar { get; set; }
        public int KorisnikID { get; set; }
        public Nullable<System.DateTime> DatumPostavljanja { get; set; }
        public string Korisnik { get; set; }
        public int AutomobilID { get; set; }
        public string NazivAutomobila { get; set; }
      

    }
}

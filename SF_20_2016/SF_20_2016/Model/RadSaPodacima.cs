using SF_20_2016.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_20_2016.Model
{
    class RadSaPodacima
    {
        public static RadSaPodacima Instance { get; private set; } = new RadSaPodacima();
        private List<TipNamestaja> tipovi_namestaja;
        private List<Namestaj> namestaj;
        private List<Korisnik> korisnik;
        private List<Akcija> akcija;

        public List<TipNamestaja> tipovi_Namestaja
        {
            get
            {
                tipovi_namestaja = GenericSerializer.Deserialize<TipNamestaja>("tipovi_namestaja.xml");

                return tipovi_namestaja;
            }
            set
            {
                tipovi_namestaja = value;
                GenericSerializer.Serialize<TipNamestaja>("tipovi_namestaja.xml", tipovi_namestaja);
            }
        }

        public List<Namestaj> namestaji
        {
            get
            {
                namestaj = GenericSerializer.Deserialize<Namestaj>("listaNam.xml");
                return namestaj;
            }
            set
            {
                namestaj = value;
                GenericSerializer.Serialize<Namestaj>("listaNam.xml", namestaj);
            }
        }

        public List<Korisnik> korisnici
        {
            get
            {
                korisnik = GenericSerializer.Deserialize<Korisnik>("Korisnici.xml");
                return korisnik;
            }
            set
            {
                korisnik = value;
                GenericSerializer.Serialize<Korisnik>("Korisnici.xml", korisnik);
            }
        }
        public List<Akcija> akcije
        {
            get
            {
                akcija = GenericSerializer.Deserialize<Akcija>("Akcije.xml");
                return akcija;
            }

            set
            {
                akcija = value;
                GenericSerializer.Serialize<Akcija>("Akcije.xml", akcija);

            }
        }
    }
}

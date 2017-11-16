using SF_20_2016.Model;
using SF_20_2016.tests;
using SF_20_2016.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_20_2016
{
    class Program
    {

        //public static List<TipNamestaja> tip_namestaja = new List<TipNamestaja>();
       // public static List<Namestaj> namestaj = new List<Namestaj>();
        public static List<Korisnik> korisnici = new List<Korisnik>();
        //public static List<Akcija> akcije = new List<Akcija>();
        static void Main(string[] args)
        {
           /* var listaTipovaNamestaja = GenericSerializer.Deserialize<TipNamestaja>("tipovi_namestaja.xml");
            var noviTipNamestaja = new TipNamestaja()
            {
                Naziv = "Ugaona"
            };

            listaTipovaNamestaja.Add(noviTipNamestaja);
            Projekat.Instance.TipoviNamestaja = listaTipovaNamestaja;
            Console.WriteLine("Finished serialization...");
            Console.ReadLine();*/


          /*  var tn1 = new TipNamestaja
            {
                Id = 1,
                Naziv = "krevet",
                Obrisan = false
            };
            var k1 = new Korisnik
            {
                Ime = "Prvi",
                Prezime = "Korisnik",
                KorisnickoIme = "k1",
                Lozinka = "korisnik1",
                TipKorisnika = "crazy"


            };
            var k2 = new Korisnik
            {
                Ime = "Drugi",
                Prezime = "Korisnik",
                KorisnickoIme = "k2",
                Lozinka = "korisnik2",
                TipKorisnika = "wow"



            };  */
            var s1 = new Salon
            {
                Id = 1,
                Naziv = "Salon1",
                Adresa = "Lenke Dundjerski 32a",
                BrojZiroRacuna = "30213941",
                Email = "ritopls@nesto.com",
                PIB = 3,
                Maticnibroj = "2013124",
                Telefon = "021/461-018",
                WebSajt = "nema"

            };
            /* var tn2 = new TipNamestaja
             {
                 Id = 2,
                 Naziv = "plakar",
                 Obrisan = false
             };
             var tn3 = new TipNamestaja
             {
                 Id = 3,
                 Naziv = "fotelja",
                 Obrisan = false
             };

             //var listaTipovaNamestaja = new List<TipNamestaja>();
             listaTipovaNamestaja.Add(tn1);
             listaTipovaNamestaja.Add(tn2);

             GenericSerializer.Serialize<TipNamestaja>("tipovi_namestaja.xml", listaTipovaNamestaja);
             Console.WriteLine("Finished Serilization...");

             var n1 = new Namestaj
             {
                 Id = 1,
                 Cena = 99.99,
                 Naziv = "DM krevet",
                 KolicinaUMagacinu = 12,
                 TipNamestaja = tn1
             };

             var listaNamestaja = new List<Namestaj>();
             listaNamestaja.Add(n1);

             GenericSerializer.Serialize<Namestaj>("namestaj.xml", listaNamestaja);
             Console.WriteLine("Finished serilization...");

             var n2 = new Namestaj
             {
                 Id = 2,
                 Cena = 69.99,
                 Naziv = "Plakar od iverice",
                 KolicinaUMagacinu = 4,
                 TipNamestaja = tn2
             };
             var n3 = new Namestaj
             {
                 Id = 3,
                 Cena = 420.00,
                 Naziv = "SkupaFotelja",
                 KolicinaUMagacinu = 15,
                 TipNamestaja = tn3
             };
             tip_namestaja.Add(tn1);
             tip_namestaja.Add(tn2);
             tip_namestaja.Add(tn3);

             namestaj.Add(n1);
             namestaj.Add(n2);
             namestaj.Add(n3);

             korisnici.Add(k1);
             korisnici.Add(k2);
             var ak1 = new Akcija {
                 Datum_Pocetka = new DateTime(2017, 10, 9),
                 Datum_Zavrsetka = new DateTime(2017, 10, 16),
                 Id = 1,
                 Popust = 10.99m
             };
             akcije.Add(ak1);
             RadSaPodacima.Instance.akcije = akcije;
            
             RadSaPodacima.Instance.tipovi_Namestaja = tip_namestaja;
             RadSaPodacima.Instance.korisnici = korisnici;
             RadSaPodacima.Instance.namestaji = namestaj;


              */

            Console.WriteLine("  .::Dobrodosli u  " + s1.Naziv + "::.");
            LogIn();

        }
        private static void Meni()
        {
            Console.WriteLine("  ");
            Console.WriteLine("  Izaberite jednu od sledecih opcija:");
            Console.WriteLine("  1 - Rad sa namestajem");
            Console.WriteLine("  2 - Rad sa korisnicima");

            int izbor = 0;
            try
            {
                do
                {
                    string str_izbor = Console.ReadLine();
                    izbor = int.Parse(str_izbor);

                }
                while (izbor < 1 || izbor > 2);
                switch (izbor)
                {

                    case 1:
                        Console.WriteLine("  Izabrali ste rad sa namestajem");
                        GlavniMeni();
                        break;
                    case 2:
                        Console.WriteLine("  Izabrali ste rad sa korisnicima");
                        GlavniMeni2();
                        break;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("  Samo broj ffs");
                Meni();
            }
        }

        private static void GlavniMeni()
        {
            ///            funkcija za ispis menija i pozivanje odgovarajuce funkcije
            Console.WriteLine("  ");
            Console.WriteLine("  Izaberite jednu od sledecih opcija:");
            Console.WriteLine("  1 - Prikaz namestaja na stanju");
            Console.WriteLine("  2 - Dodavanje novog namsetaja");
            Console.WriteLine("  3 - Izmena postojeceg namestaja");
            Console.WriteLine("  4 - brisanje namestaja");
            Console.WriteLine("  5 - povratak na izbor menija");
            Console.WriteLine("  6 - izlaz iz aplikacije");
            Provera_Unosa();


        }

        private static void GlavniMeni2()
        {
            ///            funkcija za ispis menija i pozivanje odgovarajuce funkcije
            Console.WriteLine("  ");
            Console.WriteLine("  Izaberite jednu od sledecih opcija:");
            Console.WriteLine("  1 - Prikaz svih korisnika");
            Console.WriteLine("  2 - Dodavanje novog korisnika");
            Console.WriteLine("  3 - Izmena postojeceg korisnika");
            Console.WriteLine("  4 - brisanje korisnika");
            Console.WriteLine("  5 - povratak na izbor menija");
            Console.WriteLine("  6 - izlaz iz aplikacije");
            Provera_Unosa2();


        }

        private static void Provera_Unosa()
        {
            int izbor = 0;
            try
            {
                do
                {
                    string st_izbor = Console.ReadLine();
                    izbor = int.Parse(st_izbor);
                }
                while (izbor < 1 || izbor > 6);
                switch (izbor)
                {
                    case 1:
                        Prikaz_Namestaja();
                        break;
                    case 2:
                        Console.WriteLine("  Izabrali ste dodavanje namestaja: ");
                        Novi_izmena(2);
                        break;
                    case 3:
                        Console.WriteLine("  Izabrali ste izmenu namestaja: ");
                        Novi_izmena(3);
                        break;
                    case 4:
                        Brisanje_namestaja();
                        break;
                    case 5:
                        Meni();
                        break;
                    case 6:
                        izlaz();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("morate uneti ceo broj!");
                Provera_Unosa();

            }
        }
        private static void Provera_Unosa2()
        {
            int izbor = 0;
            try
            {
                while (izbor < 1 || izbor > 6)
                {
                    string st_izbor = Console.ReadLine();
                    izbor = int.Parse(st_izbor);
                }
                if (izbor == 1)
                {
                    Prikaz_Korisnika();
                }
                else if (izbor == 2)
                {
                    Console.WriteLine("  Izabrali ste unos novog korisnika: ");
                    Dodaj_izmeni_korisnika(2);
                }
                else if (izbor == 3)
                {
                    Console.WriteLine("  Izabrali ste izmenu korisnika: ");
                    Dodaj_izmeni_korisnika(3);
                }
                else if (izbor == 4)
                {
                    Brisanje_korisnika();
                }
                else if (izbor == 5)
                {
                    Meni();
                }
                else if (izbor == 6)
                {
                    izlaz();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("morate uneti ceo broj!");
                Provera_Unosa();

            }
        }

        private static void Brisanje_korisnika()
        {
            ///funkcija koja trazi username korisnika, i brise ga iz liste
            Console.WriteLine("Unesite Username korisnika kojeg zelite da obrisete: ");
            foreach (Korisnik n in korisnici)
            {
                Console.WriteLine("|Ime: " + n.Ime + "|" + "Username: " + n.KorisnickoIme + " | ");
                Console.WriteLine("");
            };
            try
            {
                string izbor = Console.ReadLine();

                foreach (Korisnik n in korisnici)
                {
                    if (izbor.Equals(n.KorisnickoIme))
                    {
                        Console.WriteLine("Uspesno ste obrisali " + n.Ime + " " + n.Prezime);
                        korisnici.Remove(n);
                        RadSaPodacima.Instance.korisnici = korisnici;
                        GlavniMeni2();
                    }
                }
                Brisanje_korisnika();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ako se ova poruka prikazuje, onda stvarno svaka cast!");
                Brisanje_korisnika();
            }
        }

        private static void Prikaz_Korisnika()
        {
            ///            Funkcija koja prolazi kroz listu sa objektima i prikazuje njihove atribute


            Console.WriteLine("  Izabrali ste prikaz namestaja: ");
            var korisnici = RadSaPodacima.Instance.korisnici;
            foreach (Korisnik n in korisnici)
            {
                Console.WriteLine("|Ine: " + n.Ime + "|" + "Prezime: " + n.Prezime + " | " + "Username: "
                    + n.KorisnickoIme + "|" + "Password: " + n.Lozinka + "|" + "Tip korisnika: " + n.TipKorisnika + "|");
                Console.WriteLine("");
            };
            GlavniMeni2();
        }

        private static void Brisanje_namestaja()
        {
            var namestaj = RadSaPodacima.Instance.namestaji;
            Console.WriteLine("Unesite Id namestaja koji zelite da obrisete: ");
            foreach (Namestaj n in namestaj)
            {
                Console.WriteLine("|Id: " + n.Id + "|" + "Naziv: " + n.Naziv + " | ");
                Console.WriteLine("");
            };
            try
            {
                string str_izbor = Console.ReadLine();
                int izbor = int.Parse(str_izbor);
                foreach (Namestaj n in namestaj)
                {
                    if (izbor == n.Id)
                    {
                        Console.WriteLine("Uspesno ste obrisali " + n.Naziv);
                        namestaj.Remove(n);
                        RadSaPodacima.Instance.namestaji = namestaj;
                        GlavniMeni();
                    }
                }
                Brisanje_namestaja();
            }
            catch (Exception ex)
            {
                Console.WriteLine("morate uneti ceo broj!");
                Brisanje_namestaja();
            }


        }

        private static void izlaz()
        {
            ///            funkcija koja izlazi iz aplikacije
            Console.WriteLine("izlazim iz aplikacije!");
            Environment.Exit(0);
        }

        private static void Novi_izmena(int br)
        {
            ///            funkcija koja prima izbor iz menija, i prosledjuje ga metodi koja
            ///            u zavisnosti od izbora ili daje izmenu namestaja ili dodavanje novog.
            int izbor = br;
            var namestaj = RadSaPodacima.Instance.namestaji;
            if (izbor == 2)
            {
                Console.WriteLine("   ");
                Console.WriteLine("  Unesite Id novog namestaja: ");

                int id = 0;

                try
                {
                    string str_id = Console.ReadLine();
                    id = int.Parse(str_id);
                    foreach (Namestaj n in namestaj)
                    {
                        if (id == n.Id)
                        {
                            Console.WriteLine("Vec postoji namestaj sa tom sifrom!!");
                            Novi_izmena(2);
                        }

                    }
                    Unos_vrednosti_namestaja(id, 2);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("morate uneti ceo broj!");
                    Novi_izmena(2);
                }
            }
            else if (izbor == 3)
            {
                Console.WriteLine("   ");
                Console.WriteLine("  Unesite Id namestaja koji zelite da izmenite: ");
                int id = 0;

                try
                {
                    string str_id = Console.ReadLine();
                    id = int.Parse(str_id);
                    foreach (Namestaj n in namestaj)
                    {
                        if (id == n.Id)
                        {
                            Console.WriteLine("namestaj je: ");
                            Console.WriteLine("|Id: " + n.Id + "|" + "Naziv: " + n.Naziv + " | " + "Kolicina: "
                                + n.KolicinaUMagacinu + "|" + "Cena: " + n.Cena + "|" + "Tip namestaja: " + n.TipNamestaja.Naziv + "|");
                            Unos_vrednosti_namestaja(id, 3);
                        }

                    }
                    Console.WriteLine("Ne postoji namestaj sa tom sifrom!!");
                    Novi_izmena(3);

                }

                catch (Exception ex)
                {
                    Console.WriteLine("morate uneti ceo broj!");
                    Novi_izmena(3);
                }
            }
        }
        private static void Unos_vrednosti_namestaja(int kd, int izbor)
        {
            ///            funkcija koja prima id i izbor i na osnovu toga
            ///            menja ili dodaje novi namestaj.

            int id = kd;
            int izborr = izbor;
            var tip_namestaja = RadSaPodacima.Instance.tipovi_Namestaja;
            var namestaj = RadSaPodacima.Instance.namestaji;
            try
            {

                Console.WriteLine("Unesite zeljeni naziv namestaja: ");
                string naziv = Console.ReadLine();
                Console.WriteLine("Unesite kolicinu namestaja koji unosite: ");

                int kolicina = 0;

                string str_kolicina = Console.ReadLine();
                kolicina = int.Parse(str_kolicina);


                Console.WriteLine("Unesite cenu namestaja koji unosite: ");
                double cena = 0;
                string str_cena = Console.ReadLine();
                cena = double.Parse(str_cena);



                Console.WriteLine("Unesite jedan od sledecih tipova namestaja: ");
                Console.WriteLine("|" + "Tip namestaja: " + "|");
                foreach (TipNamestaja n in tip_namestaja)
                {
                    Console.WriteLine("|" + n.Naziv + "|");
                    Console.WriteLine("");
                };
                if (izborr == 2)
                {
                    try
                    {

                        string str_tip = Console.ReadLine();
                        foreach (TipNamestaja n in tip_namestaja)
                        {
                            if (n.Naziv.Equals(str_tip))
                            {
                                var nam = new Namestaj
                                {
                                    Id = id,
                                    Naziv = naziv,
                                    KolicinaUMagacinu = kolicina,
                                    Cena = cena,
                                    TipNamestaja = n

                                };
                                namestaj.Add(nam);
                                RadSaPodacima.Instance.namestaji = namestaj;
                                Console.WriteLine("Uspesno ste dodali namestaj!");
                                GlavniMeni();
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("ne postoji taj tip namestaja!");
                        Unos_vrednosti_namestaja(id, izborr);
                    }
                }
                else if (izborr == 3)
                {
                    try
                    {

                        string str_tip = Console.ReadLine();
                        foreach (TipNamestaja n in tip_namestaja)
                        {
                            if (n.Naziv.Equals(str_tip))
                            {
                                foreach (Namestaj gn in namestaj)
                                {
                                    if (gn.Id == id)
                                    {
                                        gn.Cena = cena;
                                        gn.KolicinaUMagacinu = kolicina;
                                        gn.Naziv = naziv;
                                        gn.TipNamestaja = n;

                                        
                                    }
                                }
                                RadSaPodacima.Instance.namestaji = namestaj;
                                Console.WriteLine("Uspesno ste izmenili namestaj!");
                                GlavniMeni();
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("ne postoji taj tip namestaja!");
                        Unos_vrednosti_namestaja(id, izborr);
                    }
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("niste dobro uneli podatke!");
                GlavniMeni();

            }
        }

        private static void Prikaz_Namestaja()
        {
            ///            Funkcija koja prolazi kroz listu sa objektima i prikazuje njihove atribute

            Console.WriteLine("  Izabrali ste prikaz namestaja: ");
            var namestaj = RadSaPodacima.Instance.namestaji;
            foreach (Namestaj n in namestaj)
            {
                Console.WriteLine("|Id: " + n.Id + "|" + "Naziv: " + n.Naziv + " | " + "Kolicina: " + n.KolicinaUMagacinu + "|" + "Cena: " + n.Cena + "|" + "Tip namestaja: " + n.TipNamestaja.Naziv + "|");
                Console.WriteLine("");
            };
            GlavniMeni();
        }
        private static void Dodaj_izmeni_korisnika(int br)
        {
            ///            funkcija koja prima izbor iz menija, i prosledjuje ga metodi koja
            ///            u zavisnosti od izbora ili daje izmenu korisnika ili dodavanje novog.
            int izbor = br;
            if (izbor == 2)
            {
                Console.WriteLine("   ");
                Console.WriteLine("  Unesite Username novog korisnika: ");
                var korisnici = RadSaPodacima.Instance.korisnici;

                string username = "";

                try
                {
                    username = Console.ReadLine();

                    foreach (Korisnik n in korisnici)
                    {
                        if (username.Equals(n.KorisnickoIme))
                        {
                            Console.WriteLine("  Vec postoji korisnik sa tim username-om!!");
                            Dodaj_izmeni_korisnika(2);
                        }

                    }
                    Unos_vrednosti_korisnika(username, 2);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("svaka cast!");
                    Dodaj_izmeni_korisnika(2);
                }
            }
            else if (izbor == 3)
            {
                Console.WriteLine("   ");
                Console.WriteLine("  Unesite username korisnika kojeg zelite da izmenite: ");


                try
                {
                    string username = Console.ReadLine();
                    foreach (Korisnik n in korisnici)
                    {
                        if (username.Equals(n.KorisnickoIme))
                        {
                            Console.WriteLine("korisnik je: ");
                            Console.WriteLine("|Ime: " + n.Ime + "|" + "Prezime: " + n.Prezime + " | " + "Username: "
                                + n.KorisnickoIme + "|");
                            Unos_vrednosti_korisnika(username, 3);
                        }

                    }
                    Console.WriteLine("Ne postoji korisnik sa tim username-om!!");
                    Dodaj_izmeni_korisnika(3);

                }

                catch (Exception ex)
                {
                    Console.WriteLine("greska!");
                    Dodaj_izmeni_korisnika(3);
                }
            }
        }

        private static void Unos_vrednosti_korisnika(string user, int v)
        {
            string username = user;
            int izbor = v;
            var korisnici = RadSaPodacima.Instance.korisnici;


            try
            {

                Console.WriteLine("Unesite ime korisnika: ");
                string ime = Console.ReadLine();
                Console.WriteLine("Unesite prezime korisnika: ");
                string prezime = Console.ReadLine();

                Console.WriteLine("Unesite password korisnika: ");
                string password = Console.ReadLine();

                Console.WriteLine("Unesite tip korisnika od ponudjenih korisnika: ");
                Console.WriteLine("crazy");
                Console.WriteLine("wow");
                if (izbor == 2)
                {
                    try
                    {

                        string tip = Console.ReadLine();
                        if (tip.Equals("crazy") || tip.Equals("wow"))
                        {
                            var k = new Korisnik
                            {
                                Ime = ime,
                                Prezime = prezime,
                                KorisnickoIme = username,
                                Lozinka = password,
                                TipKorisnika = tip


                            };
                            korisnici.Add(k);
                            RadSaPodacima.Instance.korisnici = korisnici;
                            Console.WriteLine("uspesno ste dodali korisnika");
                            GlavniMeni2();
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("ne postoji taj tip korisnika!");
                        Unos_vrednosti_korisnika(username, izbor);
                    }
                }
                else if (izbor == 3)
                {
                    try
                    {

                        string tip = Console.ReadLine();
                        if (tip.Equals("crazy") || tip.Equals("wow"))
                        {
                            foreach (Korisnik n in korisnici)
                            {
                                if (n.KorisnickoIme.Equals(username))
                                {
                                    n.Ime = ime;
                                    n.Prezime = prezime;
                                    n.Lozinka = password;
                                    n.TipKorisnika = tip;

                                    Console.WriteLine("Uspesno ste izmenili korisnika");
                                    GlavniMeni2();
                                }
                            }

                        }

                    }

                    catch (Exception ex)
                    {
                        RadSaPodacima.Instance.korisnici = korisnici;
                        Console.WriteLine("ne postoji taj tip korisnika!");
                        Unos_vrednosti_korisnika(username, izbor);
                    }
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("niste dobro uneli podatke!");
                GlavniMeni2();

            }
        }
        private static void LogIn()
        {
            int br = 0;
            string ime = "";
            string prezime = "";
            do
            {
                Console.WriteLine("Molim unesite vase korisnicko ime: ");
                string unos1 = Console.ReadLine();
                Console.WriteLine("Molim unesite vasu lozinku");
                string unos2 = Console.ReadLine();
                var korisnici = RadSaPodacima.Instance.korisnici;

                foreach (Korisnik n in korisnici)
                {
                    if (unos1.Equals(n.KorisnickoIme) && unos2.Equals(n.Lozinka))
                    {
                        br += 1;
                        ime = n.Ime;
                        prezime = n.Prezime;
                    }

                }

            }
            while (br != 1);

            Console.WriteLine("BRAVO! ulogovani ste kao: " + ime + " " + prezime);
            Meni();
        }

        //var listaNamestaja = GenericSerializer.Deserialize<Namestaj>("namestaj.xml");


    }

    
    
        
    

}

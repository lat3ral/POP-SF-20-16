using System;

namespace POP_20_2016_GUI.Model
{

    [Serializable]
    public class Akcija
    {
        public int id { get; set; }
        public string naziv { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "dateTime", ElementName = "pocetakAkcije")]
        public DateTime pocetakAkcije { get; set; }
        public int trajanjeAkcije { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "dateTime", ElementName = "zavrsetakAkcije")]
        public DateTime zavrsetakAkcije { get; set;}
        public double popust { get; set; }
        public bool obrisan { get; set; }


        public static Akcija GetID(int ID)
        {
            foreach (var Akcija in Projekat.instanca.Akcija)
            {
                Console.WriteLine(Akcija.id);
                if (Akcija.id.Equals(ID))
                {
                    return Akcija;
                }
            }
            return null;
        }
    }
}

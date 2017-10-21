using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_20_2016.tests
{
    public class A
    {
        //    private string ime;

        //    public string GetIme()
        //    {
        //        return this.ime;
        //    }
        //    public void SetIme(string ime)
        //    {
        //        this.ime = ime;
        //    }

        public string Ime
        {
            get
            {
                Console.WriteLine(this.Ime);
                return this.Ime;
            }
            set
            {
                this.Ime = value;
            }
        }

    }
}
    


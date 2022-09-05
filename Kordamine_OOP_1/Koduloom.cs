using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    public abstract class Koduloom
    {
        public string nimi;
        public string varv;
        //public char sugu;
        public double kaal;
        public int vanus;
        public enum Elav { Elav = 1, Surnud = 2 }; //Kui true, siis elav; kui false, siis on surnud
        public Elav elav;
        public enum Sugu { isane = 1, emane = 2 };
        public Sugu sugu;
        public Koduloom(Elav elav, Sugu sugu, string nimi = "---", string varv = "---", double kaal = 0.0, int vanus = 0)
        {
            this.nimi = nimi;
            this.varv = varv;
            this.sugu = sugu;
            this.kaal = kaal;
            this.vanus = vanus;
            this.elav = elav;
        }

        public Koduloom(Koduloom loom) //Kloonimiseks
        {
            this.nimi = loom.nimi;
            this.varv = loom.varv;
            this.sugu = loom.sugu;
            this.kaal = loom.kaal;
            this.vanus = loom.vanus;
            this.elav = loom.elav;
        }
        public abstract void print_Info();

        public void muuda_Nimi(string uusNimi) { nimi = uusNimi; }
        public void muuda_Kaal_Vanus(double uusKaal, int uusVanus) { kaal = uusKaal; vanus = uusVanus; }

        //TEST
        //public void muuda_Info() 
        //{

        //    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
        //    {}
        //}
    }
}
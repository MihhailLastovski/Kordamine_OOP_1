using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kordamine_OOP_1.Tootaja;

namespace Kordamine_OOP_1
{
    class Opilane : Isik
    {
        public string koolinimi;
        public string klass;
        public enum Spetsialiseerumine { Humanitaar, Tehnikamees }
        public Spetsialiseerumine spetsialiseerumine;
        public enum Koduloom_on { Jah, Ei}
        public Koduloom_on koduloom_on;
        public enum Huviringid { Joonistamine, Tantsimine, Robootika}
        public Huviringid huviringid;

        public Opilane(string nimi, int synniAasta, Sugu sugu, string koolinimi, string klass, Spetsialiseerumine spetsialiseerumine) : base(nimi, synniAasta, sugu)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
        }
        public Opilane(string nimi, int synniAasta, Sugu sugu, string koolinimi, string klass, Spetsialiseerumine spetsialiseerumine, Koduloom_on koduloom_on) : base(nimi, synniAasta, sugu)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
        }
        public Opilane(string nimi, int synniAasta, Sugu sugu, string koolinimi, string klass, Spetsialiseerumine spetsialiseerumine, Koduloom_on koduloom_on, Huviringid huviringid) : base(nimi, synniAasta, sugu)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
            this.koduloom_on = koduloom_on;
            this.huviringid = huviringid;
        }

        public override double calculateIncome(double brutto, double maksuvaba)
        {
            throw new NotImplementedException();
        }

        public override void printInfo()
        {
            Console.WriteLine("Opilane");
            Console.WriteLine($"Nimi: {nimi} \nSugu: {sugu} \nSynniaasta: {synniAasta} \nVanus: {calculateAge()} \nKoolinimi: {koolinimi} \nKlass: {klass} \nSpetsialiseerumine: {spetsialiseerumine} \nKoduloom: {koduloom_on} \nHuviringid: {huviringid} \n");
        }
    }

}
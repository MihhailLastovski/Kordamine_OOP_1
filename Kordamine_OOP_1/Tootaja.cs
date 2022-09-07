using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    
    public class Tootaja : Isik
    {
        public string asutus;
        public enum Amet { Ehitaja, Tuletõrjuja, Kontoritöötaja }
        public Amet amet;
        public double tootasu;
        public double netopalk;
        public enum Praktika { Ei, Jah}
        public Praktika praktika;

        public Tootaja(Sugu sugu, string nimi, int synniAasta, string asutus, Amet amet, double tootasu) : base(nimi, synniAasta, sugu)
        {
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu = tootasu;

        }
        public Tootaja(Sugu sugu, string nimi, int synniAasta, string asutus, Amet amet) : base(nimi, synniAasta, sugu)
        {
            this.asutus = asutus;
            this.amet = amet;

        }
        public Tootaja(Sugu sugu, string nimi, int synniAasta, string asutus, Amet amet, double tootasu, Praktika praktika) : base(nimi, synniAasta, sugu)
        {
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu = tootasu;
            this.praktika = praktika;
        }

        public override double calculateIncome(double tulumaks, double maksuvaba)
        {
            if (praktika == Praktika.Jah)
            {
                netopalk = (((tootasu - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba) / 2.5;
            }
            else
            {
                netopalk = ((tootasu - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            }
            return netopalk;
        }

        public override void printInfo()
        {
            Console.WriteLine("Tootaja");
            if (praktika == Praktika.Ei)
            {
                Console.WriteLine($"Nimi: {nimi} \nSugu: {sugu} \nSynniaasta: {synniAasta} \nVanus: {calculateAge()} \nAsutus: {asutus} \nAmet: {amet} \nTootasu: {netopalk}$ \n");
            }
            else
            {
                Console.WriteLine($"Nimi: {nimi} \nSugu: {sugu} \nSynniaasta: {synniAasta} \nVanus: {calculateAge()} \nAsutus: {asutus} \nAmet: {amet} \nPraktika: {praktika} \nTootasu: {netopalk}$ \n");
            }
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kordamine_OOP_1.Opilane;

namespace Kordamine_OOP_1
{
    class Kutsekooliopilane : Isik
    {
        public enum Oppeasutus { Tartu_Ülikool, Tallinna_Ülikool, Tallinna_Tehnikaülikool }
        public Oppeasutus oppeasutus;
        public string eriala;
        public int kursus;
        public double toetus;
        public enum Korvaltoo { Jah, Ei }
        public Korvaltoo korvaltoo;
        public double tootasu;
        public double netopalk;
        public int sissepaas_kuupaev;
        public int lopp_kuupaev;
        public int study_years;
        public Kutsekooliopilane(string nimi, int synniAasta, Sugu sugu, Oppeasutus oppeasutus, string eriala, int kursus, double toetus) : base(nimi, synniAasta, sugu)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
        }
        public Kutsekooliopilane(string nimi, int synniAasta, Sugu sugu, Oppeasutus oppeasutus, string eriala, int kursus, double toetus, Korvaltoo korvaltoo, double tootasu) : base(nimi, synniAasta, sugu)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
            this.tootasu = tootasu;
            this.korvaltoo = korvaltoo;
        }
        public Kutsekooliopilane(string nimi, int synniAasta, Sugu sugu, Oppeasutus oppeasutus, string eriala, int kursus, double toetus, int lopp_kuupaev, int sissepaas_kuupaev) : base(nimi, synniAasta, sugu)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
            this.lopp_kuupaev = lopp_kuupaev;
            this.sissepaas_kuupaev = sissepaas_kuupaev;
        }
        public override double calculateIncome(double tulumaks, double maksuvaba)
        {
            netopalk = ((tootasu - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }
        public int calculate_study_years(int sissepaas_kuupaev, int lopp_kuupaev)
        {
            study_years = lopp_kuupaev - sissepaas_kuupaev;
            return study_years;
        }

        public override void printInfo()
        {
            Console.WriteLine("Kutsekooli");
            if (tootasu != 0)
            {
                Console.WriteLine($"Nimi: {nimi} \nSugu: {sugu} \nSynniaasta: {synniAasta} \nVanus: {vanus} \nOppeasutus: {oppeasutus} \nEriala: {eriala} \nKursus: {kursus} \nToetus: {toetus}$ \nKorvaltoo: {korvaltoo} \nNetopalk: {netopalk}$ \n");

            }
            else if (tootasu == 0 && study_years == 0)
            {
                Console.WriteLine($"Nimi: {nimi} \nSugu: {sugu} \nSynniaasta: {synniAasta} \nVanus: {vanus} \nOppeasutus: {oppeasutus} \nEriala: {eriala} \nKursus: {kursus} \nToetus: {toetus}$ \n");
            }
            else if (tootasu == 0 && study_years >= 0)
            {
                Console.WriteLine($"Nimi: {nimi} \nSugu: {sugu} \nSynniaasta: {synniAasta} \nVanus: {vanus} \nOppeasutus: {oppeasutus} \nEriala: {eriala} \nKursus: {kursus} \nToetus: {toetus}$ \nAastaid opinguid: {study_years} \n");
            }
        }
    }
}

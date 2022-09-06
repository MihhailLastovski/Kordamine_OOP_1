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
        public double kesk_hinne;
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
        public Kutsekooliopilane(string nimi, int synniAasta, Sugu sugu, string elukoht, Pere_suurus pere_suurus, Oppeasutus oppeasutus, string eriala, int kursus, int lopp_kuupaev, int sissepaas_kuupaev, double kesk_hinne) : base(nimi, synniAasta, sugu, elukoht, pere_suurus)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.lopp_kuupaev = lopp_kuupaev;
            this.sissepaas_kuupaev = sissepaas_kuupaev;
            this.kesk_hinne = kesk_hinne;
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
        public string calculate_toetus() 
        {
            if ((elukoht == "Tallinn" && oppeasutus == Oppeasutus.Tallinna_Tehnikaülikool || elukoht == "Tallinn" && oppeasutus == Oppeasutus.Tallinna_Ülikool || elukoht == "Tartu" && oppeasutus == Oppeasutus.Tartu_Ülikool) && kesk_hinne >= 3.5)
            {
                return ("Põhitoetus");
            }
            else if ((elukoht != "Tallinn" || elukoht != "Tartu") && kesk_hinne >= 3.5)
            {
                return ("Sõidutoetus ja põhitoetus");
            }
            else if ((elukoht != "Tallinn" || elukoht != "Tartu") && kesk_hinne <= 3.5)
            {
                return ("Sõidutoetus 30");
            }
            //else if (())
            //{
            //    return ("Eritoetus 45");
            //}
            else { return (" "); }
        }
        public override void printInfo()
        {
            Console.WriteLine("Kutsekooli");
            if (tootasu != 0)
            {
                Console.WriteLine($"Nimi: {nimi} \nSugu: {sugu} \nSynniaasta: {synniAasta} \nVanus: {calculateAge()} \nOppeasutus: {oppeasutus} \nEriala: {eriala} \nKursus: {kursus} \nToetus: {toetus}$ \nKorvaltoo: {korvaltoo} \nNetopalk: {netopalk}$ \n");

            }
            else if (tootasu == 0 && study_years == 0)
            {
                Console.WriteLine($"Nimi: {nimi} \nSugu: {sugu} \nSynniaasta: {synniAasta} \nVanus: {calculateAge()} \nOppeasutus: {oppeasutus} \nEriala: {eriala} \nKursus: {kursus} \nToetus: {toetus}$ \n");
            }
            else if (tootasu == 0 && study_years >= 0)
            {
                Console.WriteLine($"Nimi: {nimi} \nSugu: {sugu} \nSynniaasta: {synniAasta} \nVanus: {calculateAge()} \nOppeasutus: {oppeasutus} \nEriala: {eriala} \nKursus: {kursus} \nToetus: {calculate_toetus()} \nAastaid opinguid: {study_years} \n");
            }
        }
    }
}

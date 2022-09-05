using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    public class Rott : Koduloom
    {
        private string toug;
        private double saba_pikkus;
        private string toit;

        public Rott(Elav elav, string nimi, string varv, Sugu sugu, double kaal, int vanus, string toug, double saba_pikkus, string toit) : base(elav, sugu, nimi, varv, kaal, vanus)
        {
            this.toug = toug;
            this.saba_pikkus = saba_pikkus;
            this.toit = toit;
        }

        public override void print_Info()
        {
            Console.WriteLine($"{elav} {varv} {nimi} ta on {sugu} ja tema kaal on {kaal} ja ta on {vanus} aastat vana. \nRoti tõug on {toug} ja saba pikkus on {saba_pikkus} cm, rott sööb {toit}.");

        }
    }
}
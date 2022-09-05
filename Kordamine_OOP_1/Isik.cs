using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    public abstract class Isik
    {
        public string nimi;
        public int synniAasta { get; set; }
        public enum Sugu { Mees, Naine }
        public Sugu sugu;
        public int vanus;

        public Isik(string nimi, int synniAasta, Sugu sugu)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.sugu = sugu;
        }

        public abstract void printInfo();
        public int calculateAge()
        {
            vanus = DateTime.Now.Year - synniAasta;
            return vanus;
        }
        public void changeName(string uusNimi) { nimi = uusNimi; }

        public abstract double calculateIncome(double brutto, double maksuvaba);

    }
}
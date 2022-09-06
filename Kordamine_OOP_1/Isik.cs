using System;
using System.Collections.Generic;
using System.IO.Pipes;
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
        public double kasvu;
        public double kaal;
        public string answer_avg;
        public string elukoht;

        public Isik(string nimi, int synniAasta, Sugu sugu)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.sugu = sugu;
        }
        public Isik(string nimi, int synniAasta, Sugu sugu, double kasvu, double kaal)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.sugu = sugu;
            this.kasvu = kasvu;
            this.kaal = kaal;
        }
        public Isik(string nimi, int synniAasta, Sugu sugu, string elukoht)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.sugu = sugu;
            this.elukoht = elukoht;
        }

        public abstract void printInfo();
        public int calculateAge()
        {
            int vanus = DateTime.Now.Year - synniAasta;
            return vanus;
        }
        public void changeName(string uusNimi) { nimi = uusNimi; }

        public abstract double calculateIncome(double brutto, double maksuvaba);
        public string calculateAvg(double kasvu, double kaal)
        {
            double calculate_avg = kaal / Math.Pow(kasvu, 2);
            if (calculate_avg < 18.5 && calculate_avg > 0)
            {
                answer_avg = "Massipuudus";
            }
            else if (calculate_avg >= 18.5 && calculate_avg < 25)
            {
                answer_avg = "Normaalne mass";
            }
            else if (calculate_avg >= 25 && calculate_avg < 35)
            {
                answer_avg = "Ülekaaluline";
            }
            else if (calculate_avg > 35)
            {
                answer_avg = "Ülekaalulisus";
            }
            return answer_avg;
        }
    }
}
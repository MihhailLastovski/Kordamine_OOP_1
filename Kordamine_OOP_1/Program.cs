using Kordamine_OOP_1;
using System;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Xml.Linq;

//Koduloom kassKloon = new Rott(kass);
//kassKloon.muuda_Nimi("MurkaKloon");
//kassKloon.muuda_Kaal_Vanus(6.23, 9);
//kassKloon.muuda_Elav(false);
//kassKloon.print_Info ();

//Rott rott = new Rott(Koduloom.Elav.Elav, "Karl", "hall", Koduloom.Sugu.isane, 1.54, 5, "ilus", 23, "kapsas");
//rott.print_Info ();


//Harjutus


List<Tootaja> people_t = new List<Tootaja>();
List<Kutsekooliopilane> people_k = new List<Kutsekooliopilane>();
List<Opilane> people_o = new List<Opilane>();
//Tootaja
//1
Tootaja tootaja = new Tootaja(Isik.Sugu.Mees, "Marco", 2003, "Telia", Tootaja.Amet.Kontoritöötaja, 1000);
tootaja.calculateIncome(20, 500);
tootaja.calculateAge();

//2
Tootaja tootaja2 = new Tootaja(Isik.Sugu.Mees, "Dencik", 2000, "Euronics", Tootaja.Amet.Tuletõrjuja, 1700,Tootaja.Praktika.Jah);
tootaja2.calculateIncome(20, 500);
tootaja2.calculateAge();

//Opilane
Opilane opilane = new Opilane("Maria", 2010, Isik.Sugu.Naine, "Tallinna Realkool", "5b", Opilane.Spetsialiseerumine.Tehnikamees, Opilane.Koduloom_on.Ei, Opilane.Huviringid.Robootika);
opilane.calculateAge();
opilane.changeName("Tatjana");

//Kutsekooli
//1
Kutsekooliopilane kutsekooliopilane = new Kutsekooliopilane("Vasja", 1999, Isik.Sugu.Mees, Kutsekooliopilane.Oppeasutus.Tartu_Ülikool, "Arst", 3, 60);
kutsekooliopilane.calculateAge();
kutsekooliopilane.changeName("Petr");

//2
Kutsekooliopilane kutsekooliopilane2 = new Kutsekooliopilane("Lera", 2000, Isik.Sugu.Naine, Kutsekooliopilane.Oppeasutus.Tallinna_Ülikool, "Kokk", 2, 50, 2023, 2021);
kutsekooliopilane2.calculateAge();
kutsekooliopilane2.calculate_study_years(2021, 2023);

//3
Kutsekooliopilane kutsekooliopilane3 = new Kutsekooliopilane("Maksim", 1996, Isik.Sugu.Mees, Kutsekooliopilane.Oppeasutus.Tallinna_Tehnikaülikool, "Tarkvara arendaja", 5, 70, Kutsekooliopilane.Korvaltoo.Jah, 679);
kutsekooliopilane3.calculateAge();
kutsekooliopilane3.calculateIncome(20,500);

//4
Kutsekooliopilane kutsekooliopilane4 = new Kutsekooliopilane("Vlad", 2000, Isik.Sugu.Mees, "Narva",Isik.Pere_suurus.Suur,Kutsekooliopilane.Oppeasutus.Tallinna_Ülikool, "Kokk", 2, 2023, 2021, 4);
kutsekooliopilane4.calculateAge();
kutsekooliopilane4.calculate_study_years(2021, 2023);

people_t.Add(tootaja);
people_t.Add(tootaja2);
people_k.Add(kutsekooliopilane);
people_k.Add(kutsekooliopilane2);
people_o.Add(opilane);

StreamWriter to_file = new StreamWriter(@"..\..\..\People.txt", false);
foreach (Tootaja p in people_t)
{
    to_file.WriteLine("Tootaja" + "-" + p.nimi+"-"+ p.calculateAge()+"-"+ p.synniAasta+"-"+ p.sugu +"-"+ p.asutus +"-"+p.amet+"-"+p.tootasu +"-" + p.praktika);
}
foreach (Opilane p in people_o)
{
    to_file.WriteLine("Opilane" + "-" + p.nimi + "-" + p.calculateAge() + "-" + p.synniAasta + "-" + p.sugu + "-" + p.koolinimi + "-" + p.klass + "-" + p.spetsialiseerumine + "-" + p.koduloom_on + "-" + p.huviringid);
}
foreach (Kutsekooliopilane p in people_k)
{
    to_file.WriteLine("Kutsekooliopilane" + "-" + p.nimi + "-" + p.calculateAge() + "-" + p.synniAasta + "-" + p.sugu + "-" + p.oppeasutus + "-" + p.eriala + "-" + p.kursus+ "-" + p.toetus + "-" + p.lopp_kuupaev + "-" + p.sissepaas_kuupaev);
}
to_file.Close();

var from_file_ = File.ReadAllLines(@"..\..\..\People.txt");
StreamReader from_file = new StreamReader(@"..\..\..\People.txt");

List<Tootaja> toootajas = new List<Tootaja>();
List<Opilane> opilased = new List<Opilane>();
List<Kutsekooliopilane> kutsekooliopilanes = new List<Kutsekooliopilane>();



for (int i = 0; i < from_file_.Length; i++)
{
    string[] row_count = from_file_[i].Split('-');

    switch (row_count[0])
    {
        case "Tootaja":
            toootajas.Add(new Tootaja((Isik.Sugu)Enum.Parse(typeof(Isik.Sugu), row_count[4], true), row_count[1], int.Parse(row_count[3]), row_count[5], (Tootaja.Amet)Enum.Parse(typeof(Tootaja.Amet), row_count[6], true), double.Parse(row_count[7])));
            break;
        case "Opilane":
            opilased.Add(new Opilane(row_count[1], int.Parse(row_count[3]), (Isik.Sugu)Enum.Parse(typeof(Isik.Sugu), row_count[4], true), row_count[5], row_count[6], (Opilane.Spetsialiseerumine)Enum.Parse(typeof(Opilane.Spetsialiseerumine), row_count[7], true), (Opilane.Koduloom_on)Enum.Parse(typeof(Opilane.Koduloom_on), row_count[8], true), (Opilane.Huviringid)Enum.Parse(typeof(Opilane.Huviringid), row_count[9], true)));
            break;
        case "Kutsekooliopilane":
            kutsekooliopilanes.Add(new Kutsekooliopilane(
                row_count[1],
                int.Parse(row_count[3]),
                (Isik.Sugu)Enum.Parse(typeof(Isik.Sugu), row_count[4], true),
                (Kutsekooliopilane.Oppeasutus)Enum.Parse(typeof(Kutsekooliopilane.Oppeasutus),
                row_count[5], true),
                row_count[6],
                int.Parse(row_count[7]),
                double.Parse(row_count[8]),
                int.Parse(row_count[9]),
                int.Parse(row_count[10])
                ));
            break;
        default:
            // code block
            break;
    }

}
foreach (Tootaja p in toootajas)
{
    p.printInfo();

}
foreach (Opilane p in opilased)
{
    p.printInfo();

}
foreach (Kutsekooliopilane p in kutsekooliopilanes)
{
    p.printInfo();

}
from_file.Close();
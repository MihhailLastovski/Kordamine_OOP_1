using Kordamine_OOP_1;
using System;
using System.IO;
using System.Xml.Linq;

//Koduloom kassKloon = new Rott(kass);
//kassKloon.muuda_Nimi("MurkaKloon");
//kassKloon.muuda_Kaal_Vanus(6.23, 9);
//kassKloon.muuda_Elav(false);
//kassKloon.print_Info ();

//Rott rott = new Rott(Koduloom.Elav.Elav, "Karl", "hall", Koduloom.Sugu.isane, 1.54, 5, "ilus", 23, "kapsas");
//rott.print_Info ();


//Harjutus

List<Isik> people = new List<Isik>();
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

people.Add(tootaja);
people.Add(tootaja2);
people.Add(opilane);
people.Add(kutsekooliopilane);
people.Add(kutsekooliopilane2);
people.Add(kutsekooliopilane3);
people.Add(kutsekooliopilane4);
StreamWriter to_file = new StreamWriter(@"..\..\..\People.txt", false);
foreach (Isik p in people)
{
    p.printInfo();
    to_file.WriteLine(p.nimi+","+ p.calculateAge()+ "," + p.sugu + ";");
}
to_file.Close();
var from_file_ = File.ReadAllLines(@"..\..\..\People.txt");
StreamReader from_file = new StreamReader(@"..\..\..\People.txt");
int line_count = from_file.ReadToEnd().Split(new char[] { ';' }).Length-1;
Console.WriteLine(line_count);
for (int i = 0; i < people.Count; i++)
{ 
    string[] row_count = from_file_[i].Split(',');
    Console.WriteLine("1 - " + row_count[0] + " 2 - " + row_count[1] + " 3 - " + row_count[2].Split(';')[0]);
}

from_file.Close();
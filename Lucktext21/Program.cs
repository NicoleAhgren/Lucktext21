using System;

string name = "";
string mat = "";
string person = "";
string ställe = "";

Console.WriteLine("Vad heter du?");
name = Console.ReadLine();

Console.WriteLine("Skriv in en maträtt");
mat = Console.ReadLine();

Console.WriteLine("Skriv in någon annans namn");
person = Console.ReadLine();

Console.WriteLine("Skriv in en plats (exempelvis: i en skog, på ett berg)");
ställe = Console.ReadLine();

Console.WriteLine($"{name} och {person} är {ställe}, de sitter där och äter {mat}");

Console.WriteLine("Tryck på ENTER för att avsluta");
Console.ReadLine();



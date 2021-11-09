using System;

int hp1 = 20;
int hp2 = 20;
int atk1 = 5;
int atk2 = 5;

string name1 = "";
string name2 = "Pikachu";

Random rndmAtk = new Random();

Console.WriteLine("Vad heter du?");
name1 = Console.ReadLine();

Console.WriteLine($"{name1} möter {name2}.");

while (hp1 > 0 && hp2 > 0)
{
    int rndm1 = rndmAtk.Next(1, atk1 + 1);
    int rndm2 = rndmAtk.Next(1, atk2 + 1);

    hp2 -= rndm1;
    Console.WriteLine($"{name1} attackerade {name2}. {name2} har nu {hp2}hp");
    hp1 -= rndm2;
    Console.WriteLine($"{name2} attackerade {name1}. {name1} har nu {hp1}hp");
}
if (hp1 <= 0 && hp2 <= 0)
{
    Console.WriteLine($"Det blev oavgjort");
}
else {
    if (hp1 <= 0)
    {
        Console.WriteLine($"{name2} vann");
    }
    else {
        if (hp2 <= 0)
        {
            Console.WriteLine($"{name1} vann");
        }
    }
}
Console.ReadLine();
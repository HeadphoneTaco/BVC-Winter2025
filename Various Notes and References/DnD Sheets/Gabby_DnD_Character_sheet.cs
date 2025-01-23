Jan 21, 2025
Code From Gabby

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

Console.WriteLine("WELCOME TO D&D");
Console.WriteLine("ENTER YOUR CHARACTERS NAME");
string PlayerName = Console.ReadLine();
Console.WriteLine("SELECT YOUR CHARACTER");
Console.WriteLine("1. BARD");
Console.WriteLine("2. CLERIC");
Console.WriteLine("3. DRUID");
Console.WriteLine("4. FIGHTER");
Console.WriteLine("5. MAGE");
Console.WriteLine("6. PALADIN");
int answer = int.Parse(Console.ReadLine()); // is a method that convert text into numbers 
string classtype = "None"; // Assigning a default value

switch (answer) // helps for simplify the multiple decisions in the code 
{
    case 1:
         Console.WriteLine("YOU CHOOSE 'BARD'.");
         classtype = "BARD";
        break;
    case 2:
        Console.WriteLine("YOU CHOOSE 'CLERIC'.");
        classtype = "CLERC";
        break;
    case 3:
        Console.WriteLine("YOU CHOOSE 'DRUID'.");
        classtype = "DRUID";
        break;
    case 4:
        Console.WriteLine("YOU CHOOSE 'FIGHTER'.");
        classtype = "FIGHTER";
        break;
    case 5:
        Console.WriteLine("YOU CHOOSE 'MAGE'.");
        classtype = "MAGE";
        break;
    case 6:
        Console.WriteLine("YOU CHOOSE 'PALADIN'.");
        classtype = "PALADIN";
        break;
    default: // is like an else
        Console.WriteLine("Please, enter a valid answer.");
        break;
}
Console.WriteLine("-------------------------");
Console.WriteLine("UPGRADING YOUR SCORE");
//1strenght
Random statnumber = new Random();  // Create a Random object
int strenghtInt = statnumber.Next(15);
int strenght1 = statnumber.Next(strenghtInt);
int strenght2 = statnumber.Next(strenghtInt);johh
int strenght3 = statnumber.Next(strenghtInt);
int Finalstrenght = strenght1 + strenght2 + strenght3;
Console.WriteLine("Strenght score =  " + Finalstrenght);
//2wisdom
int wisdomInt = statnumber.Next(15);
int wisdom1 = statnumber.Next(wisdomInt);
int wisdom2 = statnumber.Next(wisdomInt);
int wisdom3 = statnumber.Next(wisdomInt);
int Finalwisdom = wisdom1 + wisdom2 + wisdom3;
Console.WriteLine("Wisdom score =  " + Finalwisdom);
//3Dexterity
int DexterityInt = statnumber.Next(15);
int Dexterity1 = statnumber.Next(DexterityInt);
int Dexterity2 = statnumber.Next(DexterityInt);
int Dexterity3 = statnumber.Next(DexterityInt);
int FinalDexterity = Dexterity1 + Dexterity2 + Dexterity3;
Console.WriteLine("Dexterity score =  " + FinalDexterity);
//4 Constitution
int Constitution = statnumber.Next(15);
int Constitution1 = statnumber.Next(Constitution);
int Constitution2 = statnumber.Next(Constitution);
int Constitution3 = statnumber.Next(Constitution);
int FinalConstitution = Constitution1 + Constitution2 + Constitution3;
Console.WriteLine("Constitution score =  " + FinalConstitution);
//5 Charsima
int Charsima = statnumber.Next(15);
int Charsima1 = statnumber.Next(Charsima);
int Charsima2 = statnumber.Next(Charsima);
int Charsima3 = statnumber.Next(Charsima);
int FinalCharsima = Charsima1 + Charsima2 + Charsima3;
Console.WriteLine("Charsima score =  " + FinalCharsima);
//6 Intelligence
int Intelligence = statnumber.Next(15);
int Intelligence1 = statnumber.Next(Intelligence);
int Intelligence2 = statnumber.Next(Intelligence);
int Intelligence3 = statnumber.Next(Intelligence);
int FinalIntelligence = Intelligence1 + Intelligence2 + Intelligence3;
Console.WriteLine("Intelligence score =  " + FinalIntelligence);

int AbilitieScore = Finalstrenght + FinalDexterity + FinalCharsima + Finalwisdom +FinalConstitution + FinalIntelligence;
Console.WriteLine("-------------------------");
Console.WriteLine("Name: " + PlayerName);
Console.WriteLine("Class: " + classtype);
Console.WriteLine("Ability Final Score: " + AbilitieScore);
Console.WriteLine("NOW YOU ARE READY TO FIGHT");
Console.WriteLine("▬|)═══════>");
Console.WriteLine("END");
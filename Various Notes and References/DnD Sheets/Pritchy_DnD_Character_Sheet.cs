Jan 21, 2025
Code from Pritchy

// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information 
// 
// using System.ComponentModel; 

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

int selectedClass;

 
Console.WriteLine("Hello...Mysterious Place");  
Console.WriteLine("Welcome to the Dungeons & Dragons Character Generator"); 

Console.WriteLine(" Hey, what is your character name?");
string userInput = Console.ReadLine();

 
Console.WriteLine("Select a class"); 
Console.WriteLine("fighter"); 
Console.WriteLine("Mage"); 
Console.WriteLine("Assassin"); 
string chosenClass = Console.ReadLine();
 
//Ability Scores for a Character 
string[] stats = { "Strength", "Wisdom", "Intelligence" , "Charisma", "Dexterity", "Constituition"  };
int[] abilityscores = new int [6];

//make a while loop function for error handling

Console.WriteLine($"strength");

Console.WriteLine("How much is your Strength Level");
string strength = Console.ReadLine();
Console.WriteLine ("strength= "+strength);

int strengthLevel = int.Parse(strength);
if (strengthLevel < 1 || strengthLevel > 20) 
{
    Console.WriteLine("This is Wrong");
}
Console.WriteLine($"wisdom");
Console.WriteLine("How much is your Wisdom Level");
   string wisdom = Console.ReadLine();
        Console.WriteLine("wisdom= "+wisdom);
        int wisdomLevel = int.Parse(wisdom); 
if (wisdomLevel  < 1 || wisdomLevel > 20)
{
    Console.WriteLine("This is wrong");
}
int intelligenceLevel = int.Parse(wisdom); 
if (intelligenceLevel  < 1 || intelligenceLevel > 20)
{
    Console.WriteLine("This is wrong");
}
Console.WriteLine($"intelligence");
Console.WriteLine("How much is your intelligence Level");
string intelligence = Console.ReadLine();
Console.WriteLine("intelligence= "+intelligence);
Console.WriteLine($"Charisma");

int charismaLevel = int.Parse(wisdom);
if (charismaLevel < 1 || charismaLevel > 20)
{
    Console.WriteLine("This is wrong");
}

Console.WriteLine("How much is your Charisma");
    string charisma = Console.ReadLine();
    Console.WriteLine("charisma= "+charisma);
    Console.WriteLine($"Dexterity"); 

int dexterityLevel = int.Parse(wisdom); 
if (dexterityLevel  < 1 || dexterityLevel > 20)
{
    Console.WriteLine("This is wrong");
}
Console.WriteLine("How much is your Dexterity Level");
string dexterity = Console.ReadLine();
Console.WriteLine("Dexterity");

Console.WriteLine($"Constitution");
int constitutionLevel = int.Parse(wisdom); 
if (constitutionLevel  < 1 || constitutionLevel > 20)
{
    Console.WriteLine("This is wrong");
}
Console.WriteLine("How much is your Constitution Level");
string constitution = Console.ReadLine();
Console.WriteLine($"5: {constitution}");

Console.WriteLine("------------------------------------");
Console.WriteLine("Character name:" + userInput);
Console.WriteLine("Class: " + chosenClass);

Console.WriteLine("Strength: " + strength);
Console.WriteLine("Wisdom: " + wisdom);
Console.WriteLine("Intelligence: " + intelligence);
Console.WriteLine("Charisma: " + charisma);
Console.WriteLine("Dexterity: " + dexterity);
Console.WriteLine("Constitution:" + constitution);
Jan 21, 2025
Code From Luke

// See https://aka.ms/new-console-template for more information

using System.Data.Common;
using System.Diagnostics;
using System.Numerics;
using System.Reflection.Metadata;

Console.WriteLine("Welcome or something");

                //char name n stuff

                Console.WriteLine("input Name");

              
                string playername = Console.ReadLine();
                Console.Clear();
                    
                    //Classes n stuff

                    Console.WriteLine("Select class");
                    Console.WriteLine("1: Rogue");
                    Console.WriteLine("2: Wizard");
                    Console.WriteLine("3: Fighter");
                    Console.WriteLine("4: Mage");
                    Console.WriteLine("5: Ranger");
                    Console.WriteLine("6: Thief"); 
                    Console.WriteLine("7: Paladin");
                    string classes = ("none"); //predetermined name / value
                    int choice = int.Parse(Console.ReadLine());
switch (choice)
                  { 
                      
                      case 1 : Console.WriteLine("You have Chosen Rouge");
                          classes = ("Rouge");
                          break;

                      case 2 : Console.WriteLine("You have Chosen Wizard");
                          classes = ("Wizard");
                          break;
                      
                      case 3 : Console.WriteLine("You have chosen Fighter");
                          classes = ("Fighter");
                          break;
                      
                      case 4 : Console.WriteLine("You have chosen Mage");
                          classes = ("Mage");
                          break;
                      
                      case 5 : Console.WriteLine("You have chosen Ranger");
                          classes = ("Ranger");
                          break;
                      
                      case 6 : Console.WriteLine("You have chosen Thief");
                          classes = ("Thief");
                          break;
                      
                      case 7 : Console.WriteLine("You have chosen Paladin");
                          classes = ("Paladin");
                          break;
                      default : Console.WriteLine("You have chosen null");
                          classes = ("null");
                          break;
                      
                  }
Console.Clear();


//psudorandom number gen
    //str
    Random statnumber = new Random();
    int strength1 = statnumber.Next(1,7);
    int strength2 = statnumber.Next(1,7);
    int strength3 = statnumber.Next(1,7);
    int strength4 = statnumber.Next(1,7);
    int strengthmin1 = Math.Min(strength1, strength1);
    int strengthmin2 = Math.Min(strength2, strength2);
    int strengthmin = Math.Min(strengthmin1,strengthmin2);
    int strength = (strength1 + strength2 + strength3 + strength4 - strengthmin );
    //- min
    //dex
    int Dexterity1 = statnumber.Next(1, 7);
    int Dexterity2 = statnumber.Next(1, 7);
    int Dexterity3 = statnumber.Next(1, 7);
    int Dexterity4 = statnumber.Next(1, 7);
    int Dexteritymin1 = Math.Min(Dexterity1, Dexterity1);
    int Dexteritymin2 = Math.Min(Dexterity2, Dexterity2);
    int Dexteritymin = Math.Min(Dexteritymin1, Dexteritymin2);
    int Dexterity = (Dexterity1 + Dexterity2 + Dexterity3 + Dexterity4 - Dexteritymin);
    //int
    int Intelligence1 = statnumber.Next(1, 7);
    int Intelligence2 = statnumber.Next(1, 7);
    int Intelligence3 = statnumber.Next(1, 7);
    int Intelligence4 = statnumber.Next(1, 7);
    int Intelligencemin1 = Math.Min(Intelligence1, Intelligence1);
    int Intelligencemin2 = Math.Min(Intelligence2, Intelligence2);
    int Intelligencemin = Math.Min(Intelligencemin1, Intelligencemin2);
    int Intelligence = (Intelligence1 + Intelligence2 + Intelligence3 + Intelligence4 - Intelligencemin);
    //con
    int Constitution1 = statnumber.Next(1, 7);
    int Constitution2 = statnumber.Next(1, 7);
    int Constitution3 = statnumber.Next(1, 7);
    int Constitution4 = statnumber.Next(1, 7);
    int Constitutionmin1 = Math.Min(Constitution1, Constitution1);
    int Constitutionmin2 = Math.Min(Constitution2, Constitution2);
    int Constitutionmin = Math.Min(Constitutionmin1, Constitutionmin2);
    int Constitution = (Constitution1 + Constitution2 + Constitution3 + Constitution4 - Constitutionmin);

Console.Clear();
//preset code


//string userInput = Console.ReadLine();
//this reads user input and saves it in the userInput variable
//int userInputNumber = int.Parse(userInput);
//this parses a string into a number if it is a number
//note: this works better with int.TryParse(....), but we will let you look up how to use that
string combinedWords = "Dungeons " + "& " + "Dragons"; //this is how you combine three strings into one: "Dungeons and Dragons"

string combinedWords2 =" Name : " + playername;
string combinedWords3 =" Class : " + classes;


//start of the list

Console.WriteLine(combinedWords);

//Console.WriteLine("Name:");

Console.WriteLine(combinedWords2);

    //class

    //Console.WriteLine("Class:");

    Console.WriteLine(combinedWords3);



            //listing stats
            Console.WriteLine(" Strength");

            Console.WriteLine(strength);

            Console.WriteLine(" Dexterity");

            Console.WriteLine(Dexterity);

            Console.WriteLine(" Intelligence");

            Console.WriteLine(Intelligence);
            
            Console.WriteLine(" Constitution");
            
            Console.WriteLine(Constitution);
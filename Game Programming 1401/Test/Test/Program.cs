// Link is given a certain amount of Rupees
// Return the amount of Silver/Purple/Red/Yellow/Blue/Green rupees as a return
//In groups of 3, work together to figure out how to make this work
// Hint: the modulus operator (%) can be useful for returning a remainder
// Silver = 100
// Purple = 50
// Red = 20
// Yellow = 10
// Blue = 5
// Green = 1

// Example: 28 rupees will return a red, blue, and 3 green rupees

        enum Rupees
        {
            Silver = 100,
            Purple = 50,
            Red = 20,
            Yellow = 10,
            Blue = 5,
            Green = 1
        }
        
        class Program
        {
            static void Main()
            {
                // Get the rupee denominations and names from the enumeration
                int[] rupeeValues = (int[])Enum.GetValues(typeof(Rupees));
                string[] rupeeNames = Enum.GetNames(typeof(Rupees));
        
                // Initialize a dictionary to store the count of each rupee type
                Dictionary<string, int> rupeeCount = new Dictionary<string, int>();
        
                // Initialize the dictionary with zero counts
                foreach (var name in rupeeNames)
                {
                    rupeeCount[name] = 0;
                }
        
                // Prompt the user for the total amount of rupees
                Console.WriteLine("How many Rupees, as an integer number, has Link been given?");
                int rupeeAmount;
                if (int.TryParse(Console.ReadLine(), out rupeeAmount))
                {
                    // Iterate through the rupee denominations
                    for (int i = 0; i < rupeeValues.Length; i++)
                    {
                        int value = rupeeValues[i];
                        string name = rupeeNames[i];
        
                        // Calculate the count of the current rupee type
                        rupeeCount[name] = rupeeAmount / value;
        
                        // Update the total amount
                        rupeeAmount %= value;
                    }
        
                    // Output the result
                    Console.WriteLine("Link has been given the following rupees:");
                    foreach (var kvp in rupeeCount)
                    {
                        Console.WriteLine($"{kvp.Value} {kvp.Key} rupees");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer number.");
                }
            }
        }
        
    

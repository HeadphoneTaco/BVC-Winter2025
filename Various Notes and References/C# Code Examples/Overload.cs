
#In this example, the Display method is overloaded three times:
#1.	Display() - No parameters.
#2.	Display(int number) - One integer parameter.
#3.	Display(int number, string text) - Two parameters: an integer and a string.
#The correct method is called based on the arguments passed when the method is invoked. This allows for more flexible and readable code.


class Example
{
    // Method with no parameters
    public void Display()
    {
        Console.WriteLine("Display with no parameters");
    }

    // Method with one integer parameter
    public void Display(int number)
    {
        Console.WriteLine("Display with one integer parameter: " + number);
    }

    // Method with two parameters: an integer and a string
    public void Display(int number, string text)
    {
        Console.WriteLine("Display with two parameters: " + number + ", " + text);
    }
}
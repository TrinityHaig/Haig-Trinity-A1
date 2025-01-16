using System;

public class Class1
{
	public Class1()
	{
        static void Main(string[] args)
		{
            Console.Writeline("Welcome! Todays menu item is [CAKE]. Would you like to try and make one?");
            string choice1 = Console.ReadLine();
            //end if they type no
            if (choice1 == "yes")
            {
                Console.WriteLine("Great! Pick from the following flavors!");
                Console.WriteLine("Strawberry Cake");
                Console.WriteLine("Cheesecake");
                Console.WriteLine("Ice cream cake");
            }

            else if (choice1 == "no")
            {
                Console.Writeline("Very well, have a nice day");
            }

            else
            {
                Console.WriteLine("I did not understand the prompt, please try again later");
            }
            
        }
	}
}

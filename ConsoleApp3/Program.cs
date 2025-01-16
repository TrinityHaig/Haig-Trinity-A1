namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //make the answers not be case sensitive (i think i need to use a bool parse which means id need to convert them to bools)

                Console.WriteLine("Welcome! Todays menu item is [CAKE]. Would you like to try and make one?\n\nYes\nNo");
                string choice1 = Console.ReadLine();
                //if the cake has any errors it will give you a fail screen at the end.
                bool doesCakeHaveMistakes = false;
                //end if they type no
                if (choice1 == "yes")
                {
                    Console.WriteLine("\nGreat! Pick from the following flavors!\n");
                    Console.WriteLine("Strawberry");
                    Console.WriteLine("Cheesecake");
                    Console.WriteLine("Ice cream\n");
                    string cakeFlavour = Console.ReadLine();
                    //strawberry cake path
                    if (cakeFlavour == "strawberry")
                    {
                        Console.WriteLine("\nYou have chosen");
                        Console.WriteLine(cakeFlavour);
                        Console.WriteLine("Which of the following ingredients is NOT needed for the recipe?\n");
                        //Design the cake in this scenario i dont have it planned out just yet
                    }
                    else if (cakeFlavour == "cheesecake")
                    {
                        Console.WriteLine("\nYou have chosen");
                        Console.WriteLine(cakeFlavour);
                        Console.WriteLine("Which of the following ingredients is NOT needed for the recipe?\n");
                    }

                    else if (cakeFlavour == "ice cream")
                    {
                        Console.WriteLine("\nYou have chosen");
                        Console.WriteLine(cakeFlavour);
                        Console.WriteLine("Which of the following ingredients is NOT needed for the recipe?\n");
                    }

                    else
                    {
                        //i really wish this didnt just instantly end it but thats the last priority currently
                       Console.WriteLine("I did not understand the prompt, please try again later");
                    }
                }

                else if (choice1 == "no")
                {
                    Console.WriteLine("Very well, have a nice day");
                }
                //If possible send back to start but ill try to mess with that later its not my main priority
                else
                {
                    Console.WriteLine("I did not understand the prompt, please try again later");
                }
            }
        }
    }
}

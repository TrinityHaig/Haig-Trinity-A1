﻿namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //incorrectIngredient is used multipletimes so its beind defined up here

                string incorrectIngredient;
                
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
                        Console.WriteLine($"\nYou have chosen {cakeFlavour}");
                        Console.WriteLine("Which of the following ingredients is NOT needed for the recipe?\n");
                        //Design the cake in this scenario i dont have it planned out just yet
                        Console.WriteLine("Egg\nFlour\nStrawberries\nSalt\n");
                        incorrectIngredient = Console.ReadLine();
                        //this is going to get really long oh my lordy
                        //after it checks for ingredient it should continue linearly
                        if (incorrectIngredient == "egg")
                        {
                            doesCakeHaveMistakes = true;
                        }
                        else if (incorrectIngredient == "flour")
                        {
                            doesCakeHaveMistakes = true;
                        }
                        else if (incorrectIngredient == "strawberry")
                        {
                            doesCakeHaveMistakes = true;
                        }
                        else if (incorrectIngredient == "salt")
                        {
                            doesCakeHaveMistakes = false;
                        }
                        else
                        {
                            Console.WriteLine("I did not understand the answer, this will cause issues with the cake");
                            doesCakeHaveMistakes = true;
                        }
                    }

                    //other flavours are slightly altered versions of the first one
                    //comment is here so i can easily see where the next flavour starts
                    else if (cakeFlavour == "cheesecake")
                    {
                        Console.WriteLine($"\nYou have chosen{cakeFlavour}");
                        Console.WriteLine("Which of the following ingredients is NOT needed for the recipe?\n");
                    }


                    //third flavour here
                    else if (cakeFlavour == "ice cream")
                    {
                        Console.WriteLine($"\nYou have chosen{cakeFlavour}");
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

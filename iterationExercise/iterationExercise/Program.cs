using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Create a one-dimensional Array of strings.
            // Ask the user to input some text.Create a loop that goes through each string 
            // in the Array, adding the user’s text to the string.
            // Then create a loop that prints off each string in the Array on a separate line.

            // rather than get input once and add the same thing to each string in the array
            // I am getting unique input for each element.

            string[] words = { "rain", "string", "hook", "cobweb", "railway", "rhythm", "crow", "slippery", "burly", "worm", "snails", "north", "knife", "observe", "bustling", "obscene", "mash", "rat", "absorb" };

            List<string> userWords = new List<string>(); // create a list to store user input for use later in task 6.

            Console.WriteLine("Input the first thing that comes to mind for each word.\nPress enter when ready.\n");
            Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                Console.Clear();
                Console.CursorTop = 10;
                Console.CursorLeft = 25;

                Console.Write(words[i] + " : ");
                string response = Console.ReadLine();   
                userWords.Add(response); // populate list for task 6. of the exercise
                words[i] = words[i] + " : " + response;
            }

            Console.Clear();
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.ReadLine();

            Console.Clear();


            // 2.Create an infinite loop.
            //
            // while (true) {}

            Console.WriteLine("2. Create an infinite loop.\n\t Not executing infinite loop, but it looks like this:");
            Console.WriteLine("while (true)\n{\n\t// Do something endlessly\n};");
            Console.ReadLine();
            Console.WriteLine("Or this:");
            Console.WriteLine("for (;;)\n{\n\t// Do something else endlessly\n};");
            Console.ReadLine();

            
            // 3.Fix the infinite loop so it will execute.
            //
            // Not understanding the exact point to this.
            // Doesn't the "unfixed" infinite loop "execute"... infinitely?
            // I came up with a way to escape the infinite loop. I'm guessing this is what
            // we are looking for here.

            Console.WriteLine("3. Fix the infinite loop so it will execute. \nNow we are actually going to execute...\nInfinite loop coming, use CAPS-LOCK to get out.");
            Console.ReadLine();

            while (true)
            {
                Console.Write("Oh Nooooooo! We're stuck here forever!        ");

                // I know there are better ways to do this, but this was the simplest way
                // I could come up with on my own without researching.
                if (Console.CapsLock == true) { break; }

            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nPhew, I thought we'd never get out! Remember to turn off CAPS-LOCK.\n");
            Console.ReadLine();

            Console.Clear();

            // Or perhaps waiting for a condition to be met with user input.

            for (string i = ""; i != "$";)
            {
                Console.WriteLine("Guess a Character: ");
                i = Console.ReadLine();
                if (i == "$")
                {
                    Console.WriteLine("Correct.");
                }
                else
                {
                    Console.WriteLine("Try Again.");
                }
            }

            Console.ReadLine();

            Console.Clear();


            // 4. Create a loop where the comparison used to determine whether to continue 
            // iterating the loop is a “<” operator.

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();



            // 5.Create a loop where the comparison used to determine whether to continue iterating 
            // loop is a “<=” operator.

            int j = 0;
            while (j <= 10)
            {
                Console.Write(j + " ");
                j++;
            }

            Console.ReadLine();
            Console.Clear();

            // 6. Create a List of strings where each item in the list is unique. 
            // Ask the user to select text to search for in the List. 
            // Create a loop that iterates through the list and then displays the index of the 
            // array that contains matching text on the screen.


            // List created from user input in task 1. Assuming they entered unique answers for each.


            Console.WriteLine("\nRecall a word you entered earlier: ");
            string recall = Console.ReadLine();
            bool wordFound = false;
            for (int i = 0; i < userWords.Count && !wordFound; i++) 
            {
                if (recall == userWords[i])
                {
                    Console.WriteLine("The index of your word \"" + recall + "\" is " + i + ".");
                    // 8.Add code to that above loop that stops it from executing once 
                    // a match has been found.

                    wordFound = true; // for loop condition checks for this to be false, true condition stops execution
                    // A break; would have worked.
                }

                // 7.Add code to that above loop that tells a user if they put in text that isn’t 
                // in the List.

                else if (i == (userWords.Count - 1) && !wordFound)
                {
                    Console.WriteLine("Did not find \"" + recall + "\" in the list.");
                }
            }
            Console.ReadLine();
            Console.Clear();



            // 9.Create a List of strings that has at least two identical strings in the List. 
            // Ask the user to select text to search for in the List.Create a loop that iterates
            // through the list and then displays the indices of the array that contain 
            // matching text on the screen.


            List<string> genres = new List<string> { "hiphop", "rhythm and blues", "jazz", "blues", "folk", "acoustic", "pop", "country", "electronic", "dance", "instrumental", "classical", "contemporary", "indie", "latin", "country", "reggae", "rap", "jazz", "metal", "rock and roll", "alternative", "rock", "punk", "ska", "klesmer", "flamenco", "salsa", "afro-cuban", "bluegrass", "gospel" };

            Console.Write("What type of music would you like to listen to? ");
            string userGenre = Console.ReadLine();

            int matches = 0; // keep track of # of matches so we can display the proper message.
            List<int> genreIndex = new List<int>();


            if (genres.Contains(userGenre))
            {
                for (int i = 0; i < genres.Count; i++)
                {

                    if (genres[i] == userGenre && matches == 0)
                    {
                        Console.WriteLine("You can listen to " + genres[i] + " on channel " + i + ".");
                        matches++;
                    }
                    else if (genres[i] == userGenre && matches >= 1)
                    {
                        Console.WriteLine("You can also listen on channel " + i + ".");
                    }
                }
            }

            // 10.Add code to that above loop that tells a user
            // if they put in text that isn’t in the List.

            else
            {
                Console.WriteLine("Sorry, we don't have any " + userGenre + ".");
            }

            Console.ReadLine();


            // 11.Create a List of strings that has at least two identical strings in the List. 
            // Create a foreach loop that evaluates each item in the list, 
            // and displays a message showing the string and whether or not 
            // it has already appeared in the list

            List<string> europeanCities = new List<string>
                { "Berlin", "Istanbul", "Prague", "London", "Barcelona", "Paris", "Madrid",
                "Budapest", "London", "Frankfurt", "Milan", "Rome", "Florence",
                "Geneva", "Zurich", "Athens", "Oslo", "Istanbul", "Copenhagen", "Helsinki",
                "Warsaw", "Amsterdam", "Brussels", "Lisbon", "Lyon", "Manchester",
                "Dublin", "Sofia", "Moscow", "Barcelona", "Vienna", "Santerini", "Seville",
                "Porto", "Catalonia", "Hamburg", "Florence", "Munich", "Belfast", "Istanbul", "Edinburgh" };

            int citiesIndex = 0; // keep track of iterations of foreach loop. I think it would make more sense to just use a for loop.
            foreach (string city in europeanCities)
            {
                Console.WriteLine(citiesIndex + ". " + city);
                
                bool appeared = false;
                for (int i = 0; i <= citiesIndex; i++) // compare city to each previous item
                {
                   
                    if (!appeared && i == citiesIndex) // If it hasn't appeared yet AND we are at the end of the loop...
                    {
                        Console.WriteLine("\t" + city + " has only appeared once so far.");
                    }
                    else if (city == europeanCities[i] && i < citiesIndex) // if it matches and were not at the end of the loop, it has previously appeared, print a message with index
                    {
                        Console.WriteLine("\t" + city + " has already appeared in the list at index " + i + ".");
                        appeared = true; // flag for opening if statement to check for previous appearances.
                    }
                }
                citiesIndex++;
                Console.Write(Environment.NewLine);
            }
            Console.ReadLine();










        }
    }
}

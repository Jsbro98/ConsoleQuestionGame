using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp
{
    public class Color
    {
        public string Name {get; set;}
        public int Count = 0;
        public string Feeling {get; set;}
        public string Represents {get; set;}
        public bool FavoriteColor {get; set;}

        public Color(string name, string feeling, string represents, bool favoriteColor)
        {
            Name = name;
            Feeling = feeling;
            Represents = represents;
            FavoriteColor = favoriteColor;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            Color red = new Color("Red", "Anger", "Power", true);
            Color blue = new Color("Blue", "Sad", "Calm", false);
            Color yellow = new Color("Yellow", "Happiness", "Future", false);

            Color[] colorArray = { red, blue, yellow };

            Console.WriteLine("Hello! I am going to guess your color");
            Console.WriteLine();
            Console.WriteLine("Please pick a color.");

            string colorChoice;
            string feelingChoice;
            string representsChoice;
            char favoriteColorChoice;

            void WriteQuestionAndCheckResponse(string propertyName)
            {
                PropertyInfo? propInfo = typeof(Color).GetProperty(propertyName);
                object? propValueRed = null;
                object? propValueBlue = null;
                object? propValueYellow = null;


                if (propInfo is not null)
                {
                    propValueRed = propInfo.GetValue(red);
                    propValueBlue = propInfo.GetValue(blue);
                    propValueYellow = propInfo.GetValue(yellow);
                }

                // Continue here -------------------------------------------------------------------------------------

                if (propValueRed is not null)

                while(true)
            {
                foreach (Color color in colorArray)
                {
                    Console.Write( + " ");
                }

                Console.WriteLine();

                colorChoice = Console.ReadLine()!;

                if ( !String.IsNullOrEmpty(colorChoice) )
                {
                    colorChoice = colorChoice.ToLower();
                    colorChoice = Char.ToUpper(colorChoice[0]) + colorChoice.Substring(1);
                    
                    if (colorChoice != red.Name && colorChoice != blue.Name && colorChoice != yellow.Name)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please choose a valid color.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please choose a color.");
                }
            }

            }

            while(true)
            {
                foreach (Color color in colorArray)
                {
                    Console.Write(color.Name + " ");
                }

                Console.WriteLine();

                colorChoice = Console.ReadLine()!;

                if ( !String.IsNullOrEmpty(colorChoice) )
                {
                    colorChoice = colorChoice.ToLower();
                    colorChoice = Char.ToUpper(colorChoice[0]) + colorChoice.Substring(1);
                    
                    if (colorChoice != red.Name && colorChoice != blue.Name && colorChoice != yellow.Name)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please choose a valid color.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please choose a color.");
                }
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("What feeling does the color have? Please choose from the choices below");

                foreach (Color color in colorArray)
                {
                    Console.Write(color.Feeling + " ");
                }

                Console.WriteLine();

                feelingChoice = Console.ReadLine()!;

                if ( !String.IsNullOrEmpty(feelingChoice) )
                {
                    feelingChoice = feelingChoice.ToLower();
                    feelingChoice = Char.ToUpper(feelingChoice[0]) + feelingChoice.Substring(1);

                    if (feelingChoice != red.Feeling && feelingChoice != blue.Feeling && feelingChoice != yellow.Feeling)
                    {
                        Console.WriteLine("Please choose a feeling from the options listed.");
                        feelingChoice = "";
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a feeling.");
                }
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("What does the color represent? Please choose from the choices below");

                foreach (Color color in colorArray)
                {
                    Console.Write(color.Represents + " ");
                }

                Console.WriteLine();

                representsChoice = Console.ReadLine()!;

                if ( !String.IsNullOrEmpty(representsChoice) )
                {
                    representsChoice = representsChoice.ToLower();
                    representsChoice = Char.ToUpper(representsChoice[0]) + representsChoice.Substring(1);

                    if (representsChoice != red.Represents && representsChoice != blue.Represents && representsChoice != yellow.Represents)
                    {
                        Console.WriteLine("Please choose a representation from the options listed.");
                        representsChoice = "";
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a representation.");
                }
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("is this color your favorite color? (Y/N)");

                try
                {
                    favoriteColorChoice = Convert.ToChar( Console.ReadLine()! );

                    if ( Char.IsLetter(favoriteColorChoice) )
                    {
                        break;
                    }
                }
                catch (FormatException error)
                {
                    Console.WriteLine(error);
                    Console.WriteLine();
                    Console.WriteLine("Please enter (Y/N)");
                }
            }
        }
    }
}
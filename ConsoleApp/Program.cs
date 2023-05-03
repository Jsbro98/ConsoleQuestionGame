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

            while(true)
            {
                foreach (Color color in colorArray)
                {
                    Console.Write(color.Name + " ");
                }

                string? colorChoice = Console.ReadLine();

                if (colorChoice is not null)
                {
                    colorChoice = colorChoice.ToLower();
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose a color.");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.run();
        }
    }
    class Tester
    {
        public void run()
        // Again, capitalise method names.
        {
            Dog dog = new Dog(0,"brown");
            string color = dog.Color;
            Console.WriteLine("The color of the dog is: {0}",color);
            Console.WriteLine("What is the weight?");
            int w = Convert.ToInt32(Console.ReadLine());
            // Again, full names for variables.
            dog.Weight = w;
            Console.WriteLine("The weight of the dog is now: " + dog.Weight);
        }
    }
    class Dog
    {
        private int weight;
        private string color;
        public int Weight { get; set; }
        public string Color
        // Although the book does explicitly tell you to create the private variable, you can actually use 
        // an auto-property as you did with Weight - just
        // public string Color {get; set;}
        // will set up a private variable and do all the getters and setters below for you.
        {
            get 
            { 
                return color;
            }
            set
            {
                color = value;
            }
        }
        public Dog(int w, string c)
        // Again, use this.weight = weight etc
        {
            weight = w;
            color = c;
        }
    }
}

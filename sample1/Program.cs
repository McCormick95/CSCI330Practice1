using System;
using System.Collections.Generic;

namespace Tv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Show one = new Show() {
                Name= "Parks and Recreation",
                NumEpisodes= 125,
                Year=2009,
                Actors= new List<string> {
                    "Amy Poehler","Aziz Ansari","Nick Offerman"
                }
            };

            Console.WriteLine(one);
        }
    }
}

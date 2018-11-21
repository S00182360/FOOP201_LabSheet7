using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOP201_LabSheet7
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g1 = new Game("Monopoly", 19.99m, new DateTime(1970, 01, 31));

            Game g2 = new Game() { Price = 10.99m, ReleaseDate = new DateTime(2000, 6, 15) };

            Console.WriteLine(g1);
            Console.WriteLine(g2);

            Console.ReadKey();

        }
    }

    class Game
    {
        public Game(string name, decimal price, DateTime releaseDate)
        {
            this.name = name;
            Price = price;
            ReleaseDate = releaseDate;
        }

        public Game(string name, decimal price) : this(name, price, DateTime.Now)
        {
            this.name = name;
            Price = price;
        }

        public Game() : this("DEFAULT NAME", 0)
        {

        }

        readonly string name;
        public string Name { get { return name; } }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }


        public override string ToString()
        {
            return String.Format("Name: {0}\nPrice: {1}EUR\nRelease Date: {2}\n\n", Name, Price, ReleaseDate);
        }
    }
}

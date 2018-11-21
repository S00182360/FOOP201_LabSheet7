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

            //Game g2 = new Game() { Price = 10.99m, ReleaseDate = new DateTime(2000, 6, 15) };

            ComputerGame cg1 = new ComputerGame("Tomb Raider", 49.99m, new DateTime(1996, 10, 25), "15+");
            ComputerGame cg2 = new ComputerGame("Legend of Zelda", 5.99m, new DateTime(1986, 02, 21), "3+");

            DisplayGame(g1);
            Console.WriteLine("");
            //Console.WriteLine(g2);
            DisplayGame(cg1);
            Console.WriteLine("");
            DisplayGame(cg2);

            Console.ReadKey();

        }

        static void DisplayGame(Game g)
        {
            Console.WriteLine(g);
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
        protected decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }


        public override string ToString()
        {
            return String.Format("Name: {0}\nPrice: {1}EUR\nRelease Date: {2}\n", Name, Price, ReleaseDate);
        }
    }

    class ComputerGame : Game
    {
        public ComputerGame(string name, decimal price, DateTime releaseDate, string pEGIRating) : base(name, price, releaseDate)
        {
            PEGIRating = pEGIRating;
        }
        public ComputerGame()
        {

        }

        public string PEGIRating { get; set; }

        public override string ToString()
        {
            return base.ToString() + String.Format("PEGI: {0}\n", PEGIRating);
        }

        public decimal GetDiscountPrice()
        {
            return Price * 0.9m;
        }
    }
}

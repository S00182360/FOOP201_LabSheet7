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

        }

        public Game() : this("", 0)
        {

        }


        readonly string name;
        public string Name { get { return name; } }
        public decimal Price { get; }
        public DateTime ReleaseDate { get; }


        public override string ToString()
        {
            return String.Format("Name: {0}/nPrice: {1}EUR/nRelease Date: {2}/n/n", Name, Price, ReleaseDate);
        }
    }
}

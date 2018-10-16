using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MilkFarm : AnimalFarm
    {
        public string City { get; set; }
        public int Square { get; set; }

        public MilkFarm(string name, int animalcount, int balance, string city, int square, int reserve) : base(name, animalcount, balance, reserve)
        {
            this.City = city;
            this.Square = square;
        }

        public void SellAll()//продать все запасы
        {
            Balance += Reserve * 50;
        }

        public void Milk()//подоить корову
        {
            Reserve += 20;
        }
    }
}

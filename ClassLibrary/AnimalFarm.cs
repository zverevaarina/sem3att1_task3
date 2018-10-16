using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class AnimalFarm : IFarm
    {
        public string Name { get; set; }
        public int AnimalCount { get; set; }
        public double Balance { get; set; }
        public int Reserve { get; set; }

        protected AnimalFarm(string name, int animalcount, int balance, int reserve)
        {
            this.Name = name;
            this.AnimalCount = animalcount;
            this.Balance = balance;
            this.Reserve = reserve;
        }

        public double PayTax()//заплатитть налог
        {
            return Balance -= Balance * 0.06;
        }

        public double Sell()//продать товар
        {
            return Balance += 100;
            //Reserve -= 30;
        }

        public void BuyAnimal()//купить животное
        {
            Balance -= 100;
            AnimalCount++;
        }
    }
}

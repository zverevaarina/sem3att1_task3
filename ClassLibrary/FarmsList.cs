using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FarmsList
    {
        List<IFarm> fList { get; set; }

        public FarmsList(string name, int animalcount, int balance, string city, int square, int reserve, int k)
        {
            for (int i = 0; i < k; i++)
                fList.Add(new MilkFarm(name, animalcount, balance, city, square, reserve));
        }
    }
}

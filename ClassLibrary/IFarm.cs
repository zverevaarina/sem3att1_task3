using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IFarm
    {
        string Name { get; set; }

        double PayTax();//заплатить налог

        double Sell();//продать товар
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_1262774
{
    interface IStrategySort<T>
    where T : IComparable, new() // T should implement IComparable and
    { // T should provide a constructor
        void DoSort(List<T> TList);
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_1262774
{
    class SortContext // abstraction for Strategy or Algorithm classes
    {
        IStrategySort<Student> istrat = null;

        public SortContext(IStrategySort<Student> ist)
        {
            istrat = ist;
        }
        // algorithm interface
        public void DoSort(List<Student> TList)
        {
            istrat.DoSort(TList);
        }
    }
}

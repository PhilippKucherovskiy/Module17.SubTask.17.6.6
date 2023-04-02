using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.SubTask._17._6._6.AccountTypes
{
    // Класс, представляющий обычный тип учетной записи
    public class RegularAccount : Account
    {
        public override void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }
}

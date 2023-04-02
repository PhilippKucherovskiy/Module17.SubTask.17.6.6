using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.SubTask._17._6._6.AccountTypes
{
      // Класс, представляющий зарплатный тип учетной записи
    public class SalaryAccount : Account
    {
        public override void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}

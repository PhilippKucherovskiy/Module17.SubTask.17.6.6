using Module17.SubTask._17._6._6.AccountTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.SubTask._17._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Account regularAccount = new RegularAccount
            {
                Type = "Обычный",
                Balance = 5000
            };

            //Расчет процентной ставки
            regularAccount.CalculateInterest();

            // Выводим результаты
            Console.WriteLine($"Тип учетной записи: {regularAccount.Type}");
            Console.WriteLine($"Баланс учетной записи: {regularAccount.Balance}");
            Console.WriteLine($"Процентная ставка: {regularAccount.Interest}");

            
            Account salaryAccount = new SalaryAccount
            {
                Type = "Зарплатный",
                Balance = 10000
            };

           
            salaryAccount.CalculateInterest();

            // Выводим результаты
            Console.WriteLine($"Тип учетной записи: {salaryAccount.Type}");
            Console.WriteLine($"Баланс учетной записи: {salaryAccount.Balance}");
            Console.WriteLine($"Процентная ставка: {salaryAccount.Interest}");

            Console.ReadLine();
        }
    }

}

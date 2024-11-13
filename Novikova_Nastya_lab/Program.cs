using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{

    internal class Program
    {
        /// <summary>
        /// Перечисление типов банковского счета
        /// </summary>
        enum AccountType
        {
            Текущий,
            Сберегательный
        }
        /// <summary>
        /// Структура для хранения информации о банковском счете
        /// </summary>
        struct BankAccount
        {
            /// <summary>
            /// Номер счета
            /// </summary>
            public int AccountNumber;
            /// <summary>
            /// Тип счета
            /// </summary>
            public AccountType BankType;
            /// <summary>
            /// Баланс
            /// </summary>
            public int Balance;
        }
        /// <summary>
        /// Перечисление для представления названий университетов
        /// </summary>
        enum UniversityName
        { 
            КГУ,
            КАИ,
            КХТИ
        }
        /// <summary>
        /// Структура для хранения информации о работнике
        /// Содержит в себе имя работника и название университета
        /// </summary>
        /// <param name="args"></param>
        struct UniWorker
        {
            /// <summary>
            /// Имя работника
            /// </summary>
            /// <param name="args"></param>
            public string name;
            /// <summary>
            /// Название университета
            /// </summary>
            /// <param name="args"></param>
            public UniversityName university;
        }   
           
        static void Main(string[] args)
        {
        Console.WriteLine("\nУпражнение 3.1\n");
        //Создаю перечислимый тип данных отображающий виды банковского счета
        AccountType myAccountType = AccountType.Текущий;
        Console.WriteLine($"Тип банковского счета: {myAccountType}");
        Console.ReadLine();
        
        Console.WriteLine("\nУпражнение 3.2\n");
        //Создать структуру ,которая хранит информацию банковского счета (номер ,тип ,баланс)

        BankAccount myAccount = new BankAccount();
        myAccount.AccountNumber = 555555;
        myAccount.Balance = 68753447;
        myAccount.BankType = AccountType.Сберегательный; 
        Console.WriteLine("Баланс счета равен: {0}\nНомер счета: {1}\nТип счета в банке: {2}",myAccount.Balance,myAccount.AccountNumber,myAccount.BankType);
        Console.ReadLine();
        
        Console.WriteLine("\nДомашнее задание 3.1\n");
        //Создать перечислимый тип ВУЗ{КГУ,КАИ,КХТИ}Создать структуру
        
        UniWorker user = new UniWorker();
        user.name = "Макар Игнатов";
        user.university = UniversityName.КАИ; 
        Console.WriteLine("Имя работника:{0}\nНазвание университета:{1}",user.name,user.university);
        Console.ReadLine();
        }
    }
}




        



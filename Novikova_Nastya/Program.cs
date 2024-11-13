using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novikova_Nastya
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("\nЗадача 1\n");
        //Выведите на экран информацию о каждом типе данных в виде:Тип данных-максимальное значение-минимальное значение
        
        Console.WriteLine("Тип данных - Максимальное значение - Минимальное значение");
        Console.WriteLine("--------------------------------------------------------");

        // Целочисленные типы данных
        Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
        Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
        Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
        Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
        Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
        Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
        Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
        Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");

        // Вещественные типы данных
        Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
        Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
        Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");

        // Символьный тип данных
        Console.WriteLine($"char - {(char)char.MaxValue} - {(char)char.MinValue}");

        // Логический тип данных
        Console.WriteLine($"bool - true/false - false/true");
        Console.ReadLine();
        
        Console.WriteLine("\nЗадание 2\n");
        //Напишите программу, в которой принимаются данные пользователя в виде имени, города, возраста и PIN-кода
        //Сохраните все значения соответствующей переменной ,а затем выведите
        
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите ваш город: ");
        string city = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.Write("Пожалуйста, введите корректный возраст: ");
        }

        Console.Write("Введите ваш PIN-код: ");
        string pinCode = Console.ReadLine();

            
        Console.WriteLine("Ваша информация:");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Город: {city}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"PIN-код: {pinCode}");

        Console.ReadLine();

        Console.WriteLine("\nЗадание 3\n");
        //Преобразуйте входную строку:строчные буквы замените на заглавные,заглавные - на строчные
        
        string a;
        Console.WriteLine("Введите строку: ");
        a = Console.ReadLine();
        a = a.ToUpper();
        Console.WriteLine("Полученная строка: " + a);
        Console.ReadKey();
        
        Console.WriteLine("\nЗадание 4\n");
        //Введите строку, введите подстроку.Необходимо найти количество вхождений и вывести на экран

        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

           
        Console.WriteLine("Введите подстроку для поиска:");
        string substring = Console.ReadLine();
        if (substring == "")
        {
            Console.WriteLine("Подстрока не должна быть пустой.");
            return;
        }
        int count = 0;
        int stringLength = inputString.Length;
        int substringLength = substring.Length;

        for (int i = 0; i <= stringLength - substringLength; i++)
        {    
            bool match = true;
            for (int j = 0; j < substringLength; j++)
            {
                if (inputString[i + j] != substring[j])
                {
                    match = false;
                    break;
                }
            }

        if (match)
            {
                count++;
            }
        }

            
        Console.WriteLine($"Количество вхождений подстроки {substring} в строке: {count}");
        Console.ReadLine();  
            

        Console.WriteLine("\nЗадача 5\n");
        //Определить, сколько бутылок виски беспошлиной торговли вам нужно будет купить ,чтобы экономия по сравнению с 
        //обычной средней ценой фактически покрыла расходы на ваш отпуск

        Console.Write("Введите стандартную цену бутылки: ");
        int normPrice = int.Parse(Console.ReadLine());

        Console.Write("Введите скидку в дьюти фри: ");
        int dutyfreePrice = int.Parse(Console.ReadLine());

        Console.Write("Введите стоимость отпуска: ");
        int holidayPrice = int.Parse(Console.ReadLine());

        int savingsPerBottle = normPrice * dutyfreePrice / 100;

        if (savingsPerBottle <= 0)
            {
                Console.WriteLine("Скидка должна быть положительной.");
                return;
            }

        int bottlesNeeded = holidayPrice / savingsPerBottle;

        Console.WriteLine($"Количество бутылок, необходимых для покрытия расходов на отпуск: {bottlesNeeded}");
        Console.ReadLine();


        }
    }
}

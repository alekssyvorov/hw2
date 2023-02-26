using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Змінюю налаштування локалі для вводу/виводу укр мовою
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // 1 Вік людини
            Console.WriteLine("Введіть ваш вік");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ваш вік " + age + " років");

            // 2 Банківський рахунок з лімітом від -1 000 000 000 000 до 1 000 000 000 000 грн
            //Задане число влізе і в long, але мова йде про гроші, тому decima, так як в нього більша точність
            Console.WriteLine("Введіть суму");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Баланс {money:C}");

            //3 Літера
            Console.WriteLine("Яка літера? Вводимо анг мовою!");
            char sumbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Ви ввели літеру {sumbol}, в таблиці ASCII має номер {(byte)sumbol}");

            // 4 SMS повідомлення: `Hello World`
            Console.WriteLine("Hello World");
            string hw = "Hello World";
            Console.WriteLine("Вам повідомлення: " + hw);

            //5 Дати оцінку твердженню: "Сусід сказав, що людина може жити 1000 років". (Правда\Брехня, вмістити в 1 байт)
            //Я так и не понял что надо сделать, потому прицепился к самой цифре, которую назвал сосед
            //В методе ее вытягиваю ее с предложения и сравниваю с условным возрастом 140 лет
            string sentence = "Сусід сказав, що людина може жити 1000 років";
            bool result = GetAge(sentence) >= 140 ? false : true;
            Console.WriteLine("Сусід - " + result);


            //6 Температуру людини
            Console.WriteLine("Введіть температуру");
            float temperature = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(string.Format("Ваша температура {0}", temperature));

            // 7 Кількість населення планети
            ulong countPeople = 8000000000;
            Console.WriteLine($"Людей на планеті проживає приблизно {countPeople}");

            // 8 Температуру навколишньго середовища в Укриїні
            Console.WriteLine("Введіть значення температури: ");
            float outsideTemperature = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Середня температура на вулиці " + outsideTemperature + " C");


            Console.ReadLine();
        }
        static ushort GetAge(string sentenc)
        {
            ushort temp = 0;
            string[] word = sentenc.Split(' ');
            foreach (string elem in word)
            {
                ushort.TryParse(elem, out temp);
                if (temp > 0)
                    break;
            }
            return temp;
        }
    }
}

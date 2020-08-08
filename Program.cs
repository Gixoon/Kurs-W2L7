using System;
using System.Security.Cryptography.X509Certificates;

namespace Week2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            exe1();
            exe2();
            exe3();
            exe4();
            exe5();
            exe6();
            exe7();
            exe8();
            exe9();
            exe10();
            exe11();
            exe12();
            exe13();
        }

        public static void exe1()
        {
            int a = 5; int b = 5;
            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"{a} i {b} nie są równe");
            }
            Console.WriteLine();
        }

        public static void exe2() 
        {
            Console.Write("Enter the number (between 1-100): ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number");
            }
            Console.WriteLine();
        }
        public static void exe3()
        {
            Console.Write("Enter the number (between 1-100): ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"{number} is positive number");
            }
            else
            {
                Console.WriteLine($"{number} is negative number");
            }
            Console.WriteLine();
        }
        public static void exe4()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} it's not a leap year");
            }
            Console.WriteLine();
        }
        public static void exe5()
        {
            Console.Write("Podaj swój wiek: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Posiadasz bierne prawo wyborcze do zostania: ");

            if (age >= 21 && age < 30)
            {
                Console.Write("posłem");
            }
            else if (age >= 30 && age < 35)
            {
                Console.WriteLine("posłem oraz senatorem");
            }
            else if (age >= 35)
            {
                Console.WriteLine("posłem, senatorem, prezydentem");
            }
            else
            {
                Console.WriteLine("Dorośnij!");
            }
            Console.WriteLine();

        }
        public static void exe6()
        {
            Console.Write("Enter your height in cm: ");
            int height = int.Parse(Console.ReadLine());

            if (height >= 220)
                Console.WriteLine("Giant!");
            else if (height >= 180)
                Console.WriteLine("You're tall.");
            else if (height >= 160)
                Console.WriteLine("You're average");
            else
                Console.WriteLine("Dwarf");
            Console.WriteLine();
        }
        public static void exe7()
        {
            Console.WriteLine("Which number is the biggest? Enter 3 numbers:");

            Console.Write("First number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine($"{num1} is the biggest number");

            else if (num2 > num1 && num2 > num3)
                Console.WriteLine($"{num2} is the biggest number");

            else
                Console.WriteLine($"{num3} is the biggest number");
            Console.WriteLine();
        }
        public static void exe8()
        {
            Console.WriteLine("Podaj wyniki z matury");
            Console.Write("Chemia: ");
            int chem = int.Parse(Console.ReadLine());

            Console.Write("Fizyka: ");
            int fiz = int.Parse(Console.ReadLine());

            Console.Write("Matematyka: ");
            int mat = int.Parse(Console.ReadLine());

            int sum = mat + fiz + chem;
            bool crit = (mat > 70 && fiz > 55) && chem > 45;

            if (crit == true && sum > 180)
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            else if ((mat + fiz) > 150 || (mat + chem) > 150)
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            else
                Console.WriteLine("Kandydat niedopusczony do rekrutacji");
            Console.WriteLine();
        }
        public static void exe9()
        {
            Console.WriteLine("Podaj temperature (w stopniach celsjusza): ");
            int temp = int.Parse(Console.ReadLine());
            if (temp < 0)
                Console.WriteLine("Pizga jak w Kieleckiem");
            else if (temp >= 0 && temp < 11)
                Console.WriteLine("Zimno");
            else if (temp > 10 && temp < 21)
                Console.WriteLine("Chłodno");
            else if (temp > 20 && temp < 31)
                Console.WriteLine("W sam raz");
            else if (temp > 30 && temp < 41)
                Console.WriteLine("Zaczyna byc słabo, bo gorąco");
            else if (temp > 40)
                Console.WriteLine("A weź wyprowadzam się na Alaskę");
            else
                Console.WriteLine("Coś jest nie tak");
            Console.WriteLine();
        }
        public static void exe10()
        {
            Console.WriteLine("Podaj długości boków trójkąta: ");

            Console.Write("Bok a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Bok b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Bok c: ");
            int c = int.Parse(Console.ReadLine());

            if ((a + b > c && a + c > b) && b + c > a)
                Console.WriteLine("Można zbudować trójkąt");
            else
                Console.WriteLine("Nie można zbudować trójkąta");
            Console.WriteLine();
        }
        public static void exe11()
        {
            Console.WriteLine("Podaj ocenę(1-6): ");
            string ocena = Console.ReadLine();

            string opis = ocena switch
            {
                "1" => "niedostateczny",
                "2" => "dopuszczjący",
                "3" => "dostateczny",
                "4" => "dobry",
                "5" => "bardzo dobry",
                "6" => "celujący",
                _ => "podano złą wartość"
            };

            Console.WriteLine(opis);
            Console.WriteLine();
        }
        public static void exe12()
        {
            Console.WriteLine("Podaj numer dnia tygodnia(1-7): ");
            string day = Console.ReadLine();

            string opis = day switch
            {
                "1" => "poniedziałek",
                "2" => "wtorek",
                "3" => "środa",
                "4" => "czwartek",
                "5" => "piątek",
                "6" => "sobota",
                "7" => "niedziela",
                _ => "podano złą wartość"
            };

            Console.WriteLine(opis);
            Console.WriteLine();
        }
        public static void exe13()
        {
            Console.WriteLine("Prosty kalkulator \r\nPodaj liczby:");

            Console.Write("Pierwsza: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Druga: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz działanie do wykonania (1-4): ");
            Console.WriteLine("1.Dodawanie, \r\n 2.Odejmowanie \r\n 3.Mnożenie \r\n 4.Dzielenie");
            string działanie = (Console.ReadLine());

            double result = działanie switch
            {
                "1" => x + y,
                "2" => x - y,
                "3" => x * y,
                "4" => x / y,
                _ => 0,
            };
            Console.WriteLine("Twój wynik to: " + result);
        }
    }
}
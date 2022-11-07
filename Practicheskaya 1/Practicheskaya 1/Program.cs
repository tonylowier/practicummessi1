namespace Messi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действие, которое вы хотите сделать (1-9): ");
            Console.WriteLine("1. Сложить два числа ");
            Console.WriteLine("2. Вычесть первое из второго ");
            Console.WriteLine("3. Перемножить два числа ");
            Console.WriteLine("4. Разделить первое на второе ");
            Console.WriteLine("5. Возвести в степень N первое число ");
            Console.WriteLine("6. Найти квадратный корень из числа ");
            Console.WriteLine("7. Найти 1 процент от числа ");
            Console.WriteLine("8. Найти факториал из числа ");
            Console.WriteLine("9. Выйти из программы ");
            string a;
            int a1;
            do
            {

                a = Console.ReadLine();
                a1 = Convert.ToInt32(a);


                if (a1 == 1)
                {




                    Console.WriteLine("Введите первое число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    Console.WriteLine("Введите второе число: ");
                    b = Console.ReadLine();
                    int b2 = Convert.ToInt32(b);
                    Console.WriteLine("Результат сложения равен = " + (b1 + b2));

                    Console.WriteLine("Введите действие, которое вы хотите сделать (1-9): ");

                }

                else if (a1 == 2)
                {


                    Console.WriteLine("Введите первое число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    Console.WriteLine("Введите второе число: ");
                    b = Console.ReadLine();
                    int b2 = Convert.ToInt32(b);
                    Console.WriteLine("Результат вычитания равен = " + (b1 - b2));
                    Console.WriteLine("Введите действие, которое вы хотите сделать (1-9): ");
                }



                else if (a1 == 3)
                {
                    Console.WriteLine("Введите первое число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    Console.WriteLine("Введите второе число: ");
                    b = Console.ReadLine();
                    int b2 = Convert.ToInt32(b);
                    Console.WriteLine("Результат умножения равен = " + (b1 * b2));
                    Console.WriteLine("Введите действие, которое вы хотите сделать (1-9): ");
                }


                else if (a1 == 4)
                {

                    Console.WriteLine("Введите первое число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    Console.WriteLine("Введите второе число: ");
                    b = Console.ReadLine();
                    int b2 = Convert.ToInt32(b);
                    Console.WriteLine("Результат деления равен = " + (b1 / b2));
                    Console.WriteLine("Введите действие, которое вы хотите сделать (1-9): ");
                }


                else if (a1 == 5)

                {
                    Console.WriteLine("Введите число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    Console.WriteLine("Введите степень N : ");
                    b = Console.ReadLine();
                    int N = Convert.ToInt32(b);
                    int b2 = 1;
                    for (int i = 0; i < N; i++)
                    {
                        b2 = b1 * b2;
                    }
                    Console.WriteLine("Результат возведения в степень N равен = " + (b2));
                    Console.WriteLine("Введите действие, которое вы хотите сделать (1-9): ");


                }
                else if (a1 == 6)
                {
                    Console.WriteLine("Введите число: ");
                    string b = Console.ReadLine();
                    double b1 = Convert.ToInt32(b);
                    b1 = Math.Sqrt(b1);
                    Console.WriteLine("Квадратный корень равен: " + b1);
                    Console.WriteLine("Введите действие, которое вы хотите сделать (1-9): ");

                }
                else if (a1 == 7)
                {
                    Console.WriteLine("Введите число: ");
                    string b = Console.ReadLine();
                    float b1 = Convert.ToInt32(b);
                    b1 = (b1 / 100) * 1;
                    Console.WriteLine("Один процент от числа равен: " + b1);
                    Console.WriteLine("Введите действие, которое вы хотите сделать (1-9): ");
                }
                else if (a1 == 8)
                {
                    Console.WriteLine("Введите число: ");
                    string b = Console.ReadLine();
                    int b1 = Convert.ToInt32(b);
                    int factorial = 1;
                    for (int i = 2; i <= b1; i++)
                    {
                        factorial = factorial * i;

                    }
                    Console.WriteLine("Факториал числа равен: " + factorial);
                    Console.WriteLine("Введите действие, которое вы хотите сделать (1-9): ");


                }
            }
            while (a1 != 9);
            Console.WriteLine("Конец программы");
        }
    }
}
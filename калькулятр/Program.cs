double chisl1, chisl2, rez;
int stepen;
string vibor;
do
{
    Console.WriteLine("Выберите операцию:\r\n1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы");
    vibor = Console.ReadLine();
    switch (vibor) {
        case "1":
            Console.WriteLine("Введите первое число: ");
            chisl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            chisl2 = Convert.ToDouble(Console.ReadLine());
            rez = chisl1 + chisl2;
            Console.WriteLine("Результат: " + rez);
            break;
            case "2":
            Console.WriteLine("Введите первое число: ");
            chisl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            chisl2 = Convert.ToDouble(Console.ReadLine());
            rez = chisl2 - chisl1;
            Console.WriteLine("Результат: " + rez);
            break;
            case "3":
            Console.WriteLine("Введите первое число: ");
            chisl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            chisl2 = Convert.ToDouble(Console.ReadLine());
            rez = chisl1 * chisl2;
            Console.WriteLine("Результат: " + rez);
            break;
            case "4":
            Console.WriteLine("Введите первое число: ");
            chisl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            chisl2 = Convert.ToDouble(Console.ReadLine());
            if(chisl2 == 0)
                    {
                Console.WriteLine("Ошибка: деление на ноль");
            }
                    else
            {
                rez = chisl1 / chisl2;
                Console.WriteLine("Результат: " + rez);
            }
            break;
            case "5":
            Console.WriteLine("Введите первое число: ");
            chisl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень в которую возвести число: ");
            stepen = Convert.ToInt32(Console.ReadLine());
            rez = Math.Pow(chisl1, stepen);
            Console.WriteLine("Результат: " + rez);
            break;
            case "6":
            Console.WriteLine("Введите число: ");
            chisl1 = Convert.ToDouble(Console.ReadLine());
            if (chisl1 < 0)
            {
                Console.WriteLine("Ошибка. не разрешаю извлекать кв. корень из отрицательного числа");
            }
            else
            {
                rez = Math.Sqrt(chisl1);
                Console.WriteLine("Результат: " + rez);
            }
            break;
        case "7":
            Console.WriteLine("Введите число: ");
            chisl1 = Convert.ToDouble(Console.ReadLine());
            rez = chisl1 / 100;
            Console.WriteLine("Результат: " + rez);
            break;
        case "8":
            Console.WriteLine("Введите число: ");
            chisl1 = Convert.ToDouble(Console.ReadLine());
            rez = 1;
            for (int i = 1; i <= chisl1; i++)
            {
                rez *= i;
            }
            Console.WriteLine("Результат: " + rez);
            break;
        case "9":
            Console.WriteLine("Программа завершена.");
            break;
        default:
            Console.WriteLine("Ошибка: Неправильный выбор операции.");
            break;
    } 
} while (vibor != "9");


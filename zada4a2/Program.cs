﻿ Console.Write("Введите любое число: ");
            int enterNumber = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            while (enterNumber != 0)
            {
                result += enterNumber % 10;
                enterNumber /= 10;
            }

            Console.WriteLine($"Сумма цифр в числе = {result}");

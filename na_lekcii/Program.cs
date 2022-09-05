// // Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// // Например:
// // 4 -> 16 
// // -3 -> 9 
// // -7 -> 49


// Console.WriteLine ("Напишите число и я его возведу в квадрат: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(number * number);


// // // 5. Напишите программу, которая на вход 
// // // принимает одно число (N), а на выходе показывает все 
// // // целые числа в промежутке от -N до N.
// // // 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// // // 2 -> " -2, -1, 0, 1, 2"

// // Console.WriteLine("Введите число: ");
// // int number = Convert.ToInt32(Console.ReadLine());

// // int count = -number;
// // while(count <= number)
// // {
// //     Console.Write(count + " ");
// //     count = count + 1;
// // }.



// // 7. Напишите программу, которая принимает 
// // на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// // 	456 -> 6
// // 	782 -> 2
// // 	918 -> 8

// Console.WriteLine ("Введите 3х значное число ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 99 ||  number > 1000)
// {
//     Console.WriteLine("Ты чо ёпта))");
// }
// else
// {
//     numberA = number 
// }






// // 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// // a = 25, b = 5 -> да 
// // a = 2, b = 10 -> нет 
// // a = 9, b = -3 -> да 
// // a = -3 b = 9 -> нет

// Console.WriteLine("Введите число 1:");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 2:");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if(numberA == numberB * numberB) 
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// 3. Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница






// Console.WriteLine("Введите номер дня недели:");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number == 1)
// {
//     Console.WriteLine("Понедельник");
// }

// if(number == 2)
// {
//     Console.WriteLine("Вторник");
// }

// if(number == 3)
// {
//     Console.WriteLine("Среда");
// }

// if(number == 4)
// {
//     Console.WriteLine("Четверг");
// }

// if(number == 5)
// {
//     Console.WriteLine("Пятница");
// }

// if(number == 6)
// {
//     Console.WriteLine("Суббота");
// }

// if(number == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// if(number == 8)
// {
//     Console.WriteLine("Воскресенье");
// }
// if (number < 1 ||  number > 7)
// {
//     Console.WriteLine("В неделе 7 дней!!!))");
// }






// // 7. Напишите программу, которая принимает 
// // на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// // 	456 -> 6
// // 	782 -> 2
// // 	918 -> 8

// Console.WriteLine("Введите трехзначное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     int digit = number % 10;
//     Console.WriteLine(digit);
// }
// else
// {
//     Console.WriteLine("Введено не трехзначное число");
// }






// // . Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// // a = 25, b = 5 -> да 
// // a = 2, b = 10 -> нет 
// // a = 9, b = -3 -> да 
// // a = -3 b = 9 -> нет
// // 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// // 	3 -> Среда 
// // 5 -> Пятница

// Console.WriteLine ("Напиши первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if (numberA == numberB * numberB)
// {
//     Console.WriteLine ("Угадал!");
// }
// else
// {
//     Console.WriteLine ("Не угадал!");
// }





// // 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// // 	3 -> Среда 
// // 5 -> Пятница

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if((number>7) || (number<=0))
// {
//     Console.WriteLine("Это не день недели");
// }
// else
// {

// switch(number)
// {
//   case 1:
//     Console.WriteLine("Понедельник");
//     break;
//   case 2:
//     Console.WriteLine("Вторник");
//     break;
//   case 3:
//     Console.WriteLine("Среда");
//     break;
//   case 4:
//     Console.WriteLine("Четверг");
//     break;
//   case 5:
//     Console.WriteLine("Пятница");
//     break;
//   case 6:
//     Console.WriteLine("Суббота");
//     break;
//   case 7:
//     Console.WriteLine("Воскресенье");
//     break;
// }
// }
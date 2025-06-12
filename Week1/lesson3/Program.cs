/*
 Задача 5: Числа, кратные 3 и оканчивающиеся на 2
Условие:
В первой строке — количество чисел n, во второй — сама последовательность.
Найти количество чисел, кратных 3 и оканчивающихся на 2.

Пример ввода:
5
12 24 6 72 22
Пример вывода:

2
*/

// int n = int.Parse(Console.ReadLine());
// int a,cnt = 0;
// for (int i = 1; i <= n; i++)
// {
//     a = int.Parse(Console.ReadLine());
//     if (a % 3 == 0 && a % 10 == 2)
//     {
//         cnt++;
//     }
// }
//
// Console.WriteLine("Count: " + cnt);

/*
Пайдарпайии ададҳо дохил карда шудааст, ки бо сифри аввал анҷом меёбад.
Элементҳои пайдарпай дохил карда шударо, калонтаринашро чоп кунед.
*/
// int a, max = Int32.MinValue;
// while (true)
// {
//     a = int.Parse(Console.ReadLine());
//     if (a == 0)
//     {
//         break;
//     }
//
//     if (a > max)
//     {
//         max = a;
//     }
// }
// Console.WriteLine(max + " " + max);

/*
Ададхои a ва n дода мешавад, ҷамъи 1 + a + a^2 +...+a^n-ро чоп кунед.
*/
//
// int a, n;
// double sum = 0;
// a = int.Parse(Console.ReadLine());
// n = int.Parse(Console.ReadLine());
// for (int i = 0; i <= n; i++)
// {
//     sum += Math.Pow(a, i);
// }
//
// Console.WriteLine(sum);

/*
 Пайдарпайии ададҳои ғайриманфӣ (Яъне ададхои калони нол инчунин худи нол низ)
 дохил карда шудааст, ки бо 2-то сифри пайдархам анҷом меёбад.
 Cумаи онхоро, чоп кунед.
Input
1 2 0 3 4 0 5 0 0
Output
15
 */
// int a, sum = 0;
// int pesh = int.Parse(Console.ReadLine());
// while (true)
// {
//     a = int.Parse(Console.ReadLine());
//     if (pesh == 0 && a == 0)
//     {
//         break;
//     }
//     pesh = a;
//     sum += a;
// }
// Console.WriteLine("Sum = " + sum);
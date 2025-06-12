// /*Як адад дода шудааст.
// Ҷамъ ва зарби ҳосили рақамҳои онро ёбед.
// Input
// 123
// Output
// 1+2+3=6
// 1*2*3=6
// */
//
// int a = int.Parse(Console.ReadLine());
// int cnt = 0;
// for (int i = a; i >= 1; i/=10)
// {
//     cnt++;
// }
//
// int[] arr = new int[cnt];
// int index = 0;
// for (int i = a; i >= 1; i /= 10)
// {
//     arr[index] = i % 10;
//     index++;
// }
//
// int sum = 0;
// for (int i = arr.Length - 1; i >= 1; i--)
// {
//     Console.Write(arr[i] + "+");
//     sum += arr[i];
// }
// Console.Write(arr[0] + "=" + (arr[0] + sum));
//
// Console.WriteLine();
//
//
// int z = 1;
// for (int i = arr.Length - 1; i >= 1; i--)
// {
//     Console.Write(arr[i] + "*");
//     z *= arr[i];
// }
// Console.Write(arr[0]+ "=" + arr[0] * z);
//



// // Массив дода мешавад. Элементи хурдтарини массивро чоп кунед.
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
//
// int min = Int32.MaxValue;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }
// }
// Console.WriteLine("Min: " + min);


// Бо назардошти Адади N ва массиви рақамҳои N. Ҳама элементҳоро ба ҷуз элементхои содда чоп кунед.

// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
//
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
// int cnt = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     for (int j = 1; j <= arr[i]; j++)
//     {
//         if (arr[i] % j == 0)
//         {
//             cnt++;
//         }
//     }
//
//     if (cnt > 2)
//     {
//         Console.Write(arr[i] + " ");
//     }
//
//     cnt = 0;
// }


// Напишите программу, которая запрашивает натуральное число N (не более 100),
// а далее последовательность из N чисел,
// и находит количество элементов последовательности равных последнему.
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int cnt = 1;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length - 1; j++)
    {
        if (arr[j] > arr[j+1])
        {
            int a = arr[j];
            arr[j] = arr[i];
            arr[i] = a;
        }
    }
}

for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] != arr[i + 1])
    {
        cnt++;
    }
}

Console.WriteLine(cnt);



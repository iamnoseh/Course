//
// void GetRectangleData(in int width, in int height, out int rectArea, out int rectPerimetr)
// {
//     rectArea = width * height;      
//     rectPerimetr = (width + height) * 2;
// }
//  
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// GetRectangleData(a, b, out var area, out var perimetr);
//  
// Console.WriteLine($"Площадь прямоугольника: {area}");       
// Console.WriteLine($"Периметр прямоугольника: {perimetr}");   

// Напишите метод, который вычисляет
// длину окружности по ее радиусу, используя параметр in.

// void D(in int r, out double darozi)
// {
//     darozi = 2 * Math.PI * r;
// }
//
// int r = int.Parse(Console.ReadLine());
//
// D(r,out double darozi);
// Console.WriteLine(darozi);

// Напишите метод, который переворачивает заданную строку, используя параметры ref.

// void Reverse(ref string s, out string res)
// {
//     char[] arr = s.ToCharArray();
//     res = "";
//     for (int i = arr.Length - 1; i >=0; i--)
//     {
//         res += arr[i];
//     }
// }
// string text = Console.ReadLine();
// Reverse(ref text,out text);
// Console.WriteLine(text);
//
// string Test(in string c)
// {
//     string res = c.ToUpper();
//     switch (res)
//     {
//         case "A":
//             return "Sadonok";
//         break;
//         case "I":
//             return "Sadonok";
//         break;
//         case "O":
//             return "Sadonok";
//         break;
//         case "U":
//             return "Sadonok";
//         break;
//         case "Y":
//             return "Sadonok";
//         break;
//         case "E":
//             return "Sadonok";
//         break;
//         default:
//             return "Hamsado";
//     }
// }
// string a = Console.ReadLine();
//  Console.WriteLine(Test(a));

//
// void RotateThree(ref int a, ref int b, ref int c)
// {
//     int temp = a;
//     a = b;
//     b = c;
//     c = temp;
// }
// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());
// int z = int.Parse(Console.ReadLine());
// RotateThree(ref x, ref y, ref z);
// Console.WriteLine("X = " + x);
// Console.WriteLine("Y = " + y);
// Console.WriteLine("Z = " + z);
//
// void CountSigns(in int[] arr, out int positive, out int negative, out int zero)
// {
//     positive = 0;
//     negative = 0;
//     zero = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == 0)
//         {
//             zero++;
//         }
//
//         if (arr[i] > 0)
//         {
//             positive++;
//         }
//
//         if (arr[i] < 0)
//         {
//             negative++;
//         }
//     }
// }
//
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
// CountSigns(in arr, out int positive, out int negative, out int zero);
// Console.WriteLine("Positive = " + positive);
// Console.WriteLine("Negative = " + negative);
// Console.WriteLine("Zero = " + zero);


// void AppendElement(ref int[] arr, int newElement)
// {
//     int size =arr.Length+1;
//     int[] newArr = new int[arr.Length + 1];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         newArr[i] = arr[i];
//     }
//     newArr[size - 1] = newElement;
//     
//     arr = newArr;
// }
//
// int n = 5;
// int[] arr = { 3, 4, 5, 6, 7 };
// int newElement = 0;
// AppendElement(ref arr,newElement);
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + " ");
// }



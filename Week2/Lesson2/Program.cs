// void Swap(ref int a,int b)
// { 
//     int c = a;
//     a = b;
//     b = c;
// }
//
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// Swap(ref a, b);
//
// Console.WriteLine("A=" + a);
// Console.Write("B=" + b);

//Методро нависед, ки массиви навъи int[] ва арзиши
//навъи int-ро бо ссылки қабул кунад. Метод бояд
//ҳамаи элементҳои массивро бо арзиши додашуда зиёд кунад.
// void IncrementArrayElements(ref int[] array,ref int n)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] += n;
//         n++;
//     }
// }
//
// int[] arr = {1,2,3,4,5,6};
// int n = int.Parse(Console.ReadLine());
// IncrementArrayElements(ref arr,ref n);
//
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + " ");
// }
//
// Console.WriteLine(n);



// double Sum(ref double x, ref double y)
// {
//     x += 500;
//     y += 100;
//     return x + y;
// }
// double Tarh(ref double x, ref double y)
//  {
//      return x - y;
//  }
//
// double a = int.Parse(Console.ReadLine());
// double b = int.Parse(Console.ReadLine());
// Console.WriteLine(Sum(ref a, ref b));
//
// Console.WriteLine("________________");
// Console.WriteLine(Tarh(ref a ,ref b));


//
// void Output(string Name, int Age,out int incrimentAge)
// {
//     Console.WriteLine(Name + " ,shumo " + Age + " sola hasted;");
//     incrimentAge = Age + 1;
// }
// int age = int.Parse(Console.ReadLine());
// string name = Console.ReadLine();
// int incrimentAge;
// Output(name, age,out incrimentAge);
// Console.WriteLine("________________-");
// Output(name, age, out incrimentAge);
// Console.WriteLine(incrimentAge);


//
// void Min(int a, int b, out int min)
// {
//     if (a > b)
//     {
//         min = b;
//     }
//     else
//     {
//         min = a;
//     }
// }
//
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c;
// Min(a, b ,out c);
// Console.WriteLine(c+100);


//
// void Method(ref int a)
// {
//     a *= 2;
// }
// int a = int.Parse(Console.ReadLine());
// Method(ref a);
// Console.WriteLine(a);


// void Harf(ref char s)
// {
//     s = char.Parse(s.ToString().ToUpper());
// }
// char a = char.Parse(Console.ReadLine());
// Harf(ref a);
// Console.WriteLine(a);






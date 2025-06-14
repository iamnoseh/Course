// void Summa(int x, int y)
// {
//     Console.WriteLine(x + y);
// }
// void Zarb(int x, int y)
// {
//     Console.WriteLine(x * y);
// }
// void Tarh(int x, int y)
// {
//     Console.WriteLine(x-y);
// }
// void Taksim(double x, double y)
// {
//     Console.WriteLine(x / y);
// }
//
//
// while (true)
// {
//     int a = int.Parse(Console.ReadLine());
//     char x = char.Parse(Console.ReadLine());
//     int b = int.Parse(Console.ReadLine());
//
//     if (x == '-')
//     {
//         Console.Write("Tarh: ");
//         Tarh(a,b);
//     }
//     else if (x == '+')
//     {
//         Console.Write("Summa :");
//         Summa(a,b);
//     }
//     else if (x == '*')
//     {
//         Console.Write("Zarb: ");
//         Zarb(a,b);
//     }
//     else if (x == '/')
//     {
//         Console.Write("Taksim :");
//         Taksim(a,b);
//     }
// }
//


//
// void PrintFromNumberToOne(int number)
// {
//     for (int i = number; i >= 1; i--)
//     {
//         Console.Write(i + " ");
//     }
// }
//
// int a = int.Parse(Console.ReadLine());
// PrintFromNumberToOne(a);

//
// int Reverse(int num)
// {
//     //540
//     int rev = 0;//4
//     for (int i = num; i >= 1; i/=10)
//     {
//         rev = rev * 10 + i % 10;//45
//     }
//     return rev;
// }
//
// int a = int.Parse(Console.ReadLine());
// int rev = Reverse(a);
// Console.WriteLine(rev);

//
// string PrintStars(int n)
// {
//     string output = "";
//     for (int i = 0; i < n; i++)
//     {
//         output += "*";
//     }
//     return output;
// }
// int a = int.Parse(Console.ReadLine());
// string mystars = PrintStars(a);
// Console.WriteLine(mystars);



// void PrintSquare(int w,int h)
// {
//     for (int i = 0; i < h; i++)
//     {
//         for (int j = 0; j < w; j++)
//         {
//             Console.Write("*");
//         }
//         Console.WriteLine();
//     }
// }
//
//
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// PrintSquare(a,b);



// string PrintTriangle(int size)
// {
//     string output = "";
//     for (int i = 1; i <= size; i++)
//     {
//         for (int j = 0; j < i; j++)
//         {
//             output += "*";
//         }
//         output += "\n";
//     }
//     return output;
// }
// int size = int.Parse(Console.ReadLine());
// string result = PrintTriangle(size);
// Console.WriteLine(result);



void Tree(int h)
{
    int s = 1;
    for (int i = 2*h; i >= 1; i-=2)
    {
        for (int j = 0; j < i; j++)
        {
            if (i/2 == j)
            {
                for (int k = 0; k < s; k++)
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.Write(" ");
            }
        }
        s+=2;
        Console.WriteLine();
    }
    for (int i = 0; i < 2 * h; i++)
    {
        if (i == 2*h/2 - 1)
        {
            Console.Write("|||");
        }
        else
        {
            Console.Write(" ");
        }
    }
}

int n = int.Parse(Console.ReadLine());
Tree(n);
int a;
a = int.Parse(Console.ReadLine());
int cnt = 0;
for (int i = a; i >= 1; i/=10)
{
      if (i % 10 == 0)
      {
            cnt++;
      }
}

if (cnt == 0)
{
      Console.WriteLine("No");
}
else
{
      Console.WriteLine("Yes");
}
 a = int.Parse(Console.ReadLine());
 int a1 = a/100;
 int a2 = a/10%10;
 int a3 = a%10;

 int b = a3 * 100 + a2 * 10 + a1;
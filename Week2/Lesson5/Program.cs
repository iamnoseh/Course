// Car car = new Car();
// car.Make = "Ford";
// car.Model = "Ford";
// car.Year = 1990;
// car.Mileage = 100;
// car.Fuel = 10;
//
// car.Drive(100);
// car.AddFuel(10);
//
//
//
// public class Car
// {
//     public string Make;
//     public string Model;
//     public int Year;
//     public double Mileage;
//     public double Fuel;
//
//     public void Drive(double miles)
//     {
//         Console.Write("You have driven " + miles + " miles." + "Current mileage: " + miles + " miles.");
//         Console.WriteLine("Remaining fuel: " + Fuel + " gallons");
//         Console.WriteLine("Added 5 gallons of fuel. Current fuel level: "  + (Fuel +=5 )  + " gallons.");
//     }
//     public void AddFuel(double fuel)
//     {
//         Console.WriteLine("After the trip and refueling:\nMileage: 100 miles");
//         Fuel += fuel;
//         Console.WriteLine("You have added " + fuel + " fuel.");
//         Console.WriteLine("Fuel level: " + Fuel + " gallons.");
//     }
// }




// Student[] students = new Student[1];
// for (int i = 0; i < students.Length; i++)
// {
//     students[i] = new Student();
//     Console.Write("Nomi studenti " + (i+1) + " - ro vorid kuned : " );
//     students[i].Name = Console.ReadLine();
//     Console.Write("Leveli studenti " + (i+1) + " - ro vorid kuned : " );
//     students[i].Level = int.Parse(Console.ReadLine());
//     Console.Write("Bahohoi studenti " + (i+1) + " - ro vorid kuned : " );
//     for (int j = 0; j < 5; j++)
//     {
//         students[i].Scores[j] = int.Parse(Console.ReadLine());
//     }
// }
//
// for (int i = 0; i < students.Length; i++)
// {
//     Console.Write(i+1 + ". ");
//     double average = students[i].GetAverage();
//     if (average >= 80 && average < 90)
//     {
//         Console.WriteLine("Bahoi shumo khub ast vele boyad ziyodtar kushish kuned. Shumo " + average + " bal giriftaed!");
//     }
//     else if (average > 50 && average < 80)
//     {
//         Console.WriteLine("Bahoi shumo khub nest boyad ziyodtar kushish kuned. Shumo " + average + " bal giriftaed!");
//     }
//     else if(average < 50)
//     {
//         Console.WriteLine("Bahoi shumo khelo bad ast ziyodtar kushish kuned. Shumo " + average + " bal giriftaed!");
//
//     }
//     else if (average  > 90 && average <= 100)
//     {
//         Console.WriteLine("Shumo behtarin donishjued!Bali  shumo " + average + " bal ast!");
//     }
// }
//
//
//
//
// public class Student
// {
//     public string Name;
//     public int Level;
//     public int[] Scores = new int[5];
//     public double GetAverage()
//     {
//         double average = 0;
//         int cnt = 0;
//         for (int i = 0; i < Scores.Length; i++)
//         {
//             average += Scores[i];
//             cnt++;
//         }
//         return average / cnt;
//     }
// }

BankAccount[] bankAccount = new BankAccount[2];
for (int i = 0; i < bankAccount.Length; i++)
{
    bankAccount[i] = new BankAccount();
    Console.Write("Balansi korbari " + i+1 +" ro vorid kuned: ");
    bankAccount[i].Balance = int.Parse(Console.ReadLine());
    Console.Write("Pincode - i korbari " + i+1 +" ro vorid kuned: ");
    bankAccount[i].Pincode = Console.ReadLine();
}


for (int i = 0; i < bankAccount.Length; i++)
{
    Console.Write("Pincodi khudro vorid kuned: ");
    string pincod = Console.ReadLine();
    Console.Write("Mablagro vorid kuned: ");
    decimal mablag = decimal.Parse(Console.ReadLine());
    bankAccount[i].Withdraw(mablag,pincod);
}









public class BankAccount
{
    public decimal Balance;
    public string Pincode;

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine("Ba Balansi shumo " + amount + " somon hamroh karda shud!");
        Console.WriteLine("Hisobi jori: " + Balance + " Tjs");
    }

    public void Withdraw(decimal amount, string pincode)
    {
        if (Balance - amount > 0 && pincode == Pincode)
        {
            Balance -= amount;
            Console.WriteLine("Az Balansi shumo " + amount + " somon girifta shud!");
            Console.WriteLine("Hisobi boqimonda: " + Balance + " Tjs");
        }
    }
}
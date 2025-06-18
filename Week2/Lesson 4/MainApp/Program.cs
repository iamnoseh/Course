



//_________________________________________
// Person person = new Person();
// Console.Write("Enter your FirstName : ");
// person.FirstName = Console.ReadLine();
// Console.Write("Enter your LastName : ");
// person.LastName = Console.ReadLine();
// Console.Write("Enter your Age : ");
// person.Age = int.Parse(Console.ReadLine());
// person.GetInfo();
// Console.WriteLine("____________________");
// Person person2 = new Person();
// person2.FirstName = "Ahmad";
// person2.LastName = "Muhammadov";
// person2.Age = 18;
// person2.GetInfo();

//_________________________________________________
//
// Player player = new Player();
// Console.Write("Enter Player name: ");
// player.Name = Console.ReadLine();
// Console.Write( "Enter Player number: ");
// player.Number = int.Parse(Console.ReadLine());
// Console.Write("Enter your Team name: ");
// player.Team = Console.ReadLine();
// Console.Write("Enter your position: ");
// player.Position = Console.ReadLine();
// Console.Write("Asistend name : ");
// string playerName = Console.ReadLine();
// // player.ScoreGoal();
// // player.AssistGoal(playerName);
// player.GetInfo();
//
//


Person person = new Person();
Console.Write("Enter your Firstname: ");
person.FirstName = Console.ReadLine();
Console.Write("Enter your Lastname: ");
person.LastName = Console.ReadLine();
Console.Write("Enter your Age: ");
person.Age = int.Parse(Console.ReadLine());
Console.Write("Enter your Address: ");
person.Address = Console.ReadLine();

person.GetFullName();
Console.WriteLine("___________________--");
double year = person.GetBirthYear();
Console.WriteLine(year);
public class Person
{
    public string FirstName;
    public string LastName;
    public string Address;
    public int Age;

    public void GetFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }

    public double GetBirthYear()
    {
        return 2025 - Age;
    }
}


public class Player
{
    public string Name;
    public int Number;
    public string Position;
    public string Team;

    public void ScoreGoal()
    {
        Console.WriteLine(Name + " tahti raqami " + Number + " az dastai " + Team + " gol zad!" );
    }

    public void AssistGoal(string playerName)
    {
        Console.WriteLine(Name + " bo pasi " + playerName + "gol zadaast!");
    }

    public void GetInfo()
    {
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Number : " + Number);
        Console.WriteLine("Position : " + Position);
        Console.WriteLine("Team : " + Team);
    }
}




## 🔷 1. Box (Қуттӣ) – Ҳаҷм ва сатҳи рӯйро ҳисоб кунед

**Шарт:**  
Класси `Box` созед, ки дорои хусусиятҳои `Length`, `Width` ва `Height` мебошад.  
Методи `GetVolume()` ҳаҷмро ҳисоб мекунад:  
`Volume = Length * Width * Height`  
Методи `GetSurfaceArea()` сатҳи рӯйро ҳисоб мекунад:  
`SurfaceArea = 2 * (L*W + W*H + H*L)`

**Input:**
```csharp
Box box = new Box(2, 3, 4);
Console.WriteLine(box.GetVolume());
Console.WriteLine(box.GetSurfaceArea());
```

**Output:**
```
Volume: 24
Surface Area: 52
```

---

## 🔷 2. Employee (Корманд) – Маош ва баланд кардани он

**Шарт:**  
Класси `Employee` созед бо `Name` ва `Salary`.  
Методи `GiveRaise(double percent)` маошро мувофиқи фоиз зиёд мекунад.  
Методи `GetAnnualSalary()` маоши солонаро ҳисоб мекунад.

**Input:**
```csharp
Employee emp = new Employee("Ali", 1000);
Console.WriteLine(emp.GetAnnualSalary());
emp.GiveRaise(10);
Console.WriteLine(emp.GetAnnualSalary());
```

**Output:**
```
Annual Salary: 12000
Annual Salary after raise: 13200
```

---

## 🔷 3. BankAccount – Ҳисоб бо PIN

**Шарт:**  
Класси `BankAccount` созед бо `Balance` ва `PinCode`.  
Методи `Withdraw(amount, pin)` танҳо агар PIN дуруст бошад ва маблағ кофӣ бошад, маблағро мегирад.  
Методи `Deposit(amount)` маблағро зиёд мекунад.

**Input:**
```csharp
BankAccount acc = new BankAccount(500, "1234");
acc.Withdraw(200, "1111");
acc.Withdraw(200, "1234");
acc.Deposit(300);
Console.WriteLine(acc.Balance);
```

**Output:**
```
Access Denied
Withdrawal successful
New balance: 600
```

---

## 🔷 4. Movie – Тамошои филм

**Шарт:**  
Класси `Movie` бо `Title`, `Duration` ва `WatchedMinutes`.  
Методи `Watch(int minutes)` тамошоро зиёд мекунад.  
Методи `IsFinished()` нишон медиҳад, ки филм ба охир расидааст ё не.

**Input:**
```csharp
Movie movie = new Movie("Titanic", 195);
movie.Watch(120);
Console.WriteLine(movie.IsFinished());
movie.Watch(80);
Console.WriteLine(movie.IsFinished());
```

**Output:**
```
false
true
```

---

## 🔷 5. Battery – Истеъмоли барқ

**Шарт:**  
Класси `Battery` бо `Capacity` ва `ChargeLevel`.  
Методи `Use(amount)` барқро кам мекунад. Агар ба зери 10% расад, огоҳӣ диҳад.  
Методи `Recharge(amount)` барқро зиёд мекунад.

**Input:**
```csharp
Battery b = new Battery(100);
b.Use(95);
b.Use(3);
b.Recharge(10);
```

**Output:**
```
Battery low! (2% remaining)
Battery low! (0% remaining)
Battery recharged. Current level: 10%
```

---

## 🔷 6. StudentGrade – Миёна ва натиҷа

**Шарт:**  
Класси `StudentGrade` бо `Name` ва рӯйхати `Grades`.  
Методҳо: `AddGrade()`, `GetAverage()`, `GetStatus()` → "Passed" агар миёна > 60

**Input:**
```csharp
StudentGrade s = new StudentGrade("Zamira");
s.AddGrade(70);
s.AddGrade(50);
Console.WriteLine(s.GetAverage());
Console.WriteLine(s.GetStatus());
```

**Output:**
```
Average: 60
Status: Failed
```

---

## 🔷 7. WaterTank – Сатҳи об

**Шарт:**  
Класси `WaterTank` бо `Capacity`, `CurrentLevel`.  
Методҳо: `Fill()`, `Drain()`, `IsFull()`, `IsEmpty()`

**Input:**
```csharp
WaterTank tank = new WaterTank(100);
tank.Fill(40);
tank.Drain(20);
Console.WriteLine(tank.IsFull());
Console.WriteLine(tank.IsEmpty());
```

**Output:**
```
Is full? False
Is empty? False
```

---

## 🔷 8. Product – Нархи бо ААИ ва тахфиф

**Шарт:**  
Класси `Product` бо `Name`, `BasePrice`.  
Методҳо: `GetPriceWithVAT(%)`, `ApplyDiscount(%)`

**Input:**
```csharp
Product p = new Product("Phone", 1000);
Console.WriteLine(p.GetPriceWithVAT(18));
p.ApplyDiscount(10);
Console.WriteLine(p.BasePrice);
```

**Output:**
```
Price with VAT: 1180
New price after discount: 900
```

---

## 🔷 9. Train – Ҳаракат ва сӯзишворӣ

**Шарт:**  
Класси `Train` бо `Speed`, `Fuel`, `DistanceTravelled`.  
Методи `Move(minutes)` → ҳар 1 л сӯзишворӣ = 20 км.  
Методи `Refuel(liters)` низ илова кунед.

**Input:**
```csharp
Train t = new Train(60, 5);
t.Move(60);
Console.WriteLine(t.DistanceTravelled);
t.Move(60);
```

**Output:**
```
Moved: 60 km
Fuel remaining: 2
Moved: 40 km
Out of fuel
```

---

## 🔷 10. ParkingLot – Ҷойи таваққуф

**Шарт:**  
Класси `ParkingLot` бо `TotalSpots`, `OccupiedSpots`.  
Методҳо: `ParkCar()`, `RemoveCar()`, `IsFull()`

**Input:**
```csharp
ParkingLot p = new ParkingLot(2);
p.ParkCar();
p.ParkCar();
Console.WriteLine(p.IsFull());
p.ParkCar();
p.RemoveCar();
Console.WriteLine(p.IsFull());
```

**Output:**
```
Parking full? True
Cannot park: No space left
Parking full? False
```

# 🧠 Мавзӯъ: Function бо `ref`, `in`, `out`

---

## 🔹 1. Ҷойивазкунии минималӣ бо `ref`

**Шарт:**  
Функсияе нависед, ки 3 ададро бо `ref` қабул мекунад ва онҳоро ба тартиби афзоянда ҷойиваз мекунад. Танҳо бо `ref`.

```csharp
void SortThree(ref int a, ref int b, ref int c)
```

**Input:**
```ini
a = 9, b = 2, c = 5
```

**Output:**
```ini
a = 2, b = 5, c = 9
```

---

## 🔹 2. Ҳисоб кардани медианаи се адад бо `in` ва `out`

**Шарт:**  
Функсияе нависед, ки 3 ададро бо `in` қабул мекунад ва адади миёна (на миёнаарифметикӣ, балки медиана) бо `out` бармегардонад.

```csharp
void Median(in int x, in int y, in int z, out int median)
```

**Input:**
```ini
x = 12, y = 4, z = 7
```

**Output:**
```ini
median = 7
```

---

## 🔹 3. Номувозинии суммаи ҷуфт ва тоқ бо `in` ва `out`

**Шарт:**  
Функсияе нависед, ки як массиви бутуниро бо `in` қабул мекунад ва тафовут байни суммаи ададҳои ҷуфт ва тоқро бо `out` бармегардонад.

```csharp
void CalculateImbalance(in int[] numbers, out int result)
```

**Input:**
```ini
numbers = [1, 2, 3, 4, 5]
```

**Output:**
```ini
result = -3
```

---
# Синфҳо бо Property ва Method дар C#

## 🔸 1. Синфи `Student`

**Шарт (тафсилот):**  
Синфе созед бо номи `Student`, ки маълумотҳои донишҷӯро нигоҳ медорад. Ин синф бояд хусусиятҳои зерин дошта бошад:

- `FullName` – номи пурраи донишҷӯ (намуна: `"Zarina Kh."`)  
- `Age` – синну соли донишҷӯ (намуна: `17`)  
- `Grade` – синфи таҳсил ё курси донишҷӯ (намуна: `11`)  
- `Scores` – рӯйхати холҳо (`int[5]`), ки натиҷаи имтиҳонҳоро нишон медиҳад (намуна: `[90, 85, 100,78,90]`)  
- `IsActive` – нишон медиҳад, ки оё донишҷӯ дар ҳолати фаъол қарор дорад ё не (`true`/`false`)  

**Методҳо:**  
1. `double GetAverageScore()`  
   – Ҳисоби миёнаи холҳои дохили рӯйхати `Scores`-ро ҳисоб мекунад ва ҳамчун `double` бармегардонад.  

2. `void PrintProfile()`  
   – Ҳамаи маълумотҳои донишҷӯро дар формати зебо дар экран чоп мекунад.  

**Намунаи истифода:**  
```csharp
Student s = new Student("Zarina Kh.", 17, 11, [90, 85, 100, 78, 90], true);
s.PrintProfile();
Console.WriteLine("Average: " + s.GetAverageScore());
```

**Натиҷа:**  
```
Name: Zarina Kh.
Age: 17
Grade: 11
Active: Yes
Scores: 90, 85, 100
Average: 91.67
```

---

## 🔸 2. Синфи `Product`

**Шарт (тафсилот):**  
Синфе созед барои нигоҳ доштани маълумоти як мол дар мағоза. Синф дорои хусусиятҳои зерин аст:  

- `Name` – номи маҳсулот (намуна: `"Laptop"`)  
- `Price` – нархи як дона маҳсулот (намуна: `1000`)  
- `Quantity` – миқдори маҳсулот (намуна: `2`)  
- `Category` – категория ё навъи мол (намуна: `"Electronics"`)  
- `Discount` – тахфифи дар фоиз ифодаёфта (намуна: `10`)  

**Методҳо:**  
1. `double GetFinalPrice()`  
   – Нархи умумии молро бо дарназардошти тахфиф ҳисоб мекунад.  

2. `void PrintInfo()`  
   – Маълумоти молро дар шакли зебо дар консол чоп мекунад.  

**Намунаи истифода:**  
```csharp
Product p = new Product("Laptop", 1000, 2, "Electronics", 10);
p.PrintInfo();
Console.WriteLine("Final Price: " + p.GetFinalPrice());
```

**Натиҷа:**  
```
Product: Laptop
Category: Electronics
Price: 1000
Quantity: 2
Discount: 10%
Final Price: 1800
```

---

## 🔸 3. Синфи `Book`

**Шарт (тафсилот):**  
Синфе созед барои нишон додани маълумоти китоб. Синф бояд дорои чунин хусусиятҳо бошад:  

- `Title` – унвони китоб (намуна: `"Dune"`)  
- `Author` – номи муаллиф (намуна: `"Frank Herbert"`)  
- `Year` – соли нашри китоб (намуна: `1965`)  
- `Pages` – шумораи саҳифаҳои китоб (намуна: `412`)  
- `Genre` – жанри китоб (намуна: `"Sci-Fi"`)  

**Методҳо:**  
1. `bool IsBigBook()`  
   – Агар саҳифаҳои китоб > 300 бошад, `true` бармегардонад, вагарна `false`.  

2. `void PrintSummary()`  
   – Тамоми маълумоти китобро чоп мекунад.  

**Намунаи истифода:**  
```csharp
Book b = new Book("Dune", "Frank Herbert", 1965, 412, "Sci-Fi");
b.PrintSummary();
Console.WriteLine("Big Book: " + b.IsBigBook());
```

**Натиҷа:**  
```
Title: Dune
Author: Frank Herbert
Year: 1965
Pages: 412
Genre: Sci-Fi
Big Book: True
```

---

## 🔸 4. Синфи `Employee`

**Шарт (тафсилот):**  
Синфе созед, ки маълумоти кормандро нигоҳ медорад. Хусусиятҳои лозим:  

- `Name` – номи корманд (намуна: `"Ali"`)  
- `Position` – мансаби корманд (намуна: `"Senior Dev"`)  
- `Experience` – таҷрибаи кор дар сол (намуна: `6`)  
- `BaseSalary` – маоши асосӣ (намуна: `2000`)  
- `IsRemote` – оё корманд дар дур кор мекунад (`true`/`false`)  

**Методҳо:**  
1. `double CalculateBonus()`  
   – Агар `Experience > 5` бошад, бонус 20% аз маош; дар акси ҳол, 10%.  

2. `void PrintEmployee()`  
   – Маълумоти кормандро дар экран намоиш медиҳад.  

**Намунаи истифода:**  
```csharp
Employee e = new Employee("Ali", "Senior Dev", 6, 2000, true);
e.PrintEmployee();
Console.WriteLine("Bonus: " + e.CalculateBonus());
```

**Натиҷа:**  
```
Name: Ali
Position: Senior Dev
Experience: 6 years
Remote: Yes
Base Salary: 2000
Bonus: 400
```
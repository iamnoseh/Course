### Task 1
Create the following method in the exercise template `void PrintFromNumberToOne(int number)` . It should print the numbers from the number passed as a parameter down to one.            

----
     
Создайте в шаблоне упражнения следующий метод `void PrintFromNumberToOne(int number)` . Он должен печатать числа от числа, переданного в качестве параметра, до единицы.      

----

Методе созед `void PrintFromNumberToOne(int number)` , ки он бояд рақамҳоро аз рақаме, ки ҳамчун параметр дода мешавад то ба як чоп кунад.

**Input**
```
5
```
**Output**
```
5 4 3 2 1
```
**Input**
```
10
```
**Output**
```
10 9 8 7 6 5 4 3 2 1
```

##

### Task 2
Expand the method `Sum(int a, int b, int c, int d)` in the exercise template so that it calculates and returns the sum of the numbers that are given as the parameters.

----

Разверните метод `Sum(int a, int b, int c, int d)` в шаблоне упражнения, чтобы он вычислял и возвращал сумму чисел, заданных в качестве параметров.

----

Методи `Sum(int a, int b, int c, int d)`-ро созед. Он чамъи рақамҳои ҳамчун параметр додашударо ҳисоб кунад ва баргардонад.

**Input**
```
1 2 3 4 
```
**Output**
```
10
```

## 

### Task3
Write a Method **`int Reverse(int n)`** that takes one parameter and returns it in reverse order.  

----

Напишите метод **`int Reverse(int n)`**, которая принимает один параметр и возвращает его в обратном порядке.

----

Методи **`int Reverse (int n)`** -ро нависед, ки як параметрро гирифта, онро баръакс бармегардонад.

**Input**
```
811
```
**Output**
```
118
```

##

### Task 4
#### SECTION 1
Define a method called `PrintStars(int n)` that prints the given number of stars and a line break. Write the method in the following template.

----

Определите метод `PrintStars(int n)`, который печатает заданное количество звездочек и разрыва строки. Напишите метод в следующем шаблоне.

----

Методи `PrintStars(int n)`-ро муайян кунед, ки шумораи муайяни ситораҳо ва сар хат чоп мекунад.

**Input**
```
5
```
**Output**
```
***** 
```
##

#### SECTION 2
Define a method called `PrintSquare(int size)` that prints a suitable square with the help of the `PrintStars(int n)` method.

----

Определите метод `PrintSquare(int size)`, который печатает подходящий квадрат с помощью метода `PrintStars(int n).`

----

Методи `PrintSquare(int n)`-ро  созед, ки квадрати мувофиқро бо методи `PrintStars(int n)` чоп мекунад.

**Input**
```
4
```
**Output**
```
****
****
****
****
```
##

#### SECTION 3
Write a method called `PrintRectangle(int width, int height)` that prints the correct rectangle by using the method `PrintStars(int n)` . 

----

Напишите метод `PrintRectangle(int width, int height)`, который печатает правильный прямоугольник с помощью метода `PrintStars(int)`.

----

Методи `PrintRectangle(int width, int height)` нависед, ки бо истифода аз методи `PrintStars(int n)` росткунҷа чоп мекунад.

**Input**
```
17 3
```
**Output**
```
***************** 
***************** 
*****************
```
##

#### SECTION 4
Create a method called `PrintTriangle(int size)` that prints a triangle by using the `PrintStars(int n)` method.

----

Создайте метод `PrintTriangle(int size)`, который печатает треугольник с помощью метода `PrintStars(int n)` .

----

Mетоди `PrintTriangle(int size)` нависед, ки секунҷаро бо методи `PrintStars(int n)` чоп мекунад.

**Input**
```
4
```
**Output**
```
*
**
***
****
```
##

### Task 5
#### SECTION 1
Define a method called `PrintSpaces(int number)` that produces the number of spaces specified by number.     

The method `does not print the line break`. You will also have to either copy the **`PrintStars(int n)`** method from your previous answer or reimplement it in this exercise template.     

----

Определите метод **`PrintSpaces(int number)`**, который выдает количество пробелов, указанное числом.                                             

Метод `не печатает разрыв строки`. Вам также придется скопировать метод **`PrintStars(int n)`**  из предыдущего ответа или повторно реализуйте его в этом шаблоне упражнения.

----

Методи бо номи **`PrintSpaces(int number)`**-ро нависед, ки фосилаҳо мемонад вобаста ба рақам.

Mетод `сар хат чоп намекунад`. Шумо инчунин бояд усули **`PrintStars(int n)`**-ро истифода баред аз ҷавоби қаблии худ ё онро дар ин машқ дубора cозед.

##

#### SECTION 2
Create a method called **`PrintRightTriangle(int size)`** that uses **`PrintSpaces(int size)`** and **`PrintStars(int n)`** to print the correct triangle.     

----

Создайте метод **`PrintRightTriangle(int size)`**, который использует **`PrintSpaces(int size)`** и **`PrintStars(int n)`** для печати прямоугольный треугольник.

----

Методи **`PrintRightTriangle(int size)`** нависед, ки барои чопи секунҷаи росткунча **`PrintSpaces(int size)`** ва **`PrintStars(int n)`** истифода мебарад.

**Input**
```
4
```
**Output**
```
   *
  **
 ***
****
```
##

#### SECTION 3
Define a method called **`Tree(int height)`** that prints the tree. The tree consists of a triangle with the specified height and the base. The base is two stars high and three stars wide and is placed at the center of the triangle’s bottom. The tree is to be constructed by using the methods **`PrintSpaces(int n)`** and **`PrintStars(int n)`**.

----

Определите метод **`Tree(int height)`**, который печатает елку. Елка состоит из треугольника заданной высоты и основания. Основание имеет высоту две звезды и ширину три звезды и расположено в центре нижней части треугольника. Дерево должно быть построено с использованием методов **`PrintSpaces(int n)`** и **`PrintStars(int n)`**.

----

Mетоди **`Tree(int height)`**-ро муайян кунед, ки aрча чоп мекунад. Арча аз секунҷаи баландии додашуда ва поя иборат аст. Пойгоҳи он ду ситора баланд ва се ситора дароз аст ва дар маркази поёни секунҷа ҷойгир аст. Дарахт бояд бо истифода аз Методҳои **`PrintSpaces(int n)`** ва **`PrintStars(int n)`** сохта шавад.

**Input**
```
4
```
**Output**
```
   * 
  *** 
 *****
******* 
  *** 
  ***
```

##### The call **`Tree(10)`** should print:  
```

         * 
        *** 
       ***** 
      ******* 
     ********* 
    *********** 
   ************* 
  *************** 
 ***************** 
******************* 
        *** 
        ***
```


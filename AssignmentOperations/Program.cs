﻿#region

// Операции присвоения устанавливают значение. В операциях присвоения участвуют
// два операнда, причем левый операнд может представлять только модифицируемое
// именованное выражение, например, переменную

// Как и во многих других языках программирования, в C# имеется базовая операция
// присваивания =, которая присвоивает значение правого операнда левому операнду:

// int number = 23;
// Здесь переменной number присваивается число 23. Переменная number представляет
// левый операнд, которому присваивается значение правого операнда, то есть числа 23.

// Также можно выполнять множественно присвоение сразу нескольких переменным одновременно:

// int a, b, c;
// a = b = c = 34;

//Операции присвоения имеют низкий приоритет. И вначале будет вычисляться значение
//правого операнда и только потом будет идти присвоение этого значения левому операнду.

#endregion

#region +=

/*
+=: присваивание после сложения. Присваивает левому операнду сумму левого и 
правого операндов: выражение A += B равнозначно выражению A = A + B 
*/
var b = 10;
var a = 20;
a = a + b;
//a += b;

//Console.WriteLine(a);  // 25

#endregion

#region -=
/*
-=: присваивание после вычитания. Присваивает левому операнду разность левого и
правого операндов: A -= B эквивалентно A = A - B 
*/

Console.ReadKey();
Console.WriteLine("\n-=");

//int a = 12;
//int b = 13;
//int c = a - b;

//Console.WriteLine(c);  // -1

//a = a - b;
a -= b;

Console.WriteLine(a);  // -1

#endregion

#region *=

//*=: присваивание после умножения. Присваивает левому операнду произведение левого и
//правого операндов: A *= B эквивалентно A = A * B

Console.ReadKey(); Console.WriteLine("\n*=");

//a = 4;
//b = 5;
//c = a * b;

//Console.WriteLine(c);  // 20
a *= b; //a = a * b;

Console.WriteLine(a);  // 20

#endregion

#region /=

//=: присваивание после деления. Присваивает левому операнду частное левого и 
//правого операндов: A /= B эквивалентно A = A / B

Console.ReadKey(); Console.WriteLine("\n/=");

a = 33;
b = 11;
a /= b; //a = a / b;
Console.WriteLine(a);

Console.WriteLine(a);  // 3

//a = 30;
//b = 11;
//c = a / b;
//Console.WriteLine(c); //2

//a /= b;
//Console.WriteLine(a); //2

double d = 10;
double e = 4;
d /= e;
Console.WriteLine(d); //2.5

#endregion

#region %=

//%=: присваивание после деления по модулю. Присваивает левому операнду остаток от
//целочисленного деления левого операнда на правый: A %= B эквивалентно A = A % B

//Console.ReadKey(); Console.WriteLine("\n%=");

//a = 14;
//b = 5;
//c = a % b;

//Console.WriteLine(c);  // 4

//a = a % b;
a %= b;

Console.WriteLine(a);  // 4

#endregion

//&=: присваивание после поразрядной конъюнкции. Присваивает левому операнду результат
//поразрядной конъюнкции его битового представления с битовым представлением правого
//операнда: A &= B эквивалентно A = A & B

//|=: присваивание после поразрядной дизъюнкции. Присваивает левому операнду результат
//поразрядной дизъюнкции его битового представления с битовым представлением правого
//операнда: A |= B эквивалентно A = A | B

//^=: присваивание после операции исключающего ИЛИ. Присваивает левому операнду результат
//операции исключающего ИЛИ его битового представления с битовым представлением правого
//операнда: A ^= B эквивалентно A = A ^ B

//<<=: присваивание после сдвига разрядов влево. Присваивает левому операнду результат
//сдвига его битового представления влево на определенное количество разрядов, равное
//значению правого операнда: A <<= B эквивалентно A = A << B

//>>=: присваивание после сдвига разрядов вправо. Присваивает левому операнду результат
//сдвига его битового представления вправо на определенное количество разрядов, равное
//значению правого операнда: A >>= B эквивалентно A = A >> B


#region ++

Console.ReadKey();
Console.WriteLine("\n++");

a = 10;

a += 20;
Console.WriteLine(a); //30

a += 1;
Console.WriteLine(a); //31

a++; // постфиксный инкремент
Console.WriteLine(a); //32

++a;// префиксный инкремент
Console.WriteLine(a); //33

#endregion

#region --
Console.ReadKey(); Console.WriteLine("\n--");
a = 50;

a -= 20;
Console.WriteLine(a); //30

a -= 1;
Console.WriteLine(a); //29

a--; // постфиксный инкремент
Console.WriteLine(a); //28

--a;// префиксный инкремент
Console.WriteLine(a); //27

#endregion

/*
Существует два вида инкрементов:

- Преинкремент (или префиксный инкремент). Значение переменной сначала увеличивается
на 1, а затем используется в выражении, к которому относится данная переменная.

- Постинкремент (или постфиксный инкремент). Значение переменной сначала используется
в выражении, а потом увеличивается на 1. 
 
*/
// Постфиксный инкремент сначала отдает нам результат, а потом увеличивает его на 1
// Префиксный инкремент сразу увеличивает значение на 1
var x = 0;
x++;
Console.WriteLine(x);

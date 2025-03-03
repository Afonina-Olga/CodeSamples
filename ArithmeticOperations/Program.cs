﻿// Арифметические операции
/*
Операции бывают унарными (выполняются над одним операндом), 
бинарными - над двумя операндами и 
тернарными - выполняются над тремя операндами. 
*/

#region Сумма +

#endregion

#region  Разность -

#endregion

#region  Произведение *

#endregion

#region Частное /

int x = 10;
int z = x / 5; // 2

double a = 10;
double b = 3;
double c = a / b; // 3.33333333

/*
При делении стоит учитывать, что если оба операнда представляют целые числа,
то результат также будет округляться до целого числа
*/

double t = 10 / 4; //результат равен 2
//Несмотря на то, что результат операции в итоге помещается в переменную типа double,
//которая позволяет сохранить дробную часть, но в самой операции участвуют два
//литерала, которые по умолчанию рассматриваются как объекты int, то есть целые числа,
//и результат то же будет целочисленный.

//Для выхода из этой ситуации необходимо определять литералы или переменные,
//участвующие в операции, именно как типы double или float:

double l = 10.0 / 4.0; //результат равен 2.5

#endregion

#region Остаток от деления %

#endregion

#region Инкремент

//Инкремент бывает префиксным: ++x - сначала значение переменной x увеличивается на 1,
//а потом ее значение возвращается в качестве результата операции.

//И также существует постфиксный инкремент: x++ - сначала значение переменной x
//возвращается в качестве результата операции, а затем к нему прибавляется 1.

int x1 = 5;
int z1 = ++x1; // z1=6; x1=6
Console.WriteLine($"{x1} - {z1}");

int x2 = 5;
int z2 = x2++; // z2=5; x2=6
Console.WriteLine($"{x2} - {z2}");

#endregion

#region Декремент

#endregion

/*
При выполнении сразу нескольких арифметических операций следует учитывать порядок их
выполнения. Приоритет операций от наивысшего к низшему:

- Постфиксный инкремент, декремент
- Умножение, деление, получение остатка
- Сложение, вычитание

Для изменения порядка следования операций применяются скобки. 
*/

/*
Когда операции имеют один и тот же приоритет, порядок вычисления определяется 
ассоциативностью операторов. В зависимости от ассоциативности есть два типа 
операторов:

- Левоассоциативные операторы, которые выполняются слева направо
- Правоассоциативные операторы, которые выполняются справа налево

Все арифметические операторы являются левоассоциативными, то есть выполняются 
слева направо.

*/
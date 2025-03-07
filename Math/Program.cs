//Abs(double value): возвращает абсолютное значение для аргумента value
// Модуль

double abs = Math.Abs(-12.4); // 12.4

//Acos(double value): возвращает арккосинус value. Параметр value должен иметь
//значение от -1 до 1

double acos = Math.Acos(1); // 0

//Asin(double value): возвращает арксинус value. Параметр value должен иметь
//значение от -1 до 1

//Atan(double value): возвращает арктангенс value

//BigMul(int x, int y): возвращает произведение x * y в виде объекта long

double bigMul = Math.BigMul(100, 9340); // 934000

//Ceiling(double value): возвращает наименьшее целое число с плавающей точкой,
//которое не меньше value

double ceiling = Math.Ceiling(2.34); // 3
									 //Cos(double d): возвращает косинус угла d

//Cosh(double d): возвращает гиперболический косинус угла d

//DivRem(int a, int b, out int result): возвращает результат от деления a/b, а остаток помещается в параметр result

int divRem;
int div = Math.DivRem(14, 5, out divRem);

//Exp(double d): возaвращает основание натурального логарифма, возведенное в степень d

//Floor(decimal d): возвращает наибольшее целое число, которое не больше d

double floor = Math.Floor(2.56); // 2

//IEEERemainder(double a, double b): возвращает остаток от деления a на b

double remainder = Math.IEEERemainder(26, 4); // 2 = 26-24

//Log(double d): возвращает натуральный логарифм числа d

//Log(double a, double newBase): возвращает логарифм числа a по основанию newBase

//Log10(double d): возвращает десятичный логарифм числа d

//Max(double a, double b): возвращает максимальное число из a и b

//Min(double a, double b): возвращает минимальное число из a и b

//Pow(double a, double b): возвращает число a, возведенное в степень b

//Round(double d): возвращает число d, округленное до ближайшего целого числа

//Sign(double value): возвращает число 1, если число value положительное,
//и -1, если значение value отрицательное. Если value равно 0, то возвращает 0

//Sin(double value): возвращает синус угла value

//Sinh(double value): возвращает гиперболический синус угла value

//Sqrt(double value): возвращает квадратный корень числа value

//Tan(double value): возвращает тангенс угла value

//Tanh(double value): возвращает гиперболический тангенс угла value

//Truncate(double value): отбрасывает дробную часть числа value, возвращаяя лишь целое значение

double truncate = Math.Truncate(16.89); // 16

//Также класс Math определяет две константы: Math.E и Math.PI.
var e = Math.E;

var pi = Math.PI;

var firstName = "Ольга";
var lastName = "Афонина";
var middleName = "Геннадьевна";
var job = "Программист";

// Конкатенация строк
Console.WriteLine(lastName + firstName + middleName + job);

Console.WriteLine(lastName + " " + firstName + " " + middleName + " " + job);

Console.WriteLine("Имя: " + firstName + " Фамилия: " + lastName + " Отчество: " + middleName + " Профессия: " + job);

Console.WriteLine("Фамилия: {0} Имя: {1} Отчество: {2} Профессия: {3}",
					lastName,
					firstName,
					middleName,
					job);

string pattern = "Фамилия: {0} Имя: {1} Отчество: {2} Профессия: {3}";
Console.WriteLine(pattern,
					lastName,
					firstName,
					middleName,
					job);

#region Вывод данных Escape-последовательности

// \n Новая строка
// \r Возврат каретки
// \t Горизонтальная табуляция
// \' Одиночная кавычка
// \" Двойная кавычка
// \\ Обратная косая черта
// \? Литерал вопросительного знака

string newPattern = "Фамилия: {0}\n Имя: {1}\n Отчество: {2}\n Профессия: {3}";
Console.WriteLine(newPattern,
					lastName,
					firstName,
					middleName,
					job);

#endregion

#region Интерполяция строк

Console.WriteLine($"Фамилия: {lastName}\n Имя: {firstName}\n Отчество: {middleName}\n Профессия: {job}");

#endregion

#region Калькулятор

int a = 100;
int b = 11;
Console.WriteLine($"{a} + {b} = {a + b}");

#endregion

#region База данных v 1.0

string name1 = "Агата", lastName1 = "Лебедева";
string name2 = "Аделаида", lastName2 = "Виноградова";
string name3 = "Алима", lastName3 = "Попова";
string name4 = "Катя", lastName4 = "Калинина";
string name5 = "Рената", lastName5 = "Иванова";

Console.WriteLine($"{name1} {lastName1}"); // Console.WriteLine(name1 + " " + lastName1);
Console.WriteLine($"{name2} {lastName2}");
Console.WriteLine($"{name3} {lastName3}");
Console.WriteLine($"{name4} {lastName4}");
Console.WriteLine($"{name5} {lastName5}");

#endregion

#region База данных v 2.0

Console.WriteLine($"{name1,20} {lastName1,20}");
Console.WriteLine($"{name2,20} {lastName2,20}");
Console.WriteLine($"{name3,20} {lastName3,20}");
Console.WriteLine($"{name4,20} {lastName4,20}");
Console.WriteLine($"{name5,20} {lastName5,20}");

#endregion

#region Настраиваемые форматы

double d = 123456.654321;
Console.WriteLine(d);                       // 123456.654321

string dFormated = d.ToString("#.###");
Console.WriteLine(dFormated);               // 123456,654

Console.WriteLine("{0:0.000}", d);          // 123456,654
Console.WriteLine($"{d:0.000}");
Console.WriteLine($"{d:#.###}");

Console.WriteLine(d.ToString("#.###"));     // 123456,654


dFormated = d.ToString("#.## ## ## ## ##");
Console.WriteLine(dFormated);               // 123456,65 43 21

dFormated = d.ToString("### ###.## ## ## ## ##");
Console.WriteLine(dFormated);               // 123 456,65 43 21   

Console.WriteLine("{0:000 000 000.000 000 000}", d); // 000 123 456,654 321 000

#endregion

#region Вывод дат

// В зависимости от настроек языкового стандарта программы
// выводимые символы могут отличаться. 
Console.WriteLine();
var date = new DateTime(2025, 09, 28, 01, 30, 59);
Console.WriteLine(date);
Console.WriteLine($"{date:HH:mm}");
Console.WriteLine($"{date:yyyy-MM-dd}");
Console.WriteLine($"{date:yy.MM.dd}");
Console.WriteLine($"{date:dd.MM.yyy}");

#endregion

#region Денежные единицы

//C/c
//Задает формат денежной единицы, указывает количество десятичных разрядов после запятой

double number = 23.7;
string money = string.Format("{0:C0}", number);
Console.WriteLine(money); // 24 р.
money = string.Format("{0:C2}", number);
Console.WriteLine(money); // 23,70 р.

#endregion

#region Целые числа

//D/d
//Целочисленный формат, указывает минимальное количество цифр

int digit = 23;
string intValue1 = string.Format("{0:d}", digit);
Console.WriteLine(intValue1); // 23
string intValue2 = string.Format("{0:d4}", digit);
Console.WriteLine(intValue2); // 0023

#endregion

//E/e
//Экспоненциальное представление числа, указывает количество десятичных разрядов после запятой

var exp = 20_000.65;
Console.WriteLine($"{exp:e2}");

//F/f
//Формат дробных чисел с фиксированной точкой, указывает количество десятичных разрядов после запятой
var fraction = 40.8857;
Console.WriteLine($"{fraction:f2}");

//G/g
//Задает более короткий из двух форматов: F или E (автоматически выбирает)
var g = 20.05;
Console.WriteLine($"{g:g1}");

//N/n
//Также задает формат дробных чисел с фиксированной точкой, определяет количество разрядов после запятой
var n = 50.63;
Console.WriteLine($"{n:N5}");

//P/p
//Задает отображения знака процентов рядом с число, указывает количество десятичных разрядов после запятой
var p = 0.69;
Console.WriteLine($"{p:p1}");

//X/x
//Шестнадцатеричный формат числа
var x = 65855;
Console.WriteLine($"{x:X}");

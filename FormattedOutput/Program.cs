/*Немного про консоль*/

Console.WriteLine("Я пишу на экране");
var input = Console.ReadLine();
Console.WriteLine(input);
/*---------------------------------------------------------------*/

var firstName = "Ольга";
var lastName = "Афонина";
var middleName = "Геннадьевна";
var job = "Программист";

// Конкатенация строк
Console.WriteLine(lastName + firstName + middleName + job);
Console.ReadKey();

Console.WriteLine(lastName + " " + firstName + " " + middleName + " " + job);
Console.ReadKey();

Console.WriteLine("Имя: " + firstName + " Фамилия: " + lastName + " Отчество: " + middleName + " Профессия: " + job);
Console.ReadKey();

Console.WriteLine("Фамилия: {0} Имя: {1} Отчество: {2} Профессия: {3}",
					lastName,
					firstName,
					middleName,
					job);
Console.ReadKey();

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

Console.ReadKey();
Console.Clear();

int a = 100;
int b = 11;
Console.WriteLine($"{a} + {b} = {a + b}");

#endregion

#region База данных v 1.0

Console.ReadKey(); 
Console.Clear();

string name1 = "Агата", lastName1 = "Лебедева";
string name2 = "Аделаида", lastName2 = "Виноградова";
string name3 = "Алима", lastName3 = "Попова";
string name4 = "Катя", lastName4 = "Калинина";
string name5 = "Рената", lastName5 = "Иванова";

Console.WriteLine($"{name1} {lastName1}");
Console.WriteLine($"{name2} {lastName2}");
Console.WriteLine($"{name3} {lastName3}");
Console.WriteLine($"{name4} {lastName4}");
Console.WriteLine($"{name5} {lastName5}");


#endregion

#region База данных v 2.0

Console.ReadKey(); Console.Clear();

Console.WriteLine($"{name1,10} {lastName1,11}");
Console.WriteLine($"{name2,10} {lastName2,11}");
Console.WriteLine($"{name3,10} {lastName3,11}");
Console.WriteLine($"{name4,10} {lastName4,11}");
Console.WriteLine($"{name5,10} {lastName5,11}");

#endregion

#region Вывод чисел

double d = 123456.654321;
Console.WriteLine(d);                       // 123456.654321

string dFormated = d.ToString("#.###");
Console.WriteLine(dFormated);               // 123456,654

Console.WriteLine("{0:0.000}", d);          // 123456,654

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

Console.ReadKey();
Console.WriteLine($"{date:HH:mm}");
Console.WriteLine($"{date:yyyy-MM-dd}");
Console.WriteLine($"{date:yy.MM.dd}");
Console.WriteLine($"{date:dd.MM.yyy}");

#endregion

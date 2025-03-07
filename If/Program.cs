// Условные конструкции - один из базовых компонентов многих языков программирования,
// которые направляют работу программы по одному из путей в зависимости от
// определенных условий. 

// Конструкция if/else проверяет истинность некоторого условия и в зависимости от
// результатов проверки выполняет определенный код.

// Ее простейшая форма состоит из блока if:

//if (условие)
//{
//	выполняемые инструкции
//}

// После ключевого слова if ставится условие. Условие должно представлять
// значение типа bool. Это может быть непосредственно значение типа bool
// или результат условного выражения или другого выражения, которое возвращает
// значение типа bool. И если это условие истинно (равно true), то срабатывает
// код, который помещен далее после условия внутри фигурных скобок

#region Только if

if (2 == 2)
{
	Console.WriteLine("Равно");
}

if (2 * 2 == 4)
{
	Console.WriteLine("Дважды два четыре!");
}

// Если блок if содержит одну инструкцию, то мы можем его сократить,
// убрав фигурные скобки (но лучше сразу привыкать везде расставлять скобки,
// даже если кажется, что они не нужны)

if (5 > 4) Console.WriteLine("True");

// Также мы можем соединить сразу несколько условий, используя логические операторы:
int num1 = 8;
int num2 = 6;

if (num1 > num2 && num1 == 8)
{
	Console.WriteLine($"Число {num1} больше числа {num2}");
}

#endregion

#region else

// Но что, если мы захотим, чтобы при несоблюдении условия также выполнялись
// какие-либо действия? В этом случае мы можем добавить блок else:

int first = 8;
int second = 6;

if (first > second)
{
	Console.WriteLine($"Число {first} больше числа {second}");
}
else
{
	Console.WriteLine($"Число {first} меньше числа {second}");
}

// Блок else выполняется, если условие после if ложно, то есть равно false.

// Можно сократить (но не нужно):

// int num1 = 8;
// int num2 = 6;
// if (num1 > num2)
//		Console.WriteLine($"Число {num1} больше числа {num2}");
// else
//		Console.WriteLine($"Число {num1} меньше числа {num2}");

#endregion

#region Тернарная операция

// В дополнение к оператору if есть, так называемый, тернарный оператор (?:).
// Этот оператор может заменить одно предложение if-else, которое 
// присваивает значение конкретной переменной. 
// Оператор принимает три выражения. 
// Если первый оценивается как true, будет возвращено второе выражение, 
// и если оно false, то возвращается третий

// Синтаксис: [первый операнд - условие] ? [второй операнд] : [третий операнд]
// Это всего лишь сокращенная запись if-else

int x = 3;
int y = 2;

int z = x < y ? (x + y) : (x - y);
Console.WriteLine(z);   // 1

#endregion

#region else if

// Используя конструкцию else if, мы можем обрабатывать дополнительные условия:

int n1 = 8;
int n2 = 6;
if (n1 > n2)
{
	Console.WriteLine($"Число {n1} больше числа {n2}");
}
else if (n1 < n2)
{
	Console.WriteLine($"Число {n1} меньше числа {n2}");
}
else
{
	Console.WriteLine("Число n1 равно числу n2");
}

// При необходимости можно добавить несколько выражений else if

// По введённому номеру дня недели вывести на экран название этого дня или
// сообщит, что введённое число не корректно

Console.Write("Введите номер дня: ");
int dayIndex = int.Parse(Console.ReadLine());

#region Вариант 1

if (dayIndex == 1)
{
	Console.WriteLine("Понедельник");
}
else
{
	if (dayIndex == 2)
	{
		Console.WriteLine("Вторник");
	}
	else
	{
		if (dayIndex == 3)
		{
			Console.WriteLine("Среда");
		}
		else
		{
			if (dayIndex == 4)
			{
				Console.WriteLine("Четверг");
			}
			else
			{
				if (dayIndex == 5)
				{
					Console.WriteLine("Пятница");
				}
				else
				{
					if (dayIndex == 6)
					{
						Console.WriteLine("Суббота");
					}
					else
					{
						if (dayIndex == 7)
						{
							Console.WriteLine("Воскресенье");
						}
						else
						{
							Console.WriteLine("На планете Земля в неделе семь дней");
						}
					}
				}
			}
		}
	}
}


#endregion

#region Вариант 2

if (dayIndex == 1) Console.WriteLine("Понедельник");
else if (dayIndex == 2) Console.WriteLine("Вторник");
else if (dayIndex == 3) Console.WriteLine("Среда");
else if (dayIndex == 4) Console.WriteLine("Четверг");
else if (dayIndex == 5) Console.WriteLine("Пятница");
else if (dayIndex == 6) Console.WriteLine("Суббота");
else if (dayIndex == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine("На планете Земля в неделе семь дней");

#endregion

// Далее мы узнаем, как эту запись сократить
// На практике так делать не нужно
// Показано для примера if и много else

#endregion

#region switch
// Замена if-else

switch (dayIndex)
{
	case 1:
		Console.WriteLine("Понедельник");
		break;
	case 2:
		Console.WriteLine("Вторник");
		break;
	case 3:
		Console.WriteLine("Среда");
		break;
	case 4:
		Console.WriteLine("Четверг");
		break;
	case 5:
		Console.WriteLine("Пятница");
		break;
	case 6:
		Console.WriteLine("Суббота");
		break;
	case 7:
		Console.WriteLine("Воскресенье");
		break;
	default:
		Console.WriteLine("На планете Земля в неделе семь дней");
		break;
}

// Можно короче
var result = dayIndex switch
{
	1 => "Понедельник",
	2 => "Вторник",
	3 => "Среда",
	4 => "Четверг",
	5 => "Пятница",
	6 => "Суббота",
	7 => "Воскресение",
	_ => "Нет такого дня недели на этой планете" 
};

Console.WriteLine(result);

#endregion

// break и continue
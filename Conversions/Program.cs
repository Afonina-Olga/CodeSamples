#region Тиды данных

// byte от 0 до 255
// ushort от 0 до 65535
// uint от 0 до 2^32-1 >>> от 0 до 4 294 967 296
// ulong от 0 до 2^64-1 >>> от 0 до 18 446 744 073 709 551 616


// sbyte от -128 дo +127
// short от -32768 дo +32767
// int от -2^31 дo +2^31-1 >>> от -2 147 483 648 до +2 147 483 647
// long от -2^63 дo +2^63-1 >>> от -9 223 372 036 854 775 808 до +9 223 372 036 854 775 807

// Тип float принимает значения От от ±5,0 × 10^(−324) до ±1,7 × 10^308 точность - 15 цифр
// Тип double принимает значения От ±1,5 x 10^(−45) до ±3,4 x 10^38 точность - 7 цифр
// Тип decimal принимает значения от ±1,0 x 10^(-28) до ±7,9228 x 10^28 точность - 28 цифр

#endregion

#region Введение в преобразование типов данных

byte b = 100;   // Неявные преобразования
int a = b;      // Всё хорошо

//int i = 10;     //
//byte j = i;     // Ошибка компилятора

double d = a;   // Всё хорошо

//int g = d;      // Ошибка компилятора

#endregion

#region Неявные преобразования

byte byteValue = 1;                 // Задание значения переменной типа byte
short shortValue = byteValue;       // Неявное приведение byte к short
int intValue = shortValue;          // Неявное приведение short к int
long longValue = intValue;          // Неявное приведение int к long
double doubleValue = longValue;     // Неявное приведение long к double

// Не совсем очевидное преобразование
char c = 'я';
int dd = c;
Console.WriteLine(dd);

#endregion

#region Явные преобразования

//int i = 330;    //
//byte j = i;     // Ошибка компилятора

int i = 330;          //
byte j = (byte)i;     // Ошибки компилятора не будет
Console.WriteLine($"j = {j}");

//double d = 1.2;     //
//byte byteValue = d; // Ошибка компилятора

double ddd = 1.2;             //
byte bValue = (byte)ddd;   // Ошибки компилятора не будет


int h = (int)d;

int q = (int)((byte)d);

#endregion

#region Parse

// Преобразует строку в число

//string inputString = "2029";
//int intValue = (int)inputString;     // Ошибка CS0029  
//                                // Не удается неявно преобразовать тип "string" в "int".


string inputString = "2029";
int intValue1 = int.Parse(inputString);
Console.WriteLine(intValue1);                // 2029

double doubleValue1 = double.Parse(inputString);
Console.WriteLine(doubleValue1);             // 2029

ulong ulongValue = ulong.Parse(inputString);
Console.WriteLine(ulongValue);              // 2029

//byte byteValue1 = byte.Parse(inputString);
//Console.WriteLine(byteValue1);              // Необработанное исключение: 
//											// System.OverflowException: Значение было недопустимо 
											// малым или недопустимо большим для беззнакового байта.

#endregion

#region ConvertTo

// Более гибкие преобразования для любых типов данных

string inputString1 = "2029";
//int intValue = int.Parse(inputString1);
int intValue2 = Convert.ToInt32(inputString1);
Console.WriteLine(intValue2);                // 2029

long l = Convert.ToInt32(intValue2);

//double doubleValue = double.Parse(inputString);
double doubleValue2 = Convert.ToDouble(inputString);
Console.WriteLine(doubleValue2);             // 2029

//ulong ulongValue = ulong.Parse(inputString);
ulong ulongValue1 = Convert.ToUInt64(inputString);
Console.WriteLine(ulongValue1);              // 2029

//byte byteValue = byte.Parse(inputString);
//byte byteValue = Convert.ToByte(inputString);
//Console.WriteLine(byteValue);              // Необработанное исключение: 
//                                           // System.OverflowException: Значение было недопустимо 
//                                           // малым или недопустимо большим для беззнакового байта.

#endregion

#region Типы данных и их синонимы

//Тип данных  Тип.NET
//sbyte       System.SByte
//short       System.Int16
//int         System.Int32
//long        System.Int64
//byte        System.SByte
//ushort      System.UInt16
//uint        System.UInt32
//ulong       System.UInt64
//float       System.Single
//double      System.Double
//bool        System.Boolean

#endregion

#region Замечание

/*
В C# допускается указывать, будет ли в коде сгенерировано исключение при 
переполнении, с помощью ключевых слов checked и unchecked. Так, если требуется 
указать, что выражение будет проверяться на переполнение, следует использовать 
ключевое слово checked, а если требуется проигнорировать переполнение — 
ключевое слово unchecked. В последнем случае результат усекается, 
чтобы не выйти за пределы диапазона представления чисел для целевого типа выражения.
*/
checked
{
	var iValue = int.MaxValue;
	byte byteValue3 = (byte)iValue;
	Console.WriteLine(byteValue3);
}

unchecked
{
	byte byteValue4 = (byte)int.MaxValue;
	Console.WriteLine(byteValue4);
}

#endregion
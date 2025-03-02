// See https://aka.ms/new-console-template for more information

/*
Это так называемая программа верхнего уровня (top-level program). А вызов Console.WriteLine("Hello, World!") 
представляет инструкцию вехнего уровня (top-level statement)

Однако в реальности этот код неявно помещается компилятором в метод Main, который, в свою очередь, 
помещается в класс Program. В действительности название класса может быть любым (как правило, 
это класс Program, собственно поэтому генерируемый по умолчанию файл кода называется Program.cs). 
Но метод Main является обязательной частью консольного приложения.
Подробная информация: https://metanit.com/sharp/tutorial/1.4.php
*/
Console.WriteLine("Hello, World!");

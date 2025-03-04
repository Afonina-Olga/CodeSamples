﻿// https://metanit.com/sharp/tutorial/2.6.php
// Циклы являются управляющими конструкциями, позволяя в зависимости от
// определенных условий выполнять некоторое действие множество раз.

#region Цикл for

// Объявление цикла for состоит из трех частей. Первая часть объявления цикла
// - некоторые действия, которые выполняются один раз до выполнения цикла.
// Обычно здесь определяются переменные, которые будут использоваться в цикле.

// Вторая часть - условие, при котором будет выполняться цикл. Пока условие
// равно true, будет выполняться цикл.

// И третья часть - некоторые действия, которые выполняются после завершения
// блока цикла. Эти действия выполняются каждый раз при завершении блока цикла.

// После объявления цикла в фигурных скобках помещаются сами действия цикла.

for (int i = 0; i < 10; i++)
{
	Console.WriteLine(i);
}

// Здесь первая часть объявления цикла - int i = 0 - создает и инициализирует
// переменную i.

// Вторая часть - условие i < 10. То есть пока переменная i меньше 10, будет
// выполняться цикл.

// И третья часть - действия, выполняемые после завершения действий из блока
// цикла - увеличение переменной i на единицу.

// Если блок цикла for содержит одну инструкцию, то мы можем его сократить,
// убрав фигурные свобки

#endregion

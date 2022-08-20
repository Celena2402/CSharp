/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
5 -> Пятница
*/

int dayNumber = new int();
Console.WriteLine("Введите номер дня недели");
dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 1)
{
   Console.WriteLine("Первый день недели - это понедельник"); 
}

else if (dayNumber == 2)
{
   Console.WriteLine("Второй день недели - это вторник"); 
}

else if (dayNumber == 3)
{
   Console.WriteLine("Третий день недели - это среда"); 
}

else if (dayNumber == 4)
{
   Console.WriteLine("Четвертый день недели - это четверг"); 
}

else if (dayNumber == 5)
{
   Console.WriteLine("Пятый день недели - это пятница"); 
}

else if (dayNumber == 6)
{
   Console.WriteLine("Шестой день недели - это суббота"); 
}

else if (dayNumber == 7)
{
   Console.WriteLine("Седьмой день недели - это воскресенье"); 
}

else
{
   Console.WriteLine("Такого дня недели не существует"); 
}

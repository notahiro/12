using System;

class Program
{
    static void Main()
    {
        string message = "Everything's gonna be okay";
        Console.WriteLine(message);

        while (true)
        {
            if (Console.KeyAvailable) // Проверяем, была ли нажата клавиша
            {
                Console.ReadKey(true); // Читаем нажатую клавишу
                Console.WriteLine(message); // Выводим сообщение снова
            }
        }
    }
}

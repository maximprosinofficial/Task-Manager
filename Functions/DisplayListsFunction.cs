namespace Task_Manager.Functions;

using Models;

public class DisplayListsFunction
{
    // Функция позволяющая выводить на экран все текущие задачи
    
    public static void DisplayTasks(List<TaskModel> list)
    {
        if (list.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nСписок задач пуст.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nТекущие задачи:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}. {list[i].Title} - {list[i].Date.ToString("dd.MM.yyyy")} {list[i].Time.ToString("HH:mm")}");
            }
            Console.ResetColor();
        }
    }
    
    //Функция позволяющая выводить на экран все выполненные задачи

    public static void DisplayAsCompletedTasks(List<TaskModel> list)
    {
        if (list.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nСписок выполненных задач пуст");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nВыполненные задачи:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(
                    $"\n{i + 1}. {list[i].Title} - {list[i].Date.ToString("dd.MM.yyyy")} {list[i].Time.ToString("HH:mm")}");
            }

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nВыберите действие: \n1. Очистить список \n2. Выйти в главное меню\n");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    list.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nВы очистили список выполненных задач");
                    Console.ResetColor();
                    break;
                case "2": break;
            }
        }
    }

    // Функция позволяющая выводить на экран все удаленные задачи
    
    public static void DisplayAsDeletedTasks(List<TaskModel> list) 
    {
        if (list.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nСписок удаленных задач пуст");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nУдаленные задачи");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}. {list[i].Title} - {list[i].Date.ToString("dd.MM.yyyy")} {list[i].Time.ToString("HH:mm")}");
            }
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nВыберите действие: \n1. Очистить список \n2. Выйти в главное меню\n");
            Console.ResetColor();
            
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": list.Clear(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\nВы очистили список удаленных задач"); Console.ResetColor(); break;
                case "2": break;
            }
        }
    }
}
using System;
using System.Collections.Generic;

class TaskManager
{
    static List<string> tasks = new List<string>();
    static List<string> tasksAsCompleted = new List<string>();
    static List<string> tasksAsDeleted = new List<string>();

    static void Main()
    {
        Console.WriteLine(@"
``_____`````````_``````__``__``````````````````````````` ```````` 
`|_```_|_`_`___|`|`__`|``\/``|`__`_`_`__```__`_` `__`_``___`_`__` 
```|`|/`_``/`__|`|/`/`|`|\/|`|/`_``|`'_ `\`/`_``|/`_``|/`_`\`'__| 
```|`|`(_|`\__`\```<``|`|``|`|`(_|`|`|`|`|`(_|`|`(_ |`|``__/`|``` 
```|_|\__,_|___/_|\_\`|_|``|_|\__,_|_|`|_| \__,_|\__,`|\___|_|``` ` 
````````````````````````````````` ````````````````|___/```````````            
");
        Console.WriteLine("Разработчик: x1mhp.sys");
        Console.WriteLine("Нажмите любую клавишу для продолжения");

        Console.ReadKey();

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Просмотреть текущие задачи");
            Console.WriteLine("3. Отметить задачу как выполненную");
            Console.WriteLine("4. Удалить задачу");
            Console.WriteLine("5. Посмотреть выполненные задачи");
            Console.WriteLine("6. Посмотреть удаленные задачи");
            Console.WriteLine("7. Выйти\n");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    DisplayTasks();
                    break;
                case "3":
                    MarkTaskAsComplete();
                    break;
                case "4":
                    RemoveTask();
                    break;
                case "5":
                    DisplayAsCompletedTasks();
                    break;
                case "6":
                    DisplayAsDeletedTasks();
                    break;
                case "7":
                    Console.WriteLine("\nСпасибо за использование Task Manager!");
                    Console.WriteLine(@"
`````````_```````````_```````````````````````````` 
```__``_/`|_`__`___`|`|__``_`__```___`_```_`___```
``\`\/`/` |`'_```_`\|`'_`\|`'_`\`/`__|`|`|`/`__|``
```>``<|`|` |`|`|`|`|`|`|`|`|_)`|\__`\`|_|`\__`\`` 
```/_/\_\_|_|`|_|`|_|_|`|_|`.__(_)___/\__,`|___/``
``` ````````````````````|_|`````````|___/`````````       
");
                    Thread.Sleep(3000);
                    return;
                case "02042008":
                    Console.WriteLine("\nПривет от разработчика");
                    break;
                default:
                    Console.WriteLine("\nНекорректный ввод. Повторите попытку.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("\nВведите новую задачу: ");
        string newTask = Console.ReadLine();
        tasks.Add(newTask);
        Console.WriteLine("\nЗадача успешно добавлена");
    }

    static void DisplayTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("\nСписок задач пуст.");
        }
        else
        {
            Console.WriteLine("\nТекущие задачи:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}. {tasks[i]}");
            }
        }
    }

    static void MarkTaskAsComplete()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("\nСписок задач пуст. Добавьте новую задачу.");
        }
        else
        {
            DisplayTasks();
            Console.Write("\nВведите номер задачи для отметки как выполненной: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasksAsCompleted.Add(tasks[taskNumber - 1]);
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("\nЗадача успешно отмечена как выполненная.");
            }
            else
            {
                Console.WriteLine("\nНекорректный номер задачи. Повторите попытку.");
            }
        }
    }

    static void RemoveTask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("\nСписок задач пуст. Добавьте новую задачу.");
        }
        else
        {
            DisplayTasks();
            Console.Write("\nВведите номер задачи для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasksAsDeleted.Add(tasks[taskNumber - 1]);
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("\nЗадача успешно удалена.");
            }
            else
            {
                Console.WriteLine("\nНекорректный номер задачи. Повторите попытку.");
            }
        }
    }

    static void DisplayAsCompletedTasks()
    {
        if (tasksAsCompleted.Count == 0)
        {
            Console.WriteLine("\nСписок выполненных задач пуст");
        }
        else
        {
            Console.WriteLine("\nВыполненные задачи:");
            for (int i = 0; i < tasksAsCompleted.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}. {tasksAsCompleted[i]}");
            }
            
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Очистить список");
            Console.WriteLine("2. Выйти в главное меню\n");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    tasksAsCompleted.Clear();
                    Console.WriteLine("\nВы очистили список выполненных задач");
                    break;
                case "2":
                    break;
            }
        }
        
        
    }
    
    static void DisplayAsDeletedTasks() 
    {
        if (tasksAsDeleted.Count == 0)
        {
            Console.WriteLine("\nСписок удаленных задач пуст");
        }
        else
        {
            Console.WriteLine("\nУдаленные задачи");
            for (int i = 0; i < tasksAsDeleted.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}. {tasksAsDeleted[i]}");
            }
            
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Очистить список");
            Console.WriteLine("2. Выйти в главное меню\n");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    tasksAsCompleted.Clear();
                    Console.WriteLine("\nВы очистили список удаленных задач");
                    break;
                case "2":
                    break;
            }
        }
    }
}
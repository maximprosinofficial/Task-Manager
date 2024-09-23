using Task_Manager.Models;
using Task_Manager.Functions;

class TaskManager
{
    static List<TaskModel> _tasks = new List<TaskModel>();
    static List<TaskModel> _tasksAsCompleted = new List<TaskModel>();
    static List<TaskModel> _tasksAsDeleted = new List<TaskModel>();

    static void Main()
    {
        Console.Title = "Task Manager | x1mhp.sys";
        Console.ForegroundColor = ConsoleColor.Green;
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
        
        Console.ResetColor();

        Console.ReadKey();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nВыберите действие: \n1. Добавить задачу \n2. Просмотреть текущие задачи \n3. Отметить задачу как выполненную \n4. Удалить задачу \n5. Посмотреть выполненные задачи \n6. Посмотреть удаленные задачи \n7. Выйти\n");
            Console.ResetColor();
            
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": AddTaskFunction.AddTask(_tasks); break;
                case "2": DisplayListsFunction.DisplayTasks(_tasks); break;
                case "3": MarkTaskAsCompleteFunction.MarkTaskAsComplete(_tasks, _tasksAsCompleted); break;
                case "4": DeleteTaskFunction.DeleteTask(_tasks, _tasksAsDeleted); break;
                case "5": DisplayListsFunction.DisplayAsCompletedTasks(_tasksAsCompleted); break;
                case "6": DisplayListsFunction.DisplayAsDeletedTasks(_tasksAsDeleted); break;
                case "7": Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nСпасибо за использование Task Manager!");
                    Console.WriteLine(@"
`````````_```````````_```````````````````````````` 
```__``_/`|_`__`___`|`|__``_`__```___`_```_`___```
``\`\/`/` |`'_```_`\|`'_`\|`'_`\`/`__|`|`|`/`__|``
```>``<|`|` |`|`|`|`|`|`|`|`|_)`|\__`\`|_|`\__`\`` 
```/_/\_\_|_|`|_|`|_|_|`|_|`.__(_)___/\__,`|___/``
``` ````````````````````|_|`````````|___/`````````       
");
                    Thread.Sleep(3000); return;
                default: Console.WriteLine("\nНекорректный ввод. Повторите попытку."); break;
            }
        }
    }
}
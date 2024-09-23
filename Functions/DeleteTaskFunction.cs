using Task_Manager.Models;

namespace Task_Manager.Functions;

public class DeleteTaskFunction
{
    public static void DeleteTask(List<TaskModel> list, List<TaskModel> resultList)
    {
        if (list.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nСписок задач пуст. Добавьте новую задачу.");
            Console.ResetColor();
        }
        else
        {
            DisplayListsFunction.DisplayTasks(list);
            Console.Write("\nВведите номер задачи для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= list.Count)
            {
                resultList.Add(list[taskNumber - 1]);
                list.RemoveAt(taskNumber - 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nЗадача успешно удалена.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nНекорректный номер задачи. Повторите попытку.");
                Console.ResetColor();
            }
        }
    }
}
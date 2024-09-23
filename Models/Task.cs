namespace Task_Manager.Models;

public class TaskModel
{
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }

    public TaskModel(string title, DateTime date, DateTime time)
    {
        Title = title;
        Date = date;
        Time = time;
    }
}
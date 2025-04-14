using DataBaseLibrary; 

namespace TaskLibrary
{
    public class TaskService
    {
        public static bool CreateTask(string title, string description, int assigneeId, int creatorId)
        {
            try
            {
                // Подготовка данных для вставки
                var columnValues = new Dictionary<string, object>
                {
                    { "title", title },
                    { "description", description },
                    { "priority", "Medium" }, // Задаем значение по умолчанию для приоритета
                    { "assignee_id", assigneeId },
                    { "creator_id", creatorId }
                };

                // Вставляем данные в таблицу tasks
                bool success = DataBaseService.Add("tasks", columnValues);

                return success;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при создании задачи: " + ex.Message);
                return false;
            }
        }
    }
}
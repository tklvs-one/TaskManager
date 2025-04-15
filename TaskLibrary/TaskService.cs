using DataBaseLibrary; 

namespace TaskLibrary
{
    public class TaskService
    {
        public static bool CreateTask(string title, string description, int assigneeId, int creatorId, string priority)
        {
            try
            {
                // Подготовка данных для вставки
                var columnValues = new Dictionary<string, object>
                {
                    { "title", title },
                    { "description", description },
                    { "priority", priority }, // Задаем значение по умолчанию для приоритета
                    { "assignee_id", assigneeId },
                    { "creator_id", creatorId },
                    { "status", "В работе" }
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
        public static List<Dictionary<string, object>> GetTasksByCreator(int creatorId)
        {
            // Получаем все задачи, созданные этим менеджером
            return DataBaseService.Select("tasks", new List<string> { "id", "title", "description", "priority", "status", "assignee_id" }, "creator_id", creatorId);
        }

        public static bool DeleteTask(int taskId)
        {
            try
            {
                // Используем универсальный метод Delete для удаления задачи
                return DataBaseService.Delete("tasks", "id", taskId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при удалении задачи: " + ex.Message);
                return false;
            }
        }

    }
}
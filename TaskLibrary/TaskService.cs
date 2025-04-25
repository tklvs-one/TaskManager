using DataBaseLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using DataBaseLibrary; // Для работы с БД


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

        public static bool ChangeTaskStatus(int taskId, string newStatus)
        {
            try
            {
                var columnValues = new Dictionary<string, object>
                {
                    { "status", newStatus }
                };

                return DataBaseService.Update("tasks", columnValues, "id", taskId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при изменении статуса задачи: " + ex.Message);
                return false;
            }
        }


    }
}
using Npgsql;

namespace DataBaseLibrary
{
    public static class DataBaseService
    {
        // Строка подключения к базе данных
        private static string connectionString = "Host=localhost;Username=postgres;Password=123;Database=task_manage";

        // Универсальный метод для добавления данных в таблицу
        public static bool Add(string tableName, Dictionary<string, object> columnValues)
        {
            try
            {
                if (string.IsNullOrEmpty(tableName) || columnValues == null || columnValues.Count == 0)
                {
                    Console.WriteLine("Не переданы корректные параметры.");
                    return false;
                }

                // Формируем SQL запрос для вставки данных
                string columns = string.Join(", ", columnValues.Keys);
                string values = string.Join(", ", columnValues.Keys.Select(key => $"@{key}"));

                string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Добавляем параметры в команду
                        foreach (var kvp in columnValues)
                        {
                            cmd.Parameters.AddWithValue(kvp.Key, kvp.Value ?? DBNull.Value);
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при добавлении данных: " + ex.Message);
                return false;
            }
        }

        // Метод для удаления записи из таблицы
        public static bool Delete(string tableName, string whereColumn, object whereValue)
        {
            try
            {
                if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(whereColumn) || whereValue == null)
                {
                    Console.WriteLine("Не переданы корректные параметры.");
                    return false;
                }

                // Формируем SQL запрос для удаления записи
                string query = $"DELETE FROM {tableName} WHERE {whereColumn} = @{whereColumn}";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Добавляем параметр для WHERE условия
                        cmd.Parameters.AddWithValue(whereColumn, whereValue);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при удалении данных: " + ex.Message);
                return false;
            }
        }

        // Метод для обновления записи в таблице
        public static bool Update(string tableName, Dictionary<string, object> columnValues, string whereColumn, object whereValue)
        {
            try
            {
                if (string.IsNullOrEmpty(tableName) || columnValues == null || columnValues.Count == 0 || string.IsNullOrEmpty(whereColumn) || whereValue == null)
                {
                    Console.WriteLine("Не переданы корректные параметры.");
                    return false;
                }


                string setClause = string.Join(", ", columnValues.Keys.Select(key => $"{key} = @{key}"));
                string query = $"UPDATE {tableName} SET {setClause} WHERE {whereColumn} = @{whereColumn}";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Добавляем параметры для SET
                        foreach (var kvp in columnValues)
                        {
                            cmd.Parameters.AddWithValue(kvp.Key, kvp.Value ?? DBNull.Value);
                        }

                        // Добавляем параметр для WHERE условия
                        cmd.Parameters.AddWithValue(whereColumn, whereValue);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при обновлении данных: " + ex.Message);
                return false;
            }
        }

        // Универсальный метод для выборки данных из таблицы
        public static List<Dictionary<string, object>> Select(
            string tableName,
            List<string> columns = null,
            string whereColumn = null,
            object whereValue = null,
            string orderBy = null)
        {
            try
            {
                if (string.IsNullOrEmpty(tableName))
                {
                    Console.WriteLine("Не передано имя таблицы.");
                    return null;
                }

                // Формируем список колонок для SELECT
                string columnsPart = columns != null && columns.Count > 0
                    ? string.Join(", ", columns)
                    : "*";  // Если колонки не указаны, выбираем все

                // Формируем строку WHERE (если передано условие)
                string wherePart = string.IsNullOrEmpty(whereColumn)
                    ? ""
                    : $"WHERE {whereColumn} = @{whereColumn}";

                // Формируем строку ORDER BY (если нужно сортировать)
                string orderByPart = string.IsNullOrEmpty(orderBy) ? "" : $"ORDER BY {orderBy}";

                // Формируем окончательный запрос
                string query = $"SELECT {columnsPart} FROM {tableName} {wherePart} {orderByPart}";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Если есть условие для WHERE, добавляем параметры
                        if (!string.IsNullOrEmpty(whereColumn))
                        {
                            cmd.Parameters.AddWithValue(whereColumn, whereValue ?? DBNull.Value);
                        }

                        // Выполняем запрос и читаем результаты
                        var resultList = new List<Dictionary<string, object>>();

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var row = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[reader.GetName(i)] = reader.GetValue(i);
                                }
                                resultList.Add(row);
                            }
                        }

                        return resultList;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при выборке данных: " + ex.Message);
                return null;
            }
        }

        public static List<Dictionary<string, object>> GetFilteredTasksByCreator(int creatorId, string priorityCondition, string statusCondition, int? assigneeId = null)
        {
            try
            {
                // Начальный SQL запрос
                string query = "SELECT * FROM tasks WHERE creator_id = @creatorId";

                // Добавляем условия фильтрации, если они переданы
                if (!string.IsNullOrEmpty(priorityCondition))
                {
                    query += " AND priority = @priority";
                }

                if (!string.IsNullOrEmpty(statusCondition))
                {
                    query += " AND status = @status";
                }

                // Фильтрация по исполнителю, если передан ID исполнителя
                if (assigneeId.HasValue)
                {
                    query += " AND assignee_id = @assigneeId";
                }

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Добавляем параметры для фильтров
                        cmd.Parameters.AddWithValue("creatorId", creatorId);

                        if (!string.IsNullOrEmpty(priorityCondition))
                        {
                            cmd.Parameters.AddWithValue("priority", priorityCondition);
                        }

                        if (!string.IsNullOrEmpty(statusCondition))
                        {
                            cmd.Parameters.AddWithValue("status", statusCondition);
                        }

                        if (assigneeId.HasValue)
                        {
                            cmd.Parameters.AddWithValue("assigneeId", assigneeId.Value);
                        }

                        // Выполняем запрос и получаем результаты
                        var result = new List<Dictionary<string, object>>();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var row = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[reader.GetName(i)] = reader.GetValue(i);
                                }
                                result.Add(row);
                            }
                        }

                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при фильтрации задач: " + ex.Message);
                return null;
            }
        }

        public static List<Dictionary<string, object>> GetTasksByAssignee(int assigneeId, params string[] statuses)
        {
            try
            {
                string query = "SELECT * FROM tasks WHERE assignee_id = @assigneeId";

                if (statuses != null && statuses.Length > 0)
                {
                    string formattedStatuses = string.Join("','", statuses);
                    query += $" AND status IN ('{formattedStatuses}')";
                }

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("assigneeId", assigneeId);

                        var result = new List<Dictionary<string, object>>();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var row = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[reader.GetName(i)] = reader.GetValue(i);
                                }
                                result.Add(row);
                            }
                        }

                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при получении задач по исполнителю: " + ex.Message);
                return new List<Dictionary<string, object>>();
            }
        }


    }
}
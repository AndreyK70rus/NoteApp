using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.IO;


namespace NoteApp

{
    /// <summary>
    /// Класс ProjectManager с модификатором доступа Public. Реализует метод для сохранения объекта «Проект» в файл и 
    /// метод загрузки проекта из файла.
    /// </summary>
    public static class ProjectManager
    {

        public static string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/NoteApp.notes";

        public static void Save(Project project, string filePath) // Cериализация.
        {
            // Создаем экземпляр сериализатора.
            JsonSerializer serializer = new JsonSerializer()
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include
            };
            // Создаем поток для записи в файл с указанием пути.
            using (StreamWriter sw = new StreamWriter(filePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                // Вызываем сериализацию и передаем объект, который хотим сериализовать.
                serializer.Serialize(writer, project);
            }
        }

        public static Project Load(Project LoadNote, string filePath) // Десериализация.
        {
            // Создаём переменную, в которую поместим результат десериализации.
            LoadNote = null;
            // Создаем экхемпляр сериализатора.
            JsonSerializer serializer = new JsonSerializer()
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include
            };
            try
            {
                // Открываем поток для чтения из файла с указанием пути.
                using (StreamReader sr = new StreamReader(filePath))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    // Вызываем десериализацию и явно преобразуем результат в целевой тип данных.
                    var deserializedObject = serializer.Deserialize(reader);
                    LoadNote = (Project)deserializedObject;
                }
            }
            catch (Exception)
            {
                LoadNote = new Project();
            }
            if (LoadNote == null)
                LoadNote = new Project();
            return LoadNote;
        }
    }
}
    





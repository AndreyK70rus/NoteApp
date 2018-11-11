using System;
using System.Collections.Generic;
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

        private const string _FileSave = @"C:\Users\Андрей Калинин\Documents\NoteApp.notes";

        public static void Save(Project S1) // Cериализация.
        {
            // Создаем экземпляр сериализатора.
            JsonSerializer serializer = new JsonSerializer()
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include
            };
            // Создаем поток для записи в файл с указанием пути.
            using (StreamWriter sw = new StreamWriter(_FileSave))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                // Вызываем сериализацию и передаем объект, который хотим сериализовать.
                serializer.Serialize(writer, S1);
            }
        }

        public static Project Download() // Десериализация.
        {
            // Создаём переменную, в которую поместим результат десериализации.
            Project S1 = null;
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
                using (StreamReader sr = new StreamReader(_FileSave))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    // Вызываем десериализацию и явно преобразуем результат в целевой тип данных.
                    var deserializedObject = serializer.Deserialize(reader);
                    S1 = (Project)deserializedObject;
                    }
            }
            catch (Exception)
            {
                S1 = new Project();
            }
            if (S1 == null)
                S1 = new Project();
            return S1;
        }

    }

}




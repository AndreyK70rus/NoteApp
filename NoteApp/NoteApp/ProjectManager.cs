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
        public static void Save(Project S1) //сериализация
        {
            JsonSerializer serializer = new JsonSerializer()
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include
            };
            using (StreamWriter sw = new StreamWriter(_FileSave))
            using (JsonWriter writer = new JsonTextWriter(sw))

                serializer.Serialize(writer, S1);
        }

        public static Project Download() //десериализация
        {
            Project S1 = null;
            JsonSerializer serializer = new JsonSerializer()
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include
            };
            try
            {
                using (StreamReader sr = new StreamReader(_FileSave))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    var deserializedObject = serializer.Deserialize(reader);
                    S1 = (Project)deserializedObject;
                }
            }
            catch (Exception e)
            {
                S1 = new Project();
            }
            if (S1 == null)
                S1 = new Project();
            return S1;
        }
    }
}




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
    public class ProjectManager
    {

    
        private const string _file_save = @"C:\Users\Андрей Калинин\Documents\NoteApp.notes";
        public void Save(Project S1) // сериализация
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(_file_save))
            using (JsonWriter writer = new JsonTextWriter(sw))
        
         serializer.Serialize(writer, S1);
        }
        public Project Download ()// десериализация
        {
            Project S1 = null;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(_file_save))
            using (JsonReader reader = new JsonTextReader(sr))
                S1 = (Project)serializer.Deserialize(reader);
            return S1;
        }

    }

}

    


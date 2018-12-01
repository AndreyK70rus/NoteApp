using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;
using System.IO;

namespace NoteApp.UnitTexts
{
    [TestFixture]
    public class ProjectTest
    {
        Project project = new Project();
        Note note1 = new Note();
        Note note2 = new Note();

        [Test(Description = "Тест на добавление заметок в массив заметок Project")]
        public void testProject()
        {
            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
            "/source/repos/NoteApp/NoteApp/NoteApp.UnitTests/testProject.xml";
            note1.Title = "Первая заметка";
            note1.CategoryNote = NoteCategory.People;
            note1.TextNote = "Тест для проверки метода сериализации. Создание первой заметки";
            note1.CreationTime = new DateTime(2016, 04, 28);
            note1.LastChangeTime = DateTime.Today;
            project.NotesCollection.Add(note1);
            note2.Title = "Вторая заметка";
            note2.CategoryNote = NoteCategory.Work;
            note2.TextNote = "Тест для проверки метода сериализации. Создание второй заметки";
            note2.CreationTime = new DateTime(2015, 07, 18);
            note2.LastChangeTime = DateTime.Today;
            project.NotesCollection.Add(note2);
            ProjectManager.Save(project, FilePath);
        }

    }
}

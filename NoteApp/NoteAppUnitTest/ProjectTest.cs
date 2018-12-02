using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTexts
{
    [TestFixture]
    public class ProjectTest
    {
         [Test(Description = "Тест для добавления земеток в массив заметок Project")]
         public void ProjectTest_addNote()
         {
            Note note1 = new Note();
            Note note2 = new Note();
            Note note3 = new Note();
            Project project = new Project();

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
            "/source/repos/NoteApp/NoteApp/NoteAppUnitTest/testProject.xml";

            note1.Title = "Название первой заметки";
            note1.CategoryNote = NoteCategory.Work;
            note1.TextNote = "Текст заметки";
            note1.CreationTime = new DateTime(2016, 07, 25);
            note1.LastChangeTime = new DateTime(2017, 07, 25);
            project.NotesCollection.Add(note1);

            note2.Title = "Название второй заметки";
            note2.CategoryNote = NoteCategory.People;
            note2.TextNote = "Текст заметки";
            note2.CreationTime = new DateTime(2014, 07, 25);
            note2.LastChangeTime = new DateTime(2018, 07, 25);
            project.NotesCollection.Add(note2);

            note3.Title = "Название третьей заметки";
            note3.CategoryNote = NoteCategory.Another;
            note3.TextNote = "Текст заметки";
            note3.CreationTime = new DateTime(2015, 07, 25);
            note3.LastChangeTime = new DateTime(2017, 05, 25);
            project.NotesCollection.Add(note3);

            ProjectManager.Save(project, filePath);
        }
    }
}


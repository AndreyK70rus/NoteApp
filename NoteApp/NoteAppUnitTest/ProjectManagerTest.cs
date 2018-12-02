using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;

namespace NoteAppUnitTest
{
    [TestFixture]
    class ProjectManagerTest
    {
        [Test(Description = "Тест для проверки десериализации")]
        public void DeserializerTest()
        {
            Note note1 = new Note();
            Note note2 = new Note();
            Note note3 = new Note();
            Project expectedProject = new Project();
            Project actualProject = new Project();

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
            "/source/repos/NoteApp/NoteApp/NoteAppUnitTest/testProject.xml";

            note1.Title = "Название первой заметки";
            note1.CategoryNote = NoteCategory.Work;
            note1.TextNote = "Текст заметки";
            note1.CreationTime = new DateTime(2016, 07, 25);
            note1.LastChangeTime = new DateTime(2017, 07, 25);
            expectedProject.NotesCollection.Add(note1);

            note2.Title = "Название второй заметки";
            note2.CategoryNote = NoteCategory.People;
            note2.TextNote = "Текст заметки";
            note2.CreationTime = new DateTime(2014, 07, 25);
            note2.LastChangeTime = new DateTime(2018, 07, 25);
            expectedProject.NotesCollection.Add(note2);

            note3.Title = "Название третьей заметки";
            note3.CategoryNote = NoteCategory.Another;
            note3.TextNote = "Текст заметки";
            note3.CreationTime = new DateTime(2015, 07, 25);
            note3.LastChangeTime = new DateTime(2017, 05, 25);
            expectedProject.NotesCollection.Add(note3);

            actualProject = ProjectManager.Load(actualProject, filePath);

            Assert.AreEqual(expectedProject.NotesCollection.Count, actualProject.NotesCollection.Count);
            Assert.AreEqual(expectedProject.NotesCollection[0].Title, actualProject.NotesCollection[0].Title);
            Assert.AreEqual(expectedProject.NotesCollection[0].CategoryNote, actualProject.NotesCollection[0].CategoryNote);
            Assert.AreEqual(expectedProject.NotesCollection[0].TextNote, actualProject.NotesCollection[0].TextNote);
            Assert.AreEqual(expectedProject.NotesCollection[0].CreationTime, actualProject.NotesCollection[0].CreationTime);
            Assert.AreEqual(expectedProject.NotesCollection[0].LastChangeTime, actualProject.NotesCollection[0].LastChangeTime);

            Assert.AreEqual(expectedProject.NotesCollection[1].Title, actualProject.NotesCollection[1].Title);
            Assert.AreEqual(expectedProject.NotesCollection[1].CategoryNote, actualProject.NotesCollection[1].CategoryNote);
            Assert.AreEqual(expectedProject.NotesCollection[1].TextNote, actualProject.NotesCollection[1].TextNote);
            Assert.AreEqual(expectedProject.NotesCollection[1].CreationTime, actualProject.NotesCollection[1].CreationTime);
            Assert.AreEqual(expectedProject.NotesCollection[1].LastChangeTime, actualProject.NotesCollection[1].LastChangeTime);

            Assert.AreEqual(expectedProject.NotesCollection[2].Title, actualProject.NotesCollection[2].Title);
            Assert.AreEqual(expectedProject.NotesCollection[2].CategoryNote, actualProject.NotesCollection[2].CategoryNote);
            Assert.AreEqual(expectedProject.NotesCollection[2].TextNote, actualProject.NotesCollection[2].TextNote);
            Assert.AreEqual(expectedProject.NotesCollection[2].CreationTime, actualProject.NotesCollection[2].CreationTime);
            Assert.AreEqual(expectedProject.NotesCollection[2].LastChangeTime, actualProject.NotesCollection[2].LastChangeTime);
        }

        [Test(Description = "Тест для проверки сериализации")]
        public void SerializerTest()
        {
            Note note1 = new Note();
            Note note2 = new Note();
            Note note3 = new Note();
            Project expectedProject = new Project();
            Project actualProject = new Project();

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
            "/source/repos/NoteApp/NoteApp/NoteAppUnitTest/testSerializer.xml";

            note1.Title = "Название первой заметки для сериализации";
            note1.CategoryNote = NoteCategory.Work;
            note1.TextNote = "Текст заметки";
            note1.CreationTime = new DateTime(2016, 07, 25);
            note1.LastChangeTime = new DateTime(2017, 07, 25);
            expectedProject.NotesCollection.Add(note1);

            note2.Title = "Название второй заметки для сериализации";
            note2.CategoryNote = NoteCategory.People;
            note2.TextNote = "Текст заметки";
            note2.CreationTime = new DateTime(2014, 07, 25);
            note2.LastChangeTime = new DateTime(2018, 07, 25);
            expectedProject.NotesCollection.Add(note2);

            note3.Title = "Название третьей заметки для сериализации";
            note3.CategoryNote = NoteCategory.Another;
            note3.TextNote = "Текст заметки";
            note3.CreationTime = new DateTime(2015, 07, 25);
            note3.LastChangeTime = new DateTime(2017, 05, 25);
            expectedProject.NotesCollection.Add(note3);

            ProjectManager.Save(expectedProject, filePath);
            actualProject = ProjectManager.Load(actualProject, filePath);

            Assert.AreEqual(expectedProject.NotesCollection.Count, actualProject.NotesCollection.Count);
            Assert.AreEqual(expectedProject.NotesCollection[0].Title, actualProject.NotesCollection[0].Title);
            Assert.AreEqual(expectedProject.NotesCollection[0].CategoryNote, actualProject.NotesCollection[0].CategoryNote);
            Assert.AreEqual(expectedProject.NotesCollection[0].TextNote, actualProject.NotesCollection[0].TextNote);
            Assert.AreEqual(expectedProject.NotesCollection[0].CreationTime, actualProject.NotesCollection[0].CreationTime);
            Assert.AreEqual(expectedProject.NotesCollection[0].LastChangeTime, actualProject.NotesCollection[0].LastChangeTime);

            Assert.AreEqual(expectedProject.NotesCollection[1].Title, actualProject.NotesCollection[1].Title);
            Assert.AreEqual(expectedProject.NotesCollection[1].CategoryNote, actualProject.NotesCollection[1].CategoryNote);
            Assert.AreEqual(expectedProject.NotesCollection[1].TextNote, actualProject.NotesCollection[1].TextNote);
            Assert.AreEqual(expectedProject.NotesCollection[1].CreationTime, actualProject.NotesCollection[1].CreationTime);
            Assert.AreEqual(expectedProject.NotesCollection[1].LastChangeTime, actualProject.NotesCollection[1].LastChangeTime);

            Assert.AreEqual(expectedProject.NotesCollection[2].Title, actualProject.NotesCollection[2].Title);
            Assert.AreEqual(expectedProject.NotesCollection[2].CategoryNote, actualProject.NotesCollection[2].CategoryNote);
            Assert.AreEqual(expectedProject.NotesCollection[2].TextNote, actualProject.NotesCollection[2].TextNote);
            Assert.AreEqual(expectedProject.NotesCollection[2].CreationTime, actualProject.NotesCollection[2].CreationTime);
            Assert.AreEqual(expectedProject.NotesCollection[2].LastChangeTime, actualProject.NotesCollection[2].LastChangeTime);
        }
    }
}

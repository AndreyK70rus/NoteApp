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
    public class ProjectManagerTest
    {
        private Note _note;
        private Project _project;

        [SetUp]
        public void InitSetUp()
        {
            _note = new Note();
            _project = new Project();
        }

        [Test(Description = "Тест для проверки сериализации")]
        public void TestSerializer()
        {
            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
            "/source/repos/NoteApp/NoteApp/NoteApp.UnitTexts/TextFile1.txt";
            _note.Title = "Добрый тест";
            _note.CategoryNote = NoteCategory.Finance;
            _note.TextNote = "Тест надеюсь что будет работать, но в этом никто не уверен, остается только надеяться";
            _note.CreationTime = new DateTime(2015,09,09);
            _note.LastChangeTime = DateTime.Now;

            _project.NotesCollection.Add(_note);
            StreamWriter sw;
            FileInfo fi = new FileInfo(FilePath);
            sw = fi.AppendText();
            foreach (var List in _project.NotesCollection)
            {
                sw.WriteLine(List.Title);
                sw.WriteLine(List.CategoryNote);
                sw.WriteLine(List.TextNote);
                sw.WriteLine(List.CreationTime);
                sw.WriteLine(List.LastChangeTime);
            }
            sw.Close();
            StreamReader sr;
            FileInfo fileInfo = new FileInfo(FilePath);
            sr = fi.OpenText();
            foreach(var List in _project.NotesCollection)
            {
                sr.Equals(List.Title);
                sr.Equals(List.CategoryNote);
                sr.Equals(List.TextNote);
                sr.Equals(List.CreationTime);
                sr.Equals(List.LastChangeTime);
            }
            sr.Close();
        }
    }
}

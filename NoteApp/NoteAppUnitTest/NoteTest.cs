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
    public class NoteTest
    {
        private Note _note;

        [SetUp]
        public void InitNote()
        {
            _note = new Note();
        }

        [Test(Description = "Присвоение названия больше 50 сиволов")]
        public void TestTitleSet_Longer50Symbols()
        {
            var wrongTitle = "Самое длинное название, которое возможно было бы придумать. Проверка для теста.";
            Assert.Throws<ArgumentException>(() => { _note.Title = wrongTitle; });
        }

        [Test(Description = "Позитивный тест геттера Title")]
        public void TestTitleGet_CorrectValue()
        {
            var expected = "Новый смартфон Oneplus 7";
            _note.Title = expected;
            var actual = _note.Title;
            Assert.AreEqual(expected, actual, "Геттер возвращает неправильное название");
        }

        [Test(Description = "Позитивный тест для сеттера Title")]
        public void TestTitleSet_correctValue()
        {
            var expected = "Умный дом";
            _note.Title = expected;
        }

        [Test(Description = "Позитивный тест для геттера TextNote")]
        public void TestTextNoteGet_CorrectValue()
        {
            var expected = "Тест для проверки. Пишу различные символы 4235а57/*213/ъ/";
            _note.TextNote = expected;
            var actual = _note.TextNote;
            Assert.AreEqual(expected, actual, "Метод геттер возвращает неправильное значение");
        }

        [Test(Description = "Позитивный тест для сеттера TextNote")]
        public void TextTextNoteSet_CorrectValue()
        {
            var expected = "Необходимо проверить на содержание различных символов и большого размера." +
                " йцукенгшщзхъ/*-+эждлорпавыфячсмитьбю.фывапролджэ1234567890-=";
            _note.TextNote = expected;
        }

        [Test(Description = "Ввод некорректной даты в сеттер CreationTime")]
        public void TestCreationTimeSet_ArgumentExeption()
        {
            var expected = new DateTime(2020, 03, 05);
            Assert.Throws<ArgumentException>(() => { _note.CreationTime = expected; });
        }

        [Test(Description = "Ввод корректной даты в сеттер CreationTime")]
        public void TestCreationTimeSet_correctValue()
        {
            var expected = new DateTime(2015, 03, 05);
            _note.CreationTime = expected;       
        }

        [Test(Description = "Позитивный тест для геттера CreationTime")]
        public void TestCreationTimeGet_CorrectValue()
        {
            var expected = new DateTime(2018, 11, 28);
            _note.CreationTime = expected;
            var actual = _note.CreationTime;
            Assert.AreEqual(expected, actual, "Метод геттер возвращает неправильное значение");
        }

        [Test(Description = "Ввод корректной даты в сеттер LastChangeTime")]
        public void TestLastChangeTimeSet_correctValue()
        {
            var expected = new DateTime(2016, 10, 10);
            _note.LastChangeTime = expected;
        }

        [Test(Description = "Ввод некорректной даты в сеттер LastChangeTime - меньше текущей даты")]
        public void TestLastChangeTimeSet_ArgumentExeption()
        {
            var expected = new DateTime(2019, 10, 10);
            Assert.Throws<ArgumentException>(() => { _note.LastChangeTime = expected; });
        }

        [Test(Description = "Ввод некорректной даты в сеттер LastChangeTime - больше даты создания")]
        public void TestLastChangeTime2Set_ArgumentExeption()
        {
            _note.CreationTime = new DateTime(2015, 10, 9);
            var wrongLastChangeTime = new DateTime(2017, 9, 9);
            Assert.Throws<ArgumentException>(() => { _note.LastChangeTime = wrongLastChangeTime; });
        }

        [Test(Description = "Позитивный тест для геттера lastChangeTime")]
        public void TestLastChangeTimeGet_CorrectValue()
        {
            var expected = new DateTime(2018, 11, 28);
            _note.LastChangeTime = expected;
            var actual = _note.LastChangeTime;
            Assert.AreEqual(expected, actual, "Метод геттер возвращает неправильное значение");
        }
    }
}
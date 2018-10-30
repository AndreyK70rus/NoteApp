using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NoteApp
{
    /// <summary>
    /// Класс project с модификатором доступа public. Содержит список всех заметок, созданных в прило-жении.
    /// </summary>
    public class Project
    {
        private ArrayList _Note = new ArrayList();
        public void AddNote(string newnote, Category_note newcategory_note, string newtext_note)
        {
            _Note.Add(new Note(newnote, newcategory_note, newtext_note)); //Добавление заметки.
        }
        public void DeleteNote(int index) // Метод удаления заметки.
        {
            _Note.RemoveAt(index);
        }
        public Note GetNote(int index) //Метод вывода.
        {
            return (Note)_Note[index];
        }
        public void ChangeNove(int index, string newnote, Category_note newcategory_note, string newtext_note)
        {
            _Note.RemoveAt(index);
            _Note.Add(new Note(newnote, newcategory_note, newtext_note));
        }

        }
}

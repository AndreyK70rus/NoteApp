using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace NoteApp
{

    /// <summary>
    /// Класс project с модификатором доступа public. Содержит список всех заметок, созданных в приложении.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Создаем массив заметок.
        /// </summary>
        public List<Note> NotesCollection = new List<Note>();

        /// <summary>
        /// Метод сортировки заметок по дате изменения в порядке убывания.
        /// </summary>
        /// <returns></returns>
        public List<Note> SortedNotesCollection()
        {
            var sorted = NotesCollection.OrderByDescending(x => x.LastChangeTime);
            return sorted.ToList();
        }

        /// <summary>
        /// Сортировка по выбранной категории заметок и отображение их по дате изменения в порядке убывания
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<Note> SortedNotesCollection(NoteCategory category)
        {
            List<Note> sorted = new List<Note>();          
            for (int i = 0; i < NotesCollection.Count; i++)
            {
                if (NotesCollection[i].CategoryNote == category)
                {
                   sorted.Add(NotesCollection[i]);
                }
            }   
            return sorted.OrderByDescending(z => z.LastChangeTime).ToList();
        }
    }
}

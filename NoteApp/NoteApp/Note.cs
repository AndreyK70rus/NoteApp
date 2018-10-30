using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NoteApp
{
    /// <summary>
    /// Класс Note с публичным модификатором доступа.
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Поле _title "Название" с модификатором доступа public.
        /// </summary>
        private string _title;
        public string GetTitle() { return _title; }
        public void SetTitle (string title)
        {
            if (title.Length > 50)
            {
                throw new ArgumentException("Длина поля превышает 50 символов");
            }
            else
                _title = title;
        }
        /// <summary>
        /// Поле _category_note "Категория заметки" с модификатором доступа public.
        /// </summary>
        private Category_note _category_note;      
        public Category_note GetCategoryNote() { return _category_note; }
        public void SetCategoryNote (Category_note value)
        {
            _category_note = value;
        }
        /// <summary>
        /// Поле _text_note "Текст заметки" с модификатором доступа public.
        /// </summary>
        private string _text_note;
        public string GetTextNote() { return _text_note; }
        public void SetTextNote (string value)
        {
            _text_note = value;
        }       
        /// <summary>
        /// Поле _creation_time "Дата создания" с модификатором доступа public.
        /// </summary>
        private readonly DateTime _creation_time;
        public  DateTime GetCreationTime() { return _creation_time; }
        public void SetCreationTime(DateTime value)
        {

        }

        /// <summary>
        /// Поле _Last_change_time "Время последнего изменения" с модификатором доступа private.
        /// </summary>
        private DateTime _last_change_time;
        public DateTime GetLastChangeTime() { return _last_change_time; }
        public void SetLastChangeTime (DateTime value)
        {
            _last_change_time = value;
        }
        
        public Note(string newnote, Category_note newcategory_note, string newtext_note)
        {
            _category_note = newcategory_note;
            _text_note = newtext_note;
            _last_change_time = DateTime.Today;
            _title = newnote;
         
        }
        public Note(DateTime newcreation_time)
        {
            _creation_time = newcreation_time;
        }
    }
} 

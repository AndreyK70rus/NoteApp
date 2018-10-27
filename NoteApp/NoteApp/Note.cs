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
        /// <summary>
        /// Поле _category_note "Категория заметки" с модификатором доступа public.
        /// </summary>
        private Category_note _category_note;
        /// <summary>
        /// Поле _text_note "Текст заметки" с модификатором доступа public.
        /// </summary>
        private char _text_note;
        /// <summary>
        /// Поле _creation_time "Дата создания" с модификатором доступа public.
        /// </summary>
        private DateTime _creation_time;
        /// <summary>
        /// Поле _Last_change_time "Время последнего изменения" с модификатором доступа private.
        /// </summary>
        private DateTime _last_change_time;

        public Note(string newnote, Category_note newcategory_note, char newtext_note)
        {
            if (newnote.Length <= 50)
            {
                _title = newnote;
                                         
            }
            else
            {
                throw new ArgumentException("Длина названия превышает 50 символов");
            }
            _category_note = newcategory_note;
            _text_note = newtext_note;
            _last_change_time = DateTime.Today;
        }
        
    }
} 

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
        public string _title;
        /// <summary>
        /// Поле _category_note "Категория заметки" с модификатором доступа public.
        /// </summary>
        public string _category_note;
        /// <summary>
        /// Поле _text_note "Текст заметки" с модификатором доступа public.
        /// </summary>
        public char _text_note;
        /// <summary>
        /// Поле _creation_time "Дата создания" с модификатором доступа public.
        /// </summary>
        public readonly DateTime _creation_time;
        /// <summary>
        /// Поле _Last_change_time "Время последнего изменения" с модификатором доступа private.
        /// </summary>
        private DateTime _last_change_time;
        
    }
} 

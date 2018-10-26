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
        /// 
        /// </summary>
        private string _note;
        public string _title;
        public string _category_note;
        public char _text_note;
        public readonly DateTime _creation_time;
        private DateTime _last_change_time;
        
    }
} 

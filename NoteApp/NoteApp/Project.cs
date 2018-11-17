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
        // Создаем массив заметок.
        public List<Note> NoteList = new List<Note>();
    }

}

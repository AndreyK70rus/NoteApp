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
        /// Поле _Title "Название" с модификатором доступа private.
        /// </summary>
        private string _title;

        /// <summary>
        /// Свойство для поля _Title с модификатором доступа public.
        /// </summary>
        /// <returns>Добавление введенного значения в поле _Title.</returns>
        public string Title
        {
            set
            {
                if (value.Length > 50) 
                {
                    throw new ArgumentException("Длина поля превышает 50 символов");
                }
                else
                    _title = value;
            }
            get { return _title; }
        }

        /// <summary>
        /// Поле _CategoryNote "Категория заметки" с модификатором доступа private.
        /// </summary>
        private NoteCategory _categoryNote;

        /// <summary>
        /// Автосвойство для поля _CategoryNote с модификатором доступа public.
        /// </summary>
        /// <returns>Добавление введенного значения в поле _CategoryNote.</returns>
        public NoteCategory CategoryNote
        {
            set
            { 
                _categoryNote = value;
            }
            get { return _categoryNote; }
        }
        
        /// <summary>
        /// Поле _TextNote "Текст заметки" с модификатором доступа private.
        /// </summary>
        private string _textNote;

        /// <summary>
        /// Автоссвойство для поля _TextNote "Текст заметки" с модификатором доступа public.
        /// </summary>
        /// <returns>Добавление введенного значения в поле _TextNote.</returns>
        public string TextNote
        {
            set
            {
                _textNote = value;
            }
            get { return _textNote; }
        }     

        /// <summary>
        /// Поле _CreationTime "Дата создания" с модификатором доступа private.
        /// </summary>
        private DateTime _creationTime;

        /// <summary>
        /// Свойство для поля _CreationTime с модификатором доступа public.
        /// </summary>
        /// <returns>Добавление введенного значения в поле _CreationTime.</returns>
        public DateTime CreationTime
        {
            set
            {
                var date1 = DateTime.Now;
                if (value > date1)
                {
                    throw new ArgumentException("Дата создания не может превышать текущую дату");
                }
                _creationTime = value;
            }
            get { return _creationTime; }
        }

        /// <summary>
        /// Поле _LastChangeTime "Время последнего изменения" с модификатором доступа private.
        /// </summary>
        private DateTime _lastChangeTime;

        /// <summary>
        /// Свойство для поля _LastChangeTime с модификатором доступа public.
        /// </summary>
        /// <returns>Добавление введенного значения в поле _LastCreationTime.</returns>
        public DateTime LastChangeTime
        {
            set
            {
                var date1 = DateTime.Now;
                var date2 = CreationTime;
                if (value > date1 || value > date2)
                {
                    throw new ArgumentException("Дата изменения не может превышать текущую дату и время создания");
                }
                _lastChangeTime = value;
            }
            get { return _lastChangeTime; }
        }         
    }
} 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteApp

{
    /// <summary>
    /// Класс Note с публичным модификатором доступа.
    /// Содержит поля: "Название","Категория заметки","Текст заметки","Дата создания","Дата последнего изменения".
    /// Поле "Название" содержит исключение. Для остальных полей записаны автосвойства.
    /// </summary>
    public class Note
    {

        /// <summary>
        /// Поле _Title "Название" с модификатором доступа private.
        /// </summary>
        private string _Title;

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
                    _Title = value;
            }
            get { return _Title; }
        }

        /// <summary>
        /// Поле _CategoryNote "Категория заметки" с модификатором доступа private.
        /// </summary>
        private CategoryNote _CategoryNote;

        /// <summary>
        /// Автосвойство для поля _CategoryNote с модификатором доступа public.
        /// </summary>
        /// <returns>Добавление введенного значения в поле _CategoryNote.</returns>
        public CategoryNote CategoryNote
        {
            set
            { 
                _CategoryNote = value;
            }
            get { return _CategoryNote; }
        }
        
        /// <summary>
        /// Поле _TextNote "Текст заметки" с модификатором доступа private.
        /// </summary>
        private string _TextNote;

        /// <summary>
        /// Автоссвойство для поля _TextNote "Текст заметки" с модификатором доступа public.
        /// </summary>
        /// <returns>Добавление введенного значения в поле _TextNote.</returns>
        public string TextNote
        {
            set
            {
                _TextNote = value;
            }
            get { return _TextNote; }
        }     

        /// <summary>
        /// Поле _CreationTime "Дата создания" с модификатором доступа private.
        /// </summary>
        private DateTime _CreationTime;

        /// <summary>
        /// Автосвойство для поля _CreationTime с модификатором доступа public.
        /// </summary>
        /// <returns>Добавление введенного значения в поле _CreationTime.</returns>
        public DateTime CreationTime
        {
            set
            {                 
                _CreationTime = value;
            }
            get { return _CreationTime; }
        }

        /// <summary>
        /// Поле _LastChangeTime "Время последнего изменения" с модификатором доступа private.
        /// </summary>
        private DateTime _LastChangeTime;

        /// <summary>
        /// Автосвойство для поля _LastChangeTime с модификатором доступа public.
        /// </summary>
        /// <returns>Добавление введенного значения в поле _LastCreationTime.</returns>
        public DateTime LastChangeTime
        {
            set
            {              
                _LastChangeTime = value;
            }
            get { return _LastChangeTime; }
        }  
        
    }
} 

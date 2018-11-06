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
        /// Поле _Title "Название" с модификатором доступа public.
        /// </summary>
        private string _Title;
        /// <summary>
        /// Метод геттер и сеттер для поля _Title.
        /// </summary>
        /// <returns></returns>
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
        /// Поле _CategoryNote "Категория заметки" с модификатором доступа public.
        /// </summary>
        private CategoryNote _CategoryNote;
        /// <summary>
        /// Метод геттер и сеттер для поля _CategoryNote.
        /// </summary>
        public CategoryNote CategoryNote
        {
            set
            {
                _CategoryNote = CategoryNote;
            }
            get { return CategoryNote; }
        }
        
        /// <summary>
        /// Поле _TextNote "Текст заметки" с модификатором доступа public.
        /// </summary>
        private string _TextNote;
        /// <summary>
        /// Метод геттер и сеттер для поля _TextNote
        /// </summary>
        public string TextNote
        {
            set
            {
                _TextNote = TextNote;
            }
            get { return _TextNote; }
        }     
        /// <summary>
        /// Поле _CreationTime "Дата создания" с модификатором доступа public. Только для чтения.
        /// </summary>
        private  DateTime _CreationTime;
        /// <summary>
        /// Метод геттер для поля _CreationTime.
        /// </summary>
        /// <returns></returns>
        public DateTime CreationTime
        {
            set
            {
                CreationTime = DateTime.Today;
                _CreationTime = CreationTime;
            }
            get { return _CreationTime; }
        }
        /// <summary>
        /// Поле _LastChangeTime "Время последнего изменения" с модификатором доступа private.
        /// </summary>
        private DateTime _LastChangeTime;
        /// <summary>
        /// Метод геттер для поля _LastChangeTime.
        /// </summary>
        /// <returns></returns>
        public DateTime LastChangeTime
        {
            set
            {
                LastChangeTime = DateTime.Today;
                _LastChangeTime = LastChangeTime;
            }
            get { return _LastChangeTime; }
        }

   
       
    }
} 

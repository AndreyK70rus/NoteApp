using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Перечисление "Категория заметки". В структуру перечисления входят: работа, дом, Здоровье и спорт,
    /// люди, документы, финансы, другое.
    /// </summary>
    public enum  CategoryNote
    {
      All = 0,  //Всё
      Work,  //Работа
      House,  //Дом            
      Heath_and_sport,  //Здоровье и спорт  
      People, //Люди
      Documents, //Документы
      Finance,  //Финансы
      Another  //Другое
    };
   
}

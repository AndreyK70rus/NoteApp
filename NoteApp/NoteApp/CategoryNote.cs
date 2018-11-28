using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteApp
{
    /// <summary>
    /// Перечисление "Категория заметки". В структуру перечисления входят: все категории, работа, дом, Здоровье и спорт,
    /// люди, документы, финансы, другое.
    /// </summary>
    public enum  NoteCategory
    {
      All = 0,
      Work,
      House,           
      HealthAndSport,  
      People, 
      Documents, 
      Finance,
      Another  
    };  
}

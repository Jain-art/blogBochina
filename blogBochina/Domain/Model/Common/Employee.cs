using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogBochina.Model.Common
{
    ///Пользователь
    public class Employee : Entity
    {
        ///имя пользователя
        public string FirstName { get; set; }
        ///фамилия пользователя
        public string Surname { get; set; }
        ///адрем проживания пользователя
        public string Address { get; set; }
        ///возвращает полное имя пользователя
        public string FullName
        {
            get => FirstName + "" + Surname;
        }
    }
}

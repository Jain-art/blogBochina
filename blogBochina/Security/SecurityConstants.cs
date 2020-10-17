using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogBochina.Security
{
    /// <summary>
    /// константы используемые в подсистеме
    /// </summary>
    public static class SecurityConstants
    {
        /// <summary>
        /// Администратор
        /// </summary>
        public const string AdminRole = "ADMIN";
        /// <summary>
        /// пользователь
        /// </summary>
        public const string CostomerRoel = "CUSTOMER";
        /// <summary>
        /// Логин администратора
        /// </summary>
        public const string AdminUserRole = "ADMIN";
        /// <summary>
        /// Пароль администратора
        /// </summary>
        public const string AdminPassword = "123456";
        /// <summary>
        /// Мэйл администратора
        /// </summary>
        public const string AdminEmail = "admim@test.ru";
        /// <summary>
        /// Имя администратора
        /// </summary>
        public const string AdminFirstName = "Администратор";
        /// <summary>
        /// Фамилия администратора
        /// </summary>
        public const string AdminSurName = "Системы";
    }
}

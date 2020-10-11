using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogBochina.Model.Common
{
    /// <summary>
    /// пост блога
    /// </summary>
    public class BlogPost : Entity
    {
        /// <summary>
        /// пользователь, который создал сущность
        /// </summary>
        public Employee Owner { get; set; }
        ///дата и время создания поста
        public DateTime Created { get; set; }
        ///заголовок поста
        public string Title { get; set; }
        ///данные поста
        public string Data { get; set; }
    }
}

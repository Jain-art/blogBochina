using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogBochina.ViewModels.Account
{
    /// <summary>
    /// Добавляем новый пост
    /// </summary>
    public class NewPostViewModel
    {
        /// <summary>
        /// Автор поста
        /// </summary>
        [Required]
        [Display(Name = "Автор")]
        public string Owner { get; set; }

        /// <summary>
        /// Заголовок поста
        /// </summary>
        [Required]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        /// <summary>
        /// Текст поста
        /// </summary>
        [Required]
        [Display(Name = "Текст")]
        public string Data { get; set; }

        /// <summary>
        /// Время оформления поста
        /// </summary>
        [Required]
        [Display(Name = "Время оформления")]
        public string Created { get; set; }

       
    }
}

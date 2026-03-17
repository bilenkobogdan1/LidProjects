using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Data.LidProject
{
    public class ContactLids
    {
        [Key]
        public int id { get; set; }
        [Column(name:"Name")]
        [MaxLength(250)]
        public string? Name { get; set; }
        /// <summary>
        /// Фамілія
        /// </summary>
        [Column(name: "Surname")]
        [MaxLength(250)]
        public string? Surname { get; set; }
        /// <summary>
        /// Емейл
        /// </summary>
        [Column(name: "Email")]
        [MaxLength(250)]
        public string? Email { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        [Column(name: "Phone")]
        public string? Phone { get; set; }
        /// <summary>
        /// Опис
        /// </summary>
        [Column(name: "Describe")]
        public string? Describe { get; set; }

        // Назва колонки в БД
        [Column("CategoryLidId")] 
        public int? CategoryLidId { get; set; }

        /// <summary>
        /// Навігаційна властивість (об'єкт)
        /// </summary>
        [ForeignKey("CategoryLidId")]
        public CategoryLids? CategoryLid { get; set; }
    }
}

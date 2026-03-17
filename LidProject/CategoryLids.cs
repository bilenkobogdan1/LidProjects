using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.LidProject
{
    public class CategoryLids
    {  
        /// <summary>
        /// id
        /// </summary>
        [Key]
        public int id { get; set; }
        /// <summary>
        /// І'мя категорії
        /// </summary>
        [Column(name: "Name")]
        [MaxLength(250)]
        public string? Name { get; set; }
    }
}

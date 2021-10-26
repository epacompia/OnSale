using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnSale.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Name { get; set; }
    }
}

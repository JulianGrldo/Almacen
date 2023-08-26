using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Shared.Entities
{
    public class Producto
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El Identificador es requerido")]
        public string Name { get; set; } = null;

        [Required(ErrorMessage = "El Identificador es requerido")]
        public int price { get; set; }

        [Required(ErrorMessage = "El Identificador es requerido")]
        public int quantity { get; set; }

       



    }


}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HamburgOrt
{
    public class Cliente
    {
        [Key]
        public int clienteId { get; set; }
        public String nombre { get; set; }
        public String dni { get; set; }

    }
}

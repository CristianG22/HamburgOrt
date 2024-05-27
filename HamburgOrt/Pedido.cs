using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace HamburgOrt
{
    public class Pedido
    {
        [Key]
        public int pedidoId { get; set; }
        public int clienteId { get; set; }
        public int comboId { get; set; }
        public int mesaId { get; set; }
        public int meseroId { get; set; }

    }
}

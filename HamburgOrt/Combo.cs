using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HamburgOrt
{
    public class Combo
    {
        [Key]
        public int comboId {  get; set; }
        public String nombre { get; set; }
        public double precio { get; set; }
        public Tamanio tamanio { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HamburgOrt
{
    internal class Mesero
    {
        [Key]
        private int meseroId { get; set; }
        private String nombre {  get; set; }
        private int dni { get; set; }
       
    }
}

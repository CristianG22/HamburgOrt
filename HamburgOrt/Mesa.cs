﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HamburgOrt
{
    public class Mesa
    {
        [Key]
        public int mesaId { get; set; }
        public int nroMesa {  get; set; }
        public int capacidadMesa { get; set; }

     }
}

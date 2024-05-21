using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HamburgOrt
{
    public enum TamañoActual
    { 
        Chico,
        Mediano,
        Grande
    }
    internal class Tamaño
    {
        private TamañoActual tamaño { get; set; }
        private int tamañoId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasAP1.Tarea5Ismarlyn
{
    public class Poligono
    {
        public int largo { get; set; }
        public int lado { get; set; }

        public Poligono()
        {
            this.largo = 0;
            this.lado = 0;
        }

        public Poligono(int largo, int lado)
        { 
            this.largo = largo;
            this.lado = lado;
        }
    }
}

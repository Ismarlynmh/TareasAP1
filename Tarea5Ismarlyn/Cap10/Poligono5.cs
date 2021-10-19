using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasAP1.Tarea5Ismarlyn
{
    class Poligono5
    {
        public int largo { get; set; }
        public int lado { get; set; }

        public Poligono5()
        {
            this.largo = 0;
            this.lado = 0;
        }

        public Poligono5(int largo, int lado)
        {
            this.largo = largo;
            this.lado = lado;
        }
        //Solo colocar valores validos
        public double poligono(int largo, int lado)
        {
            int perimetro = 0;
            if (lado < 0 || largo < 0)
                Console.WriteLine("No puede registrar un numero nulo");
            else
            {
                perimetro = largo * lado;
            }

            return perimetro;
        }
        public int poligono()
        {
            int perimetro = 0;
            if (this.lado < 0 || this.largo < 0)
                Console.WriteLine("No puede registrar un numero nulo");
            else
                perimetro = this.largo * this.lado;


            return perimetro;
        }
        public override string ToString()
        {
            return "El perimetro es: " + poligono();
        }
    }
}

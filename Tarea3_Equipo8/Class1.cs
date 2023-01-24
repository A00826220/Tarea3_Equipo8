using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_Equipo8
{
    public class GeneradorAlaeatorios
    {
        public List<float> aleatorios { get; set; }
        public int a { get; set; }
        public int c { get; set; }
        public int m { get; set; }
        public float semilla { get; set; }
    }
    
    public void GeneradorAleatorios (int a, int c, int m)
    {
        Random aleatorio = new Random(Environment.TickCount);
        for (int i = 0; i < a; i++)
        {
            double value = aleatorio.NextDouble();
            double value2 = aleatorio.Next()
        }
    }


    
}

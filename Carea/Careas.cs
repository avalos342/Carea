using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carea
{
   public class CAreas
    {
 
        public static decimal Cuadrado(decimal lado)
        {
            return  lado * lado;
        }
        public static decimal Triangulo(decimal b, decimal h)
        {
            return (b * h)/2;
        }
        public static decimal Rectangulo(decimal b, decimal h)
        {
            return  b * h;
        }
        public static decimal Rombo(decimal D, decimal d)
        {
            return D * d;
        }
        public static decimal Romboide(decimal b, decimal h)
        {
            return b * h;
        }
        public static decimal Trapecio(decimal B, decimal b, decimal h)
        {
           return (B * b) * h /2;
        }
        public static decimal Circulo(decimal radio)
        {
           return  (decimal)(Math.PI * Math.Pow((double)radio, 2));        
        }
        public static decimal Poligono(decimal p, decimal a)
        {
            return  p * a /2;
        }
    }


}

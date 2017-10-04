using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaGeometria fachada = new FachadaGeometria();          //creo un objeto de clase FachadaGeometria, que será el controlador
            Console.WriteLine("INGRESE LA OPCIÓN QUE SOLICITE REALIZAR");
            Console.WriteLine("1- Calcular distancia entre 2 puntos");
            Console.WriteLine("2- Ingrese un círculo");
            Console.WriteLine("3- Ingrese un triángulo");

            double x1;
            double y1;
            double x2;
            double y2;
            double x3;
            double y3;

            switch (Convert.ToInt32(Console.ReadLine()))
            {                
                case 1:
                    Console.Write("Ingrese la coordenada X del primer punto: ");
                    x1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la coordenada Y del primer punto: "); 
                    y1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la coordenada X del segundo punto: ");
                    x2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la coordenada Y del segundo punto: ");
                    y2 = Convert.ToDouble(Console.ReadLine());

                    double mDistancia = fachada.calcularDistanciaPuntos(x1, y1, x2, y2);    //utiliza la fachada para calcular la distancia y lo guarda en una variable

                    Console.WriteLine("La distancia entre los dos puntos es: " + mDistancia);
                    break;

                case 2:
                    Console.Write("Ingrese la coordenada X del centro: ");
                    x1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la coordenada Y del centro: "); 
                    y1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el radio del circulo: ");
                    double cualquierRadio = Convert.ToDouble(Console.ReadLine());

                    double mArea = fachada.calcularAreaCirculo(x1, y1, cualquierRadio);             //asigna a estas variables la devolución de llamar a estos metodos de la fachada
                    double mPerimetro = fachada.calcularPerimetroCirculo(x1, y1, cualquierRadio);

                    Console.WriteLine("El área del circulo es: " + mArea);
                    Console.WriteLine("El perimetro del circulo es: " + mPerimetro);
                    break;

                case 3:
                    Console.Write("Ingrese la coordenada X del primer punto: ");
                    x1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la coordenada Y del primer punto: ");
                    y1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la coordenada X del segundo punto: ");
                    x2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la coordenada Y del segundo punto: ");
                    y2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la coordenada X del tercer punto: ");
                    x3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la coordenada Y del tercer punto: ");
                    y3 = Convert.ToDouble(Console.ReadLine());

                    double mAreaT = fachada.calcularAreaTriangulo(x1, x2, x3, y1, y2, y3);  //utiliza la fachada para calcular el arae del triangulo y guarda la dovolución en una variable para utilizarlo luego

                    Console.WriteLine("El área del triangulo es: " + mAreaT);
                    break;

                default:
                    Console.WriteLine("el número ingresado no es válido");
                    break;
            }

            Console.ReadKey();
        }        
    }
}

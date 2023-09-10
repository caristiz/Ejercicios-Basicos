namespace itm.csharp.basic
{
    /*Solicita al usuario un número y eleva este número al cuadrado 
    solo si es positivo*/
    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Digite un número");
            int.TryParse(Console.ReadLine(), out int numero);
            if (numero >= 0)
            {
                int resultado = numero * numero;
                Console.WriteLine ("El número " + numero + " elevado al cuadrado es " + resultado);
            }
            else if (numero < 0) Console.WriteLine(" El número es negativo");
            else Console.WriteLine( "Ingresa un número válido.");

        }
    }
    
    /* Solicita al usuario dos números. Si el primero es mayor, devuelva 
    su doble, de lo contrario devuelva el triple del segundo.*/ 
    public class Challenge2
    {
        public void Run()
        {
            int num1, num2;
          Console.WriteLine("Ingrese un número");
           int.TryParse(Console.ReadLine(), out num1);
          Console.WriteLine("Ingrese otro número");
           int.TryParse(Console.ReadLine(), out num2);

           int resultado = num1 > num2 ? num1 * 2 : num2 * 3;

          Console.WriteLine($"Resultado: {resultado}");
        }
    }

    /*Pide al usuario un número. Si es positivo, devuelve su raíz
    cuadrada, de lo contrario, devuelve su cuadrado */

    public class Challenge3
    {
        public void Run()
        {
           Console.WriteLine("Digite un número");
            double.TryParse(Console.ReadLine(), out double numero3);
            if (numero3 > 0)
            {
                double resultado = Math.Sqrt(numero3);
                Console.WriteLine ("La raiz cuadrad del número " + numero3 + " es " + resultado);
            }
            else if (numero3 <= 0)
            {
                double resultado = numero3*numero3;
            }
            else Console.WriteLine( "Ingresa un número válido.");

        }
    }

    /*Pide al usuario el radio de un círculo y calcula su perímetro.*/

    public class Challenge4
    {
        public void Run ()
        {
            Console.WriteLine("Ingrese el radio de la circunferencia");
            double.TryParse(Console.ReadLine(), out double radio);
            double perimetro = Math.PI * radio * 2;
            Console.WriteLine( "El perímetro es: " + perimetro);
        }
    }


}

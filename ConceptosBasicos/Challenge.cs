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

    
   /*Solicita al usuario un número entre 1 y 7 y muestra el día de la 
  semana correspondiente, pero solo considerando los días laborables*/ 

    public class Challenge5
    {
       public void Run()
       {
        Console.WriteLine("Ingresa un número del 1 al 7");
            int.TryParse(Console.ReadLine(), out int dia);

            switch(dia)
            {
                case 1:Console.WriteLine("Lunes");break;
                case 2:Console.WriteLine("Martes");break;
                case 3:Console.WriteLine("Miércoles");break;
                case 4:Console.WriteLine("Jueves");break;
                case 5:Console.WriteLine("Viernes");break;
                default: Console.WriteLine("Número fuera del rango laboral");break;

            }
       }
    }

    /*Solicita al usuario su salario anual y, si este excede los 12000, 
    muestra el impuesto a pagar que es el 15% del excedente. */ 

    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Ingrese su salario anual");
            double.TryParse(Console.ReadLine(), out double salario);
            double impuesto = salario > 12000 ? 0.15 * salario : 0;
            Console.WriteLine($"El impuesto a pagar es: {impuesto}");

        }   
    }

    /*: Solicita dos números y muestra el residuo de la división del 
    primero entre el segundo. */

    public class Challenge7
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Ingresar número a dividir");
                double.TryParse(Console.ReadLine(), out double dividendo);
                Console.WriteLine("Ingresar el divisor");
                double.TryParse(Console.ReadLine(), out double divisor);
                Console.WriteLine($"El residuo de la división es: {dividendo % divisor}");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("No se puede divir por cero");
            }
            catch (Exception)
            {
                Console.WriteLine("Error al realizar operación");
            }
        }
    }
 

}

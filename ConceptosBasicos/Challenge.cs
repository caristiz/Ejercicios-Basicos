using System.Data;

namespace itm.csharp.basic
{
    /*Solicita al usuario un número y eleva este número al cuadrado 
    solo si es positivo*/
    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("1 - Potencia positiva");
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
          Console.WriteLine("2 - Doble o Triple");
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
           Console.WriteLine("3 - Raíz o Cuadrado");
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
            Console.WriteLine("4 - Perímetro del Círculo");
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
         Console.WriteLine("5 -  Día laborales");
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
            Console.WriteLine("6 -  Calcular Impuesto");
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
            Console.WriteLine("7 - Residuo de una División");
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

    /*Calcula y muestra la suma de los números pares entre 1 y 50. */
    public class Challenge8
    {
        public void Run ()
        {
            Console.WriteLine("8 - Suma de Números Pares");
            int suma = 0;
          for (int i = 2; i <=50; i+= 2)
          {
            suma +=i;
          }

          Console.WriteLine("La suma de los números pares entre 1 y 50 es: "+ suma);
        }
    }

    /*Solicita al usuario los valores para dos fracciones y
    muestra la diferencia entre esas fracciones.*/

    public class Challenge9
    {
        public void Run ()
        {
            Console.WriteLine("9 - Resta de fracciones");
            Console.Write("Ingresa el numerador de la primera fracción: ");
            int.TryParse(Console.ReadLine(), out int nume1);
            Console.Write("Ingresa el denominador de la primera fracción: ");
            int.TryParse(Console.ReadLine(), out int deno1);

            Console.Write("Ingresa el numerador de la segunda fracción: ");
            int.TryParse(Console.ReadLine(), out int nume2);
            Console.Write("Ingresa el denominador de la segunda fracción: ");
            int.TryParse(Console.ReadLine(), out int deno2);

            try
            {
                Fraccion fraccion1 = new Fraccion(nume1,deno1);
                Fraccion fraccion2 = new Fraccion(nume2,deno2);

                Fraccion resultado = fraccion1.Restar(fraccion2);
                Console.WriteLine($"la sima de {fraccion1} y {fraccion2} es: {resultado}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error:{e.Message}");
            }



        }
    }

    public class Fraccion
    {
        public int Numerador { get; private set;}
        public int Denominador { get; private set;}

        public Fraccion (int numerador, int denominador)
        {
            if (Denominador == 0)
            {
                throw new ArgumentException("El doniminador no puede ser cero");
            }
            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Restar(Fraccion otra)
        {
          int nuevoNumerador = Numerador * otra.Denominador - otra.Numerador * Denominador;
          int nuevoDenominador = Denominador * otra.Denominador;
          return new Fraccion (nuevoNumerador, nuevoDenominador);
        }

        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }

    }

    
    /*Pide una palabra al usuario y muestra la longitud de esa palabra.*/

    public class Challenge10
    {
        public void Run()
        {
           Console.WriteLine("10 - Longitud de Cadena");
           Console.WriteLine("Ingrese una palabra:");
           string? palabra = Console.ReadLine();
           int longitud = palabra.Length;
           Console.WriteLine($"La longitud de la palabra '{palabra}' es: {longitud}"); ;
        }
    }
 
    /* Pide al usuario cuatro números y muestra el promedio.*/

    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("11 - Promedio de cuatro números");
            Console.WriteLine("Digite el primer numero");
           double.TryParse(Console.ReadLine(), out double numeroA);         
            Console.WriteLine("Digite el Segundo numero");
           double.TryParse(Console.ReadLine(), out double numeroB);
            Console.WriteLine("Digite el tercer numero");
           double.TryParse(Console.ReadLine(), out double numeroC);
            Console.WriteLine("Digite el cuerto numero");
           double.TryParse(Console.ReadLine(), out double numeroD);

        
           double promedio = (numeroA + numeroB + numeroC + numeroD) / 4;
           Console.WriteLine($"El promedio de los números ingresados es: {promedio}");

        }
    }
     
    /*Pide al usuario cinco números y muestra el más pequeño. */

    public class Challenge12
    {
      public void Run()
      {
         Console.WriteLine("12 - El mas pequeño de cinco números");
         double minimo = double.MaxValue;

         for (int i = 1; i <= 5; i++)
         {
          Console.Write($"Número {i}: ");
          double numeroq = double.Parse(Console.ReadLine());
          minimo = Math.Min(minimo, numeroq);
          }
           Console.WriteLine($"El número más pequeño es: {minimo}");

      }
    }

    /*Pide una palabra al usuario y devuelve el número de vocales en esa palabra*/

    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("13 - Contadot de Vocales");
            Console.WriteLine("Por favor, ingresa una palabra:");
           string text = Console.ReadLine().ToLower(); 
            int contadorVocales = 0;

            foreach (char letra in text)
          {
            if ("aeiou".Contains(letra))
            {
                contadorVocales++;
            }
           }

          Console.WriteLine($"El número de vocales en la palabra \"{text}\" es: {contadorVocales}");

        }

    }

    /*Pide un número al usuario y devuelve el factorial de ese número.*/

    public class Challenge14
    {
        public void Run()
        {
            Console.WriteLine("14 - Buscar Factorial");
            int n, cont, fact;
            Console.WriteLine("Digite el valor de n!: ");
            n = Convert.ToInt32(Console.ReadLine());
            if ( n==0)
            {
                Console.WriteLine("El factorial de (0) es 1");
            }
            else
            {
                fact = n;
                for (cont =n; cont > 1; cont --);
                {
                    fact = fact * (cont-1);
                }
                Console.WriteLine($"El factroial de {n} es: {fact}");
            }

        }
    }

    /*Pide un número al usuario y verifica si está en el rango de 10 a 20 (ambos incluidos). */

    public class Challenge15
    {
        public void Run()
        {
            Console.WriteLine("15 - Validador de rango");
            int.TryParse(Console.ReadLine(), out int numeroRango);
           if (numeroRango >= 10 && numeroRango <= 20)
           {
           Console.WriteLine("Resultado: Está en el rango.");
           }
          else
           {
           Console.WriteLine("Resultado: Fuera del rango.");
            }

        }
    }


}

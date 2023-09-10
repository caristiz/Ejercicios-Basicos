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
}
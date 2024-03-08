namespace csharp.basic
{
    public class Challenge14
    {
        public void Run()
        {
            Console.Write("Ingrese un número para calcular su factorial: ");
            int numero = int.Parse(Console.ReadLine());

            long factorial = Factorial(numero);

            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }

        public long Factorial(int numero)
        {
            long resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

    }
}
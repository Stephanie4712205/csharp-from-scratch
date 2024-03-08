namespace csharp.basic
{
    public class Challenge13
    {
        public void Run()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            int contadorVocales = ContarVocales(palabra);

            Console.WriteLine($"El número de vocales en \"{palabra}\" es: {contadorVocales}");
        }

        static int ContarVocales(string palabra)
        {
            int contador = 0;
            foreach (char letra in palabra.ToLower())
            {
                if ("aeiou".Contains(letra))
                {
                    contador++;
                }
            }
            return contador;
        }

    }

}
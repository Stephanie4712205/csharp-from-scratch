namespace csharp.basic
{
    public class Challenge12
    {
        public void Run()
        {
            List<int> numeros = new List<int>();

            for(int i =0; i<5; i++)
            {
                Console.WriteLine($"Introduce el numero {i + 1}: ");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"El numero mas pequeño de la lista es: {numeros.Min()} ");
        }
       
    }
     
}
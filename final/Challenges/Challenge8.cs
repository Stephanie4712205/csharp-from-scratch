namespace csharp.basic
{
    public class Challenge8
    {
        public void Run()
        {
            int suma = 0;
            for (int i = 2; i <= 50; i+=2)
            {
                suma += i;
            }

            Console.WriteLine(suma);
        }

    }

}
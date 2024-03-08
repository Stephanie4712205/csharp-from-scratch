namespace csharp.basic
{
    public class Challenge9
    {
        public void Run()
        {
            Console.WriteLine("Ingrese numerador de la primera fraccion:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominador de la primera fraccion:");
            int den1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numerador de la segunda fraccion:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominador de la segunda fraccion:");
            int den2 = int.Parse(Console.ReadLine());

            try
            {
                Fraccion fraccion1 = new Fraccion(num1, den1);
                Fraccion fraccion2 = new Fraccion(num2, den2);

                Fraccion resultado = fraccion1.Restar(fraccion2);
                Console.WriteLine($"La resta de {fraccion1} y {fraccion2} es: {resultado}");

            }
            catch(Exception  e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

    }

    public class Fraccion
    {
        public int Numerador { get; private set; }
        public int Denominador { get; private set; }

        public Fraccion(int numerador, int denominador)
        {
            if(denominador == 0)
            {
                throw new ArgumentException("El denominador no puede ser cero.");
            }

            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Restar (Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Denominador - otra.Numerador * Denominador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }

}
namespace CofreTarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CofreMadera cofreMadera = new CofreMadera();
            cofreMadera.Abrir();
            Console.ReadKey();

        }

       internal class CofreMadera
        {
            public int Oro = 75;
            public bool Abierto = false;

            public void Abrir()
            {
                if (Abierto == false)
                {
                    Console.WriteLine("Oro dentro del cofre: " + Oro);
                }
            }
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        char opción;
        Console.WriteLine("Ingrese la cantidad de elementos");
        int n=int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        Random r= new Random();
        Func f = new Func();

        for (int x=49; x<n; x++)
        {
            numeros[x] = r.Next(50,90+1);
        }

        do
        {
            Console.WriteLine("\nTe gustan más los numeros pares o impares? (i/p): ");
            opción = char.ToLower(Console.ReadKey().KeyChar);
        } while (opción != 'i' && opción != 'p');
        f.reiniciar();
        Console.Clear();
        

    }
}
class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int [5,5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++) 
            {

                Console.WriteLine($"Digite o numero do elemento {j + 1} da linha {i + 1}");
                matriz[i,j] = int.Parse(Console.ReadLine());

            }

        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {

                Console.WriteLine($"Os elementos da matriz são: {matriz[i, j]}");
        

            }

        }




    }
}
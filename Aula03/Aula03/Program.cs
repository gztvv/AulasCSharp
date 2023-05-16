class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int [10];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite o valor da posição {i+1}");
            int pos = int.Parse(Console.ReadLine());
            vetor[i] = pos;
        }

        Console.WriteLine();
        Console.WriteLine($"O Maior numero do vetor é : {Maior(vetor)}");
        Console.WriteLine($"O Menor numero do vetor é : {Menor(vetor)}");
        Console.WriteLine($"A quantidade de numeros pares do vetor é : {Pares(vetor)}");
        Console.WriteLine($"A quantidade de numeros impares do vetor é : {Impares(vetor)}");
        Console.WriteLine($"A Media aritmetica  do vetor é : {Media(vetor)}");




        // Metodos 
        static int Maior (int[] vetor) // Metodo para verificar qual numero maior do vetor
        {
            int accMaior = 0;
            foreach (int i in vetor) {
                if (i > accMaior) 
                {
                    accMaior = i;
                }
            }
            return accMaior;
        }
        static int Menor(int[] vetor)// Metodo para verificar qual numero menor do vetor
        {
            int accMenor = vetor[0];
            foreach (int i in vetor)
            {
                if (i < accMenor) // guarda o menor valor
                {
                    accMenor= i;
                }
            }
            return accMenor;
        }
        
        static int Pares(int[] vetor) // Metodo para verificar quantidade de numeros pares
        {
            int acc = 0;
            foreach(int i in vetor)
            {
                if (i % 2 == 0)
                {
                    acc++;
                }
            }
            return acc;
        }
        static int Impares(int[] vetor) // Metodo para verificar quantidade de numeros impares
        {
            int acc = 0;
            foreach (int i in vetor)
            {
                if (i % 2 != 0)
                {
                    acc++;
                }
            }
            return acc;
        }
        static int Media(int[] vetor) // Metodo para calcular media aritmetica do vetor
        {
            int acc = 0;
            foreach (int i in vetor)
            {
                acc += i;
            }
            return acc / vetor.Length;
        }
    }
}
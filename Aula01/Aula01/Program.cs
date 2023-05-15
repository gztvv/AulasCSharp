using System.Security.Cryptography.X509Certificates;

class Program {

    static void Main(String[] args){

        Console.WriteLine("Digite o tamanho do vetor");
        int vetorTamanho = int.Parse(Console.ReadLine());

        int[] vetor = new int[vetorTamanho];

        for (int i=0; i<vetorTamanho; i++)
        {
            Console.WriteLine($" Digite o {i + 1} numero do vetor ");
            vetor[i] = int.Parse(Console.ReadLine()) ;
        }

        int soma;
        int qunt;

        soma = SomaPares(vetor);
        qunt = ContaImpares(vetor);

        Console.WriteLine();

        Console.WriteLine($"Soma dos numeros pares: {soma}");
        Console.WriteLine($"Quantidade de numeros impares: {qunt}");

        Console.ReadKey();


        static int SomaPares(int[] vetor)
        {
            int acc = 0;
            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] % 2 == 0) {
                    acc += vetor[i];
                }

            }
            return acc;
            
        }

        static int ContaImpares(int[] vetor)
        {
            int acc = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    acc++;
                }
            }
            return acc;

        }
    }
}
//Crie dois	 vetores	 de	 50	 posições	 com	 valores	 inteiros	 aleatórios, ordene	 cada	 vetor	
//individualmente, e	 combine	 os	 dois	vetores	gerando	 um	 novo	vetor	 de	 100	 posições, de	
//forma	que	esse	novo	vetor	já	seja	criado	ordenado.	

using exercicio14.services;

class Program
{
    public static void Main(string[] args)
    {
        int[] vect1 = VectorService.GenerateVector(50, 100);
        int[] vect2 = VectorService.GenerateVector(50, 100);

        int[] vect = VectorService.StackVector(vect1, vect2);
        
        foreach (int i in vect)
        {
            Console.Write($"{i} ");
        }
    }
}
// insertion sort > verifica valores distantes
// bubble sort > verifica valores vizinhos

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Random random = new Random();
//        int[] vect = new int[100];
//
//        // preenche o vetor
//        for (int i = 0; i < vect.Length; i++)
//        {
//            vect[i] = random.Next(100);

//        }
           
          // tentativa insertion sort
//        for (int j = 0; j < vect.Length; j++)
//        {
//            for (int k = 0; k < j; k++)
//            {
//                if (vect[j] <= vect[k])
//                {
//                    int aux = vect[j];
//                    vect[j] = vect[k];
//                    vect[k] = aux;
//                }
//            }
//        }

          // mostrar o vetor ordenado
//        foreach (int n in vect)
//        {
//            Console.Write($"[{n}] ");
//        }
//    }

//}

// tentar bubble sort agr (compara elementos vizinhos e troca se estiverem fora de ordem)

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        int[] vect = new int[100];

        // preenche vetor 
        for (int i = 0; i < vect.Length; i++)
        {
            vect[i] = random.Next(100);
        }
        
        // tentativa buble sort 
        for (int i = 0; i < vect.Length - 1; i++) // passa pelo vetor
        {
            for (int j = 0; j < vect.Length - 1 - i; j++) // for para comparar
            {
                if (vect[j] > vect[j + 1]) // verificacao
                {
                    int aux = vect[j];
                    vect[j] = vect[j + 1];
                    vect[j + 1] = aux;
                }
            }
        }

        // mostrar vetor ordenado
        foreach (int n in vect)
        {
            Console.Write($"[{n}] ");
        }

    }
}
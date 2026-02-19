using System.Reflection.Metadata.Ecma335;

namespace exercicio14.services
{
    public static class VectorService
    {
        // gera um unico vetor com tamanho e valor maximo
        public static int[] GenerateVector(int length, int maxInt)
        {
            Random random = new Random();

            int[] vect = new int[length];

            // preenche vetor 
            for (int i = 0; i < vect.Length; i++)
            {
                vect[i] = random.Next(maxInt);
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

            return vect;
        }

        // combina esses dois vetores, ordenando os mesmos

        public static int[] StackVector(int[] vect1, int[] vect2)
        {
            int[] result = new int[vect1.Length + vect2.Length];

            // vect1
            int i = 0;

            // vect2
            int j = 0;

            // res
            int k = 0;

            while (i < vect1.Length && j < vect2.Length)
            {
                if (vect1[i] < vect2[j])
                {
                    result[k] = vect1[i];
                    i++;
                }
                else
                {
                    result[k] = vect2[j];
                    j++;
                }
                k++;
            }

            // resto vect1
            while (i < vect1.Length)
            {
                result[k] = vect1[i];
                i++;
                k++;
            }

            // resto vect2
            while (j < vect2.Length)
            {
                result[k] = vect2[j];
                j++;
                k++;
            }

            return result;
        }
    }
}

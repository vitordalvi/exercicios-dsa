//Determine    a saída	do seguinte	programa:
//public class Loop
//{
//    public static void main(String[] args)
//    {
//        for (int i = 2; i <= 8; i = i + 2)
//        {
//            for (int j = i; j <= 4; j++)
//            {
//                for (int k = 1; k <= j; k = k + i)
//                {
//                    System.out.println(i + ", " + j + ", " + k);
//                }
//            }
//        }
//    }
//}

class Program
{
    public static void Main(string[] args)
    {
        for (int i = 2; i <= 8; i = i + 2)
        {
            for (int j = i; j <= 4; j++)
            {
                // Resposta: 
                //2, 2, 1
                //2, 2, 2
                //2, 3, 1
                //2, 3, 2
                //2, 3, 3
                //2, 4, 1
                //2, 4, 2
                //2, 4, 3
                //2, 4, 4
                //4, 4, 1
                //4, 4, 2
                //4, 4, 3
                //4, 4, 4
                for (int k = 1; k <= j; k = k + 1)
                {
                    Console.WriteLine($"{i}, {j}, {k}");
                }
            }
        }
    }
}
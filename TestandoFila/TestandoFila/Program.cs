namespace Test
{
    class Program
    {
        static void Main(String[] args)
        {

            //int[] test = {1,2,3,4,5 };
            Queue<int> fila1 = new Queue<int>();

            fila1.Enqueue(1);
            fila1.Enqueue(2);   
            fila1.Enqueue(3);
            fila1.Enqueue(4);   
            fila1.Enqueue(5);

            Console.WriteLine("Quantidade fila: " + fila1.Count);

            Console.WriteLine("Digite um numero a ser encontrado na fila");
            int n = int.Parse(Console.ReadLine());

            while (n < 0 || n > 6)
            {
                if (fila1.Contains(n))
                {
                    Console.WriteLine("Elemento encontrado");
                }
                else
                {
                    Console.WriteLine("Elemento não encontrado");
                }
                Console.WriteLine("Digite um numero novamente: ");
                n= int.Parse(Console.ReadLine());
            }
        }


    }

}
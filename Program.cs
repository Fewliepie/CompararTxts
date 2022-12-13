string[] texto1 = File.ReadAllLines(@"C:\Users\felip\Documents\DocumentosComparar\texto1.txt");
string[] texto2 = File.ReadAllLines(@"C:\Users\felip\Documents\DocumentosComparar\texto2.txt");
int contador1 = 0;
int contador2 = 0;

Console.WriteLine("Documento 1: ");
foreach (string linhas1 in texto1)
    {
    contador1++;
    }
    Console.WriteLine("{0} linhas",contador1);
    Console.WriteLine("Documento 2: ");
foreach (string linhas2 in texto2)
    {
    contador2++;
    }                            
Console.WriteLine("{0} linhas", contador2);          

    if(contador1 == contador2)
    {
        for( int i = 0; i < contador1; i++)
        {
            
            if (texto1[i] == texto2[i])
            {
                Console.WriteLine("As linhas {0} são iguais.",i);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("As linhas {0} são diferentes:",i);
                Console.WriteLine("{0} // {1}", texto1[i], texto2[i]);
                Console.WriteLine("");
            }
            
        }
    }                    
    else              
    {
        Console.WriteLine("Os documentos NÃO possuem a mesma quantidade de linhas.");
    }
    
    Console.ReadKey();
    Console.WriteLine("TECLA PRESSIONADA");


string[] texto1 = File.ReadAllLines(@"C:\Users\felip\Documents\DocumentosComparar\texto1.txt");
string[] texto2 = File.ReadAllLines(@"C:\Users\felip\Documents\DocumentosComparar\texto2.txt");

Console.WriteLine("Conteúdo do primeiro documento: ");
foreach (string linhas1 in texto1)
{
    
    Console.WriteLine(linhas1);
}
Console.WriteLine("===============================");
Console.WriteLine("Conteúdo do segundo documento: ");
foreach (string linhas2 in texto2)
    {
    Console.WriteLine(linhas2);
    }
Console.ReadKey();
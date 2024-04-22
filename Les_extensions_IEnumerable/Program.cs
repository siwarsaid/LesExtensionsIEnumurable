using System.Diagnostics.CodeAnalysis;
using System.Linq;
namespace Les_extensions_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabEntiers = { 10 , 17 , 30 , 15 , 7 };
            Console.Write("Entrez la valeur de n : ");
            int n = Int32.Parse(Console.ReadLine());
            
            if (!tabEntiers.Any(x => x < n))
            {
                Console.WriteLine($"Y a pas des entiers inferieur ou egale a {n}, Entrez une autre valeur");
            }
            else
            {
             
                var moy = tabEntiers.Where(x => x <= n).Average();
                Console.WriteLine();


                Console.Write("Le tableau d'entiers :");
                tabEntiers.Select(x => { Console.Write(x + "  "); return x; }).ToList();
                Console.WriteLine();

                Console.Write("La moyenne est : " + moy);
                Console.WriteLine();
            }
        }
    }
}

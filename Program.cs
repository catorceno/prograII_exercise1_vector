using System; 
namespace _2.vector_exercise{
    class Program {
        static void Main(string[] args){
            // Ejercicio 1: compareVectors 
            Console.WriteLine("E1 -> ");
            Vector v1 = new Vector();
            Vector v2 = new Vector();
            v1.insertElement(0, 1);
            v1.insertElement(1, 2);
            v2.insertElement(0, 2);
            v2.insertElement(1, 1);
            Console.Write("v1 = "); v1.printVector();
            Console.Write("v2 = "); v2.printVector();
            Console.WriteLine(v1.compareVectors(v2));

            // Ejercicio 2: union en v1
            Console.WriteLine();
            Console.WriteLine("E2 -> ");
            v1.insertElement(2, 3);
            v1.insertElement(3, 4); 
            v2.insertElement(2, 0); 
            Console.Write("v1 = "); v1.printVector(); // 1, 2, 3, 4
            Console.Write("v2 = "); v2.printVector(); // 2, 1, 0 -> se ordeno en compareVectors.
            v1.union(v2);
            Console.Write("v1 = "); v1.printVector(); // 0, 1, 2, 3, 4

            // Ejercicio 3: subconjunto
            Console.WriteLine();
            Console.WriteLine("E3 -> ");
            Console.Write("v1 = "); v1.printVector(); // 0, 1, 2, 3, 4
            Console.Write("v2 = "); v2.printVector(); // 0, 1, 2
            Console.WriteLine(v1.subconjunto(v2));
            Console.WriteLine(v2.subconjunto(v1));

            // Ejercicio 4: deleteDuplicates
            Console.WriteLine();
            Console.WriteLine("E4 -> ");
            v1.insertElement(2, 2); 
            v1.insertElement(3, 1);
            v1.insertElement(4, 2);
            v1.insertElement(5, 3); 
            Console.Write("v1 = "); v1.printVector();  // 0, 1, 2, 1, 2, 3, 2, 3, 4
            v1.deleteDuplicates();
            Console.Write("v1 = "); v1.printVector(); // 0, 1, 2, 3, 4

        }
    }
}
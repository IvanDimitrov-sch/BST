using System.Data;

namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void Ex4()
        {
            Random r = new Random();
            BinarySearchTree tree = new BinarySearchTree();
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                int k = r.Next(10, 100);
                if (!array.Contains(k)) { array[i] = k; }

            }
            foreach (int i in array)
            {
                tree.Insert(i);
                Console.WriteLine(i);
            }
            Console.WriteLine("Min is");
            Console.WriteLine(tree.SearchMin());
        }
        static void Ex5()
        {
            Random r = new Random();
            BinarySearchTree tree = new BinarySearchTree();
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                int k = r.Next(10, 100);
                if (!array.Contains(k)) { array[i] = k; }

            }
            foreach (int i in array)
            {
                tree.Insert(i);
                Console.WriteLine(i);
            }
            Console.WriteLine("Floor is");
            Console.WriteLine(tree.SearchFloor(50));
        }
    }
}

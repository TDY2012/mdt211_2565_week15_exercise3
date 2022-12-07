using System;

class Program
{
    static void Main(string[] args)
    {
        BinaryTree<string> tree = new BinaryTree<string>();
        int level = int.Parse(Console.ReadLine());
        int nodeCount = (int)Math.Pow(2, level+1) - 1;

        string inputNode;
        while(nodeCount > 0)
        {
            inputNode = Console.ReadLine();
            tree.Add(inputNode);
            nodeCount--;
        }

        string searchNode = Console.ReadLine();
        tree.GetAllOpponents(searchNode);
    }
}
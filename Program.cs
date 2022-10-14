
using System.Runtime.InteropServices;
using Trees;

namespace Program
{
    class Program
    {
        private static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);
            Node node8 = new Node(40);
        

            //node1.left = node2;
            //node1.right = node3;
            //node1.add(2, "left");
            //node1.add(3, "right");
            //Console.WriteLine(node1.left.data);
            //Console.WriteLine(node1.right.data);

            ////Console.WriteLine(node1.left.data);
            ////Console.WriteLine(node1.right.data);
            ////node1.left = node4;
            ////Console.WriteLine(node1.left.data);
            ////Console.WriteLine(node1.right.data);

            //node1.inOrder();
            //node1.preOrder();
            //node1.postOrder();

            //Console.WriteLine("");

            //node1.print2();

            Tree tree1 = new Tree();
            tree1.insert(node1, "left", node1);
            //Console.WriteLine("Node1 ID: " + node1.id);
            tree1.insert(node2, "left", node1);
            //Console.WriteLine("Node2 ID: " + node2.id);
            tree1.insert(node3, "right", node1);
            //Console.WriteLine("Node3 ID: " + node3.id);
            tree1.insert(node4, "left", node2);
            //Console.WriteLine("Node4 ID: " + node4.id);
            tree1.insert(node5, "right", node2);
            //Console.WriteLine("Node5 ID: " + node5.id);
            tree1.insert(node6, "left", node3);
            //Console.WriteLine("Node6 ID: " + node6.id);
            tree1.insert(node7, "right", node3);
            //Console.WriteLine("Node7 ID: " + node7.id);
            tree1.insert(node8, "left", node4);
            //Console.WriteLine("Node8 ID: " + node8.id);

            //Console.WriteLine("Printing List:");

            tree1.printTree();

            tree1.height();
            //tree1.delete(7);

            //tree1.update(7, 70);

            //tree1.inOrder();

            //tree1.preOrder();

            //tree1.postOrder();

            //Console.WriteLine(tree1.select(6) + " " + tree1.select(6).data + " " + tree1.select(6).left + " " + tree1.select(6).right); 
        }
    }
}


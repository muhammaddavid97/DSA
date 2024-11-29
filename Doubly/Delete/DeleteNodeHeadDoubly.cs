using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Doubly.Delete
{
    public class DeleteNodeHeadDoubly
    {
        public static void main()
        {

            Node node = new Node();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);
            node.pushNode(7);
            node.pushNode(0);

            Console.WriteLine("Menampilkan node linkedlist");
            node.printNode();

            Console.WriteLine("Menghapus node head");
            node.deleteNodeHeadDoubly();
            node.printNode();
        }
    }

    class Node
    {
        public Node head { get; set; }
        private int data { get; set; }
        private Node next { get; set; }
        private Node prev { get; set; }

        public void pushNode(int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (this.head == null)
            {
                newNode.next = null;
                newNode.prev = null;
                this.head = newNode;
                return;
            }

            newNode.next = this.head;
            this.head = newNode;
        }

        public void deleteNodeHeadDoubly()
        {
            
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Node is empty");
                return;
            }

            this.head.prev = null;
            this.head = temp.next;
        }
        public void printNode()
        {
            Node temp = this.head;

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}

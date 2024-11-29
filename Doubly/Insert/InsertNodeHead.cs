using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Doubly.Insert
{
    public class InsertNodeHead
    {
        public static void main()
        {
            Node node = new Node();

            node.pushNode(1);
            node.pushNode(5);
            node.pushNode(3);
            node.pushNode(2);

            Console.WriteLine("Menambahkan node baru di head");
            Console.WriteLine(node.insertNodeHead(6));

            Console.WriteLine("Menampilkan node list");
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

        public int insertNodeHead(int value)
        {
            Node newNode = new Node();
            newNode.data = value;

            newNode.next = this.head;
            this.head = newNode;

            return newNode.data;
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

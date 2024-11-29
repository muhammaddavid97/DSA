using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Singly.Insert
{
    public class NodeHead
    {
        public static void main()
        {
            Node node = new Node();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);

            Console.WriteLine("Menampilkan node linkedlist");
            node.printNode();

            Console.WriteLine("Menambahkan node pada head");
            node.insertHeadNode(-4);
            node.printNode();
        }
    }

    class Node
    {
        public Node head { get; set; }
        private int data { get; set; }
        public Node next { get; set; }
        public void pushNode(int value)
        {
            Node newNode = new Node();
            newNode.data = value;

            if (this.head == null)
            {
                newNode.next = null;
                this.head = newNode;
                return;
            }

            newNode.next = this.head;
            this.head = newNode;
        }

        public void insertHeadNode(int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            int size = 0;
            Node temp = this.head;

            while (temp != null) 
            {
                size++;

                temp = temp.next;
            }

            if (size <= 0)
            {
                Console.WriteLine("Node is empty");
                return;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
            }

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

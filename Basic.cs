using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial
{
    public class Basic
    {
        public static void main()
        {
            Node node = new Node();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);

            node.printNode();
        }
    }

    class Node
    {
        public Node head {  get; set; }

        private int data;

        private Node next { get; set; }

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

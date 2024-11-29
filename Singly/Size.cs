using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Singly
{
    public class SizeNode
    {
        public static void main()
        {
            Node node = new Node();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);
            node.pushNode(7);
            node.pushNode(0);

            Console.WriteLine("Panjang node list = " + node.getSize());
        }
    }

    class Node
    {
        public Node head { get; set; }
        private int data { get; set; }
        private Node next { get; set; }

        public void pushNode(int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (this.head == null)
            {
                newNode.next = null;
                this.head = newNode;
                return;
            }

            newNode.next = this.head;
            this.head = newNode;
        }

        public int getSize()
        {
            Node temp = this.head;
            int length = 0;

            while (temp != null)
            {
                length++;
                temp = temp.next;
            }

            return length;
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

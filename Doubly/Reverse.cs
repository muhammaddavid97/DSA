using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Doubly
{
    public class Reverse
    {
        public static void main()
        {
            Node2 node = new Node2();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);
            node.pushNode(7);
            node.pushNode(0);

            Node2 head = node.head;

            Console.WriteLine("Sebelum node reverser");
            node.printNode(head);

            Console.WriteLine("Setelah node reverse");
            node.reverse();
            node.printNode(head);
        }
    }

    class Node2
    {
        public Node2 head { get; set; }
        private int data { get; set; }
        private Node2 next { get; set; }
        private Node2 prev { get; set; }

        public void pushNode(int data)
        {
            Node2 newNode = new Node2();
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

        public void reverse()
        {
            Node2 temp = this.head;
            Node2 swapp = null;

            while (temp != null) 
            {
                swapp = temp.prev;
                temp.prev = temp.next;
                temp.next = swapp;

                temp = temp.prev;
            }

            if (swapp != null) 
            {
                this.head = swapp.prev;
            }
        }
        public void printNode(Node2 head)
        {

            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Doubly
{
    public class Traversal
    {
        public static void main()
        {
            Node node = new Node();

            node.pushNode(1);
            node.pushNode(5);
            node.pushNode(3);
            node.pushNode(2);

            Console.WriteLine("Forward traversal");
            node.forwardTraversal();
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

        public void forwardTraversal()
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

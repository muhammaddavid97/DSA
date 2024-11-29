using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Singly
{
    public class ReverseNode
    {
        public static void main()
        {
            Node3 node = new Node3();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);
            node.pushNode(7);
            node.pushNode(0);

            Console.WriteLine("Sebelum node reverser");
            node.printNode();

            Console.WriteLine("Setelah node reverse");
            node.reverseNode();
            node.printNode();
        }
    }

    class Node3
    {
        public Node3 head { get; set; }
        private int data { get; set; }
        private Node3 next { get; set; }


        public void pushNode(int data)
        {
            Node3 newNode = new Node3();
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

        public void reverseNode()
        {
            Node3 temp = this.head;
            Node3 prev = null;

            while (temp != null)
            {
                Node3 front = temp.next;
                temp.next = prev;
                prev = temp;

                temp = front;
            }

            this.head = prev;
        }

        public void printNode()
        {
            Node3 temp = this.head;

            while (temp != null)
            {
                Console.WriteLine(temp.data);

                temp = temp.next;
            }
        }
    }
}

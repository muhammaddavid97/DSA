using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Doubly.Delete
{
    public class DeleteNodePositionDoubly
    {
        public static void main()
        {

            Node2 node = new Node2();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);
            node.pushNode(7);
            node.pushNode(0);

            Console.WriteLine("Menampilkan node linkedlist");
            node.printNode();

            Console.WriteLine("Menghapus node head");
            node.deleteNodePositionDoubly(2);
            node.printNode();
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

        public void deleteNodePositionDoubly(int value)
        {
            Node2 temp = this.head;
            Node2 prev = null;

            if (this.head == null)
            {
                Console.WriteLine("Node is empty");
                return;
            }

            while (temp != null)
            {
                if (temp.data == value)
                {
                    temp.prev = prev;
                    prev.next = temp.next;
                    break;
                }

                prev = temp;
                temp = temp.next;
            }
        }
        public void printNode()
        {
            Node2 temp = this.head;

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}

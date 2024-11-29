using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Singly.Delete
{
    public class DeleteNodeEnd
    {
        public static void main()
        {
            Node3 node = new Node3();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);
            node.pushNode(7);
            node.pushNode(0);

            Console.WriteLine("Menampilkan node linkedlist");
            node.printNode();

            Console.WriteLine("Menghapus node terkahir");
            node.deleteNodeEnd();
            node.deleteNodeEnd();
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

        public void deleteNodeEnd()
        {
            if (this.head == null)
            {
                Console.WriteLine("Node is empty");
                return;
            }

            Node3 temp = this.head;

            while (temp.next.next != null)
            {
                temp = temp.next;
            }

            temp.next = null;
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

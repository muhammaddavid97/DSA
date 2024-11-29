using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Singly.Insert
{
    public class InsertNodeEnd
    {
        public static void main()
        {
            Node3 node = new Node3();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);

            Console.WriteLine("Menampilkan node linkedlist");
            node.printNode();

            Console.WriteLine("Menambahkan node baru pada posisi terakhir");
            node.insertNodeEnd(0);
            node.printNode();
        }
    }

    class Node3
    {
        public Node3 head { get; set; }
        private int data { get; set; }
        public Node3 next { get; set; }

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

        public void insertNodeEnd(int data)
        {
            Node3 newNode = new Node3();
            newNode.data = data;

            Node3 temp = this.head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            newNode.next = null;
            temp.next = newNode;
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

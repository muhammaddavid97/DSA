using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Singly.Insert
{
    public class InsertNodeWithPosition
    {
        public static void main()
        {
            Node2 node = new Node2();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);

            Console.WriteLine("Menampilkan node linkedlist");
            node.printNode();

            Console.WriteLine("Menambahkan node baru pada posisi tertentu");
            node.insertNodeWithPosition(1, 7);
            node.printNode();
        }
    }

    class Node2
    {
        public Node2 head { get; set; }
        private int data { get; set; }
        public Node2 next { get; set; }

        public void pushNode(int value)
        {
            Node2 newNode = new Node2();
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

        public void insertNodeWithPosition(int value, int data)
        {
            Node2 newNode = new Node2();
            newNode.data = data;

            if (this.head == null)
            {
                Console.WriteLine("Node is empty");
                return;
            }
            
            Node2 temp = this.head;

            while (temp != null) 
            {
                if (temp.data == value) 
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                    break;
                }

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

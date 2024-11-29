using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Doubly.Insert
{
    public class InsertNodeEndDoubly
    {
        public static void main()
        {
            Node3 node = new Node3();

            node.pushNode(1);
            node.pushNode(5);
            node.pushNode(3);
            node.pushNode(2);

            Console.WriteLine("Menambahkan node baru pada posisi terakhir");
            Console.WriteLine(node.insertNodeEnd(6));

            Console.WriteLine("Menampilkan node list");
            node.printNode();
        }
    }

    class Node3
    {
        public Node3 head { get; set; }
        private int data { get; set; }
        private Node3 next { get; set; }
        private Node3 prev { get; set; }

        public void pushNode(int data)
        {
            Node3 newNode = new Node3();
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

        public int insertNodeEnd(int data) 
        {
            Node3 newNode = new Node3();
            newNode.data = data;

            Node3 temp = this.head;

            while(temp.next != null) 
            {
                temp = temp.next;
            }

            newNode.prev = temp;
            newNode.next = null;
            temp.next = newNode;

            return newNode.data;
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

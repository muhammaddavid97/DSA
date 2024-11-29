using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Doubly.Insert
{
    public class InsertNodeWithPositionDoubly
    {
        public static void main()
        {
            Node2 node = new Node2();

            node.pushNode(1);
            node.pushNode(5);
            node.pushNode(3);
            node.pushNode(2);

            Console.WriteLine("Menambahkan node baru berdasarkan position");
            Console.WriteLine(node.insertNodePosition(6, 3));

            Console.WriteLine("Menampilkan node list");
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
        public int insertNodePosition(int data, int value)
        {
            Node2 newNode = new Node2();
            newNode.data = data;

            Node2 temp = this.head;

            while (temp != null)
            {
                if (temp.data == value)
                {
                    newNode.next = temp.next;
                    newNode.prev = temp;
                    temp.next = newNode;
                    break;
                }

                temp = temp.next;
            }

            return newNode.data;
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

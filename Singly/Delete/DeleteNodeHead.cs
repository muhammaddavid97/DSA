using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListTutorial.Singly.Insert;

namespace LinkedListTutorial.Singly.Delete
{
    public class DeleteNodeHead
    {
        public static void main() 
        {
            Node node = new Node();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);

            Console.WriteLine("Menampilkan node linkedlist");
            node.printNode();

            Console.WriteLine("Menghapus node pada awal list");
            node.deleteNodeBeginning();
            node.printNode();
        }
    }

    class Node 
    {
        public Node head { get; set; }
        private int data { get; set; }
        public Node next { get; set; }

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
        public void deleteNodeBeginning() 
        {
            
            if (this.head == null) 
            {
                Console.WriteLine("Node is empty");
                return;
            }

            Node temp = this.head;
            this.head = temp.next;
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

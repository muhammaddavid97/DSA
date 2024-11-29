using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Sorting
{
    public class SelectionSort
    {
        public static void main()
        {
            Node2 node = new Node2();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);
            node.pushNode(7);
            node.pushNode(0);

            //Console.WriteLine("Sebelum node reverser");
            //node.printNode();

            node.SelectionSort();
            node.printNode();
        }
    }

    class Node2
    {
        public Node2 head { get; set; }
        private int data { get; set; }
        private Node2 next { get; set; }

        public void pushNode(int data)
        {
            Node2 newNode = new Node2();
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

        public void SelectionSort()
        {
            Node2 curr = this.head;

            while (curr.next != null)
            {
                Node2 min = curr;
                Node2 next = curr.next;

                while (next != null) 
                {

                    if (min.data > next.data) 
                    {
                        min = next;
                    }

                    next = next.next;
                }

                int swapp = curr.data;
                curr.data = min.data;
                min.data = swapp;

                curr = curr.next;
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

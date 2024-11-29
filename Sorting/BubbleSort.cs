using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial.Sorting
{
    public class BubbleSort
    {
       public static void main()
       {
            Node node = new Node();

            node.pushNode(3);
            node.pushNode(1);
            node.pushNode(2);
            node.pushNode(7);
            node.pushNode(0);

            //Console.WriteLine("Sebelum node reverser");
            //node.printNode();

            node.bubbleSort();
            node.printNode();
        }
    }

    class Node
    {
        public Node head { get; set; }
        private int data { get; set; }
        private Node next { get; set; }

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

        public void bubbleSort()
        {
            Node temp = this.head;

            while (temp != null) 
            {
                Node tempL = temp;
                Node tempR = temp.next;
                
                while(tempR != null) 
                {
                    if (tempL.data > tempR.data) 
                    {
                        int swapp = tempL.data;
                        tempL.data = tempR.data;
                        tempR.data = swapp;
                    }

                    tempR = tempR.next; 
                }

                temp = temp.next;
            }
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

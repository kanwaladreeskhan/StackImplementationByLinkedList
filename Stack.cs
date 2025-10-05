using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackImplementationByLinkedList
{
    internal class Stack
    {
        Node top;
        public Stack() {
            top = null;
        }
        public bool IsEmpty()
        {
            return (top == null);
           
        }
        public void Push(int data)
        {

            Node newnode = new Node(data);
            if (top == null)
            {
                top = newnode;
                return;
            }
            Console.WriteLine("{0} is pushed to stack!", data);
            newnode.next = top;
            top.prev = newnode;
            top = newnode;
        }
        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow!");
                return;
            }
            Console.WriteLine("{0} is popped to stack!", top.data);
            top = top.next;
            top.prev = null;
          
        }
        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow!");
                return;
            }
            Console.WriteLine("The top Element is {0}", top.data);
        }
        public void display()
        {
            Console.WriteLine("The stack elements are:");
            Node temp = top;
                while (temp!=null)
                {
                    Console.Write(temp.data + "  ");
                    temp = temp.next;
                }
                Console.WriteLine();
            
        }
        public void Count()
        {
            Node temp = top;
            int count = 0;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            Console.WriteLine("The total number of elememts in stack is {0}", count);

        }
    }
   }
 

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementationByLinkedList
{
    internal class Node
    {
        public int data;
        public Node next;
        public Node prev;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
             this.prev = null;
        }
    }
}

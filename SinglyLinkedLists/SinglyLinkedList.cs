﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        private SinglyLinkedListNode firstNode;
        public SinglyLinkedList()
        {
            // NOTE: This constructor isn't necessary, once you've implemented the constructor below.
        }

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            throw new NotImplementedException();
        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void AddAfter(string existingValue, string value)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(string value)
        {
            throw new NotImplementedException();
        }

        public void AddLast(string value)
        {
            if (firstNode == null)
            {
                firstNode = new SinglyLinkedListNode(value);
                return;
            }

            SinglyLinkedListNode node = this.firstNode;
            while (true)
            {
                if (node.Next == null)
                {
                    node.Next = new SinglyLinkedListNode(value);
                    break;
                }
                node = node.Next;
            }
        }

        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1).
        public int Count()
        {
            throw new NotImplementedException();
        }

        public string ElementAt(int index)
        {
            SinglyLinkedListNode node = this.firstNode;
            if (node == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }
            return node.Value;
        }

        public string First()
        {
            if (firstNode == null)
            {
                return null;
            }
            else
            {
                return firstNode.Value;
            }
        }

        public int IndexOf(string value)
        {
            throw new NotImplementedException();
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
        }

        // HINT 1: You can extract this functionality (finding the last item in the list) from a method you've already written!
        // HINT 2: I suggest writing a private helper method LastNode()
        // HINT 3: If you highlight code and right click, you can use the refactor menu to extract a method for you...
        public string Last()
        {

            if (this.firstNode == null)
            {
                return null;
            }
            int counter = 0;
            SinglyLinkedListNode node = firstNode;
            while (true)
            {
                if (node.Next == null)
                {
                    return node.ToString();
                }
                node = node.Next;
            }
        }

        public override string ToString()
        {
            if (this.firstNode == null)
            {
                return "{ }";
            }
            StringBuilder listString = new StringBuilder("{ \"");
            SinglyLinkedListNode node = this.firstNode;
            while (true)
            {
                listString.Append(node.ToString());
                if (node.Next == null)
                {
                    break;
                }
                listString.Append("\", \"");
                node = node.Next;
            }
            listString.Append("\" }");
            return listString.ToString();
        }

        public void Remove(string value)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public string[] ToArray()
        {
            SinglyLinkedListNode node = firstNode;
            if (node == null)
            {
                return new string[] { };
            }
            List<string> list = new List<string> { };
            while (true)
            {
                list.Add(node.Value);
                if (node.Next == null)
                {
                    break;
                }
                else
                {
                    node = node.Next;
                } 
            }
            return list.ToArray<string>();
        }
    }
}

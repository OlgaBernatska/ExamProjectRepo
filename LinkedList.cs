using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public class LinkedList <T> : ILinkedList <T>, IPrintable
    {
        Node<T> node = null;
        int ListSize = 0;

        public void AddFirst(T value)
        {
            if (node == null)
            {
                node = new Node<T>(null, value, null);
                ListSize++;
            }
            else
            {
                node = First();
                Node <T> temp = new Node<T>(null, value, node);
                node.prevNode = temp;                  
                ListSize++;
            }
        }

        public void AddLast(T value)
        {
            if (node == null)
            {
                node = new Node<T>(null, value, null);
                ListSize++;
            }
            else
            {
                node = Last();
                Node<T> temp = new Node<T>(node, value, null);
                node.nextNode = temp;
                ListSize++;
            }
        }

        public void Remove(T value)
        {
            Node<T> node = First();
            while (node != null)
            {
                if (!value.Equals(node.dataNode))
                {
                    node = node.nextNode;
                }
                else break;               
            }            
            if (node != null)
            {
                ListSize--;
                if (ListSize == 0)
                {                                       
                    node = null;
                }

                else if (node.prevNode == null)
                {
                    RemoveFirst();
                }
                else if (node.nextNode == null)
                {
                    RemoveLast();
                }
                else
                {
                    node = node.prevNode;
                    node.nextNode = node.nextNode.nextNode;
                    node = node.nextNode.nextNode;
                    node.prevNode = node.prevNode.prevNode;
                }                
            }
        }

        public void RemoveFirst()
        {
            node = First();
            node = node.nextNode;            
            node.prevNode = null;
            ListSize--;            
        }

        public void RemoveLast()
        {
            node = Last();
            node = node.prevNode;
            node.nextNode = null;
            ListSize--;
        }

        public bool Find(T value)
        {
            Node<T> temp = First();
            while (temp != null)
                {
                    if (value.Equals(temp.dataNode))
                    {
                        return true;
                    }
                    temp = temp.nextNode;
                }
                return false;
        }

        public int Lenght()
        {
            return ListSize;
        }

        public Node<T> First()
        {
            while (true)
                if (node == null)
                {
                    return null;
                }
                else if (node.prevNode == null)
                {
                    return node;
                }
                else
                {
                    node = node.prevNode;
                }              
        }

        public Node<T> Last()
        {
            while (true)
                if (node == null)
                {
                    return null;
                }
                else if (node.nextNode == null)
                {
                    return node;
                }
                else
                {
                    node = node.nextNode;
                }
        }

        public void Print()
        {
            Node<T> temp2 = First();
            if (temp2 == null)
            {
                Console.WriteLine ("List is empty");
            }
            else
            {
                while (temp2 != null)
                {
                    Console.WriteLine(temp2.dataNode);
                    temp2 = temp2.nextNode;
                }
            }                         
        }
    }
}

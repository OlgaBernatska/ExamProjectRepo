using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public class Node<T>
    {
        public Node <T> prevNode = null; 
        public T dataNode = default(T);
        public Node <T> nextNode = null;

        public Node (Node <T> prevNode, T dataNode, Node <T> nextNode)
            {
                this.prevNode = prevNode;
                this.dataNode = dataNode;
                this.nextNode = nextNode;
            }
        //public Node <T> prevNode
        //{
        //    get { return Node <T> prevNode; }
        //    set { prevNode = value; }
        //}

        //public T elementNode
        //{
        //    get { return elementNode; }
        //    set { elementNode = value; }
        //}

        //public T following
        //{
        //    get { return following; }
        //    set { following = value; }
        //}
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Core
{
    public class SinglyLinkedList<T>
    {
        private SimpleNode<T>? _head;

        public SinglyLinkedList()
        {
            _head = null;
        }

        public void InsertAtBeginning(T data)
        {
            var newNode = new SimpleNode<T>(data);
            newNode.Next = _head;
            _head = newNode;
        }

        public void InsertAtEnd(T data)
        {
            var newNode = new SimpleNode<T>(data);
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                var current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void PrintList()
        {
            var current = _head;
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.Write("null");
            Console.WriteLine();
        }

        public bool Contains(T data)
        {
            SimpleNode<T> current = _head!;
            while (current != null)
            {
                if (current.Data!.Equals(data))
                {
                    return true;
                }
                current = current.Next!;
            }
            return false;
        }

        public void Remove(T data)
        {
            if (_head == null)
            {
                return;
            }

            if (_head.Data!.Equals(data))
            {
                _head = _head.Next;
                return;
            }
            
            SimpleNode<T> current = _head;
            while (current.Next != null && !current.Next.Data!.Equals(data))
            {
                current = current.Next;
            }
        }
    }
}

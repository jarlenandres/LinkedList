using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleList
{
    public class DoubleLinkedList<T>
    {
        private DoubleNode<T>? _head;
        private DoubleNode<T>? _tail;

        public DoubleLinkedList()
        {
            _tail = null;
            _head = null;
        }

        public void InsertAtBeginning(T data)
        {
            var newNode = new DoubleNode<T>(data);
            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head.Prev = newNode;
                _head = newNode;
            }
        }

        public void InsertAtEnd(T data)
        {
            var newNode = new DoubleNode<T>(data);
            if (_tail == null)
            {
                _tail = newNode;
                _head = newNode;
            }
            else
            {
                newNode.Prev = _tail;
                _tail.Next = newNode;
                _tail = newNode;
            }
        }

        public string GetForward()
        {
            var outpot = string.Empty;
            var current = _head;
            while (current != null)
            {
                outpot += $"{current.Data} <=> ";
                current = current.Next;
            }
            return outpot;
        }

        public string GetBackward()
        {
            var outpot = string.Empty;
            var current = _tail;
            while (current != null)
            {
                outpot += $"{current.Prev} <=> ";
                current = current.Prev;
            }
            return outpot;
        }
    }
}

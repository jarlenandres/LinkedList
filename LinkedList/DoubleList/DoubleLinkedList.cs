﻿using System;
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
            var output = string.Empty;
            var current = _head;
            while (current != null)
            {
                output += $"{current.Data} <=> ";
                current = current.Next;
            }
            return output.Substring(0, output.Length - 5);
        }

        public string GetBackward()
        {
            var output = string.Empty;
            var current = _tail;
            while (current != null)
            {
                output += $"{current.Data} <=> ";
                current = current.Prev;
            }
            return output.Substring(0, output.Length - 5);
        }

        public void Remove(T data)
        {
            var current = _head;
            while (current != null)
            {
                if (current.Data!.Equals(data))
                {
                    if (current.Prev != null)
                    {
                        current.Prev.Next = current.Next;
                    }
                    else
                    {
                        _head = current.Next;
                    }
                    if (current.Next != null)
                    {
                        current.Next.Prev = current.Prev;
                    }
                    else
                    {
                        _tail = current.Prev;
                    }
                    break;
                }
                current = current.Next;
            }
        }
    }
}

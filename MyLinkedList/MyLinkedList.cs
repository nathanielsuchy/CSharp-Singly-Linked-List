using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinkedList
{
    public class MyLinkedList
    {
        public MyLinkedListNode head;
        public MyLinkedListNode tail;
        public int size = 0;

        public MyLinkedList()
        {

        }

        public int Get(int index)
        {
            if (index > (size - 1))
            {
                return -1;
            }
            else
            {
                MyLinkedListNode currentNode = head;

                for (int i = 0; i < index; i++)
                {
                    if (i == index)
                    {
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.next;
                    }
                }

                return currentNode.data;
            }
        }

        public void AddAtHead(int val)
        {
            MyLinkedListNode newNode = new MyLinkedListNode(val);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }

            size++;
        }

        public void AddAtTail(int val)
        {
            MyLinkedListNode newNode = new MyLinkedListNode(val);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }

            size++;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > size)
            {
                return;
            }

            // Add to head
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            if (index == size)
            {
                AddAtTail(val);
                return;
            }

            MyLinkedListNode currentNode = head;
            int i = 0;
            while (i < (index - 1))
            {
                currentNode = currentNode.next;
                i++;
            }

            MyLinkedListNode newNode = new MyLinkedListNode(val);
            MyLinkedListNode nextNode = currentNode.next;

            newNode.next = nextNode;

            currentNode.next = newNode;

            size++;
        }

        public void DeleteAtIndex(int index)
        {
            if (index >= size || index < 0)
            {
                return;
            }

            MyLinkedListNode currentNode = head;
            int i = 0;

            // Delete Head
            if (index == 0)
            {
                head = head.next;
                size--;
                return;
            }

            // Delete Tail
            if (index == (size-1))
            {
                while (i < (index - 1))
                {
                    currentNode = currentNode.next;
                    i++;
                }
                tail = currentNode;
                currentNode.next = null;
                size--;
                return;
            }

            // Delete middle node
            while (i < (index - 1))
            {
                currentNode = currentNode.next;
                i++;
            }
            currentNode.next = currentNode.next.next;
            size--;
        }
    }
}

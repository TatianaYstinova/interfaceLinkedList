using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public class LinkedList:ILinkedList
    {
        public INode Root { get; set; }// корень узла
        

        public LinkedList(INode root)
        {
            Root = root;
        }
       
        public int GetLength()
        {
           int count = 0;
            INode temp =this.Root;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }


        public INode GetNodeByIndex(int index)
        {
            INode nodeToReturn = this.Root;

            if( index < 0 || nodeToReturn == null)
            {
                return null;
            }
            int currentIndex = 0;

            while (nodeToReturn != null && currentIndex < index)
            {
                nodeToReturn = nodeToReturn.next;
                currentIndex++;
            }

            return nodeToReturn;
        }
        public void DeleteNodeByIndex(int indexToDelete)
        {
            if (indexToDelete == 0)
            {
                this.Root = this.Root.next;
            }
            else
            {
                INode deletedNodeParent = this.Root;

                for (int i = 1; i < indexToDelete; i++)
                {
                    deletedNodeParent = deletedNodeParent.next;
                }

                deletedNodeParent.next = deletedNodeParent.next.next;
            }
        }
        public void insertNodeByIndex(int index, INode node)
        {
            if(index >= this.GetLength())
            {
                throw new IndexOutOfRangeException("Позиция для вставки превышает длину списка");
            }
            if(this.Root == null)
            {
                if(index == 0)//вставка в начало
                {
                    this.Root = node;

                    return;
                }
                else
                {
                    throw new IndexOutOfRangeException("Список пустой");
                }
            }

            INode current = this.Root;
            INode previous = null;
            int currentIndex = 0;

            while (current != null && currentIndex < index) 
            {
                previous = current;
                current = current.next;
                currentIndex++;
            }
            // Вставляем узел в середину или в конец списка
            
            previous.next = node;
            node.next = current;
        }
        public void pushNode(INode node)
        {
            INode current = this.Root;
            
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = node;
        }
        public void deleteLast()
        {
            INode current = this.Root;
            INode previous = null;

            while(current != null && current.next != null)
            {
                previous = current;
                current = current.next;
            }
            if(previous != null)
            {
                previous.next = null;
            }
            else
            {
                this.Root = null;
            }
        }
        public void addToStart(INode node)
        {
            node.next = this.Root;
            this.Root = node;
        }
        public void deleteFirst()
        {
            if(this.Root == null)
            {
                Console.WriteLine("Связанный список пустой, нечего удалять");
                return;
            }
            else
            {
                this.Root = this.Root.next;
            }
        }
        public void reverse()
        {
            if(this.Root == null || this.Root.next == null)
            {
                return;
            }

            INode current = this.Root;//текущий
            INode previous = null;// предыдущий
            INode next = null;

            while (current != null ) 
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
               
            }
            this.Root = previous;
           
        }
        public void sortAscend()
        {
            INode current = this.Root;
            INode previous = null;

            if( current == null || current.next == null) 
            {
                return;
            }

            int Length = GetLength();

            for( int i = 0; i < Length - 1; i++)
            {
                current = this.Root;
                previous = null;

                for (int j = 0; j < Length - 1 - i; j++)
                {
                    if (current != null && current.value > current.next.value)
                    {

                        INode nextNode = current.next;
                        if (previous != null)
                        {
                            previous.next = nextNode;
                        }
                        else
                        {
                            this.Root = nextNode;
                        }

                        current.next = nextNode.next;
                        nextNode.next = current;
                        previous = nextNode;

                    }
                    else
                    {
                        previous = current;
                        current = current.next;
                    }
                   
                }
            }
        }
        public void sortDescend()
        {
            INode current = this.Root;
            INode previous = null;

            if (current == null || current.next == null)
            {
                return;
            }

            int Length = GetLength();

            for (int i = 0; i < Length - 1; i++)
            {
                current = this.Root;
                previous = null;

                for (int j = 0; j < Length - 1 - i; j++)
                {
                    if (current != null && current.value < current.next.value)
                    {

                        INode nextNode = current.next;
                        if (previous != null)
                        {
                            previous.next = nextNode;
                        }
                        else
                        {
                            this.Root = nextNode;
                        }

                        current.next = nextNode.next;
                        nextNode.next = current;
                        previous = nextNode;

                    }
                    else
                    {
                        previous = current;
                        current = current.next;
                    }
                }
            }
        }
        public override string ToString () 
        {
            INode curent = this.Root;
            string value =" ";

            while(curent != null)
            {
                value += curent.value + " ";
                curent = curent.next;
            }
            return value.ToString();
        }
    }
}

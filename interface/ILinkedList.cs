using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public interface ILinkedList
    {
        public INode Root { get; set; }// корень узла
        public INode GetNodeByIndex(int index);
        public void DeleteNodeByIndex(int index);
        public void insertNodeByIndex(int index, INode node);
        public void pushNode(INode node);
        public void deleteLast();
        public void addToStart(INode node);
        public void deleteFirst();
        public void reverse();
        public void sortAscend();
        public void sortDescend();
        public int GetLength();
    


    }

}

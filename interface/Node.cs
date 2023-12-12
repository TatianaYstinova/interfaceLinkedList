using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public class Node:INode
    {
        public int value { get; set; }// значение
        public INode next { get; set; }
        public Node(int value)
        {
            this.value = value;
        }
    }
}


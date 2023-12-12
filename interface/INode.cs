using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public interface INode//узел
    {
        public int value { get; set; }// значение
        public INode next { get; set; }
       
    }
}

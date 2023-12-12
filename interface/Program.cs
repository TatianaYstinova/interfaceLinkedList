using Lesson;
using System.Collections.Generic;


ILinkedList linked = new LinkedList(new Node(10));
linked.pushNode(new Node(1));
linked.pushNode(new Node(-9));
linked.pushNode(new Node(5));

//Console.WriteLine(linked.GetLength());

//Console.WriteLine(linked.GetNodeByIndex(2).value);
//Console.WriteLine(linked);
//linked.DeleteNodeByIndex(1);
//Console.WriteLine(linked.GetNodeByIndex(2).value);
//Console.WriteLine(linked);

//linked.deleteFirst();
//Console.WriteLine(linked);
//linked.deleteLast();
//linked.deleteLast();
//linked.deleteLast();
//Console.WriteLine(linked);

//linked.DeleteNodeByIndex(3);
//Console.WriteLine(linked);

//linked.insertNodeByIndex(2,(new Node(7)));
//Console.WriteLine(linked);


//Console.WriteLine(linked);
//linked.sortAscend();
//Console.WriteLine(linked);

Console.WriteLine(linked);
linked.sortDescend();
Console.WriteLine(linked);
using System;

namespace LinkedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DoubleLinkedList list = new DoubleLinkedList();
            //doubleLinked.insertFront(doubleLinked, 5);
            //doubleLinked.insertFront(doubleLinked, 2);
            //doubleLinked.insertFront(doubleLinked, 6);
            list.addNode(list, 12);
            list.addNode(list, 55);
            list.addNode(list, 34);
            list.addNode(list, 21);
            list.addNode(list, 3);
            //list.insertFront(list, 4);

            list.getIndex(1);

            //list.printLinkedList();


        }
    }
}

using System;
namespace LinkedList
{
    public class DoubleLinkedList
    {
        
        public Node head; 

        public void addNode(DoubleLinkedList list, int data){
            Node node = new Node(data);

            if(list.head == null){
                node.prev = null;
                list.head = node;
                return;
            }

            Node lastNode = getLastNode(list);
            lastNode.next = node;
            lastNode.prev = lastNode;


        }

        public void moveNode(Node node){
            
        }

        public int getIndex(int index)
        {
            Node current = head;
            var counter = 1;

            while(current != null){
                if(counter == index){
                    Console.WriteLine(current.data);
                    return current.data;
                }

                counter++;
                current = current.next;
            }

            return 0;
          
        }

        public Node getLastNode(DoubleLinkedList list){
            Node temp = list.head;

            while(temp.next != null){
                temp = temp.next;
            }

            return temp;
        }

        public void insertFront(DoubleLinkedList list, int data)
        {
            Node node = new Node(data);
            node.next = list.head;
            node.prev = null;

            if(list.head != null){
                list.head.prev = node;
            }

            list.head = node;
        }


        public void printLinkedList(){
            Node current = head;
            while (current != null){
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

    }

   
}

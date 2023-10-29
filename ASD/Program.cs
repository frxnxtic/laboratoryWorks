using Laba1.Laba2;
using Laba1.Laba3;
using Laba1.Laba4;
using System;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> myArrayList = new(10);
            myArrayList.AddHead(1);
            myArrayList.AddAfter(1, 2);
            myArrayList.AddAfter(2, 3);

            // Display the items in the ArrayList
            Console.WriteLine("Items in the ArrayList:");
            foreach (int item in myArrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine();

            DoubleLinkedList<int> myDoubleLinkedList = new();
            myDoubleLinkedList.AddHead(1);
            myDoubleLinkedList.AddAfter(1, 2);
            myDoubleLinkedList.AddAfter(2, 3);
            Console.WriteLine("Items in the DoubleLinkedList:");
            foreach (int item in myDoubleLinkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine();

            ArrayStack<int> myArrayStack = new(10);
            myArrayStack.Push(1);
            myArrayStack.Push(2);
            myArrayStack.Push(3);

            // Display the items in the ArrayStack
            Console.WriteLine("Items in the ArrayStack:");
            foreach (int item in myArrayStack)
            {
                Console.WriteLine(item);
            }

            myArrayStack.Pop();
            myArrayStack.Pop();

            // Display the items in the ArrayStack after removal
            Console.WriteLine("Items in the ArrayStack after removal:");
            foreach (int item in myArrayStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine();

            LinkedStack<int> myLinkedStack = new();
            myLinkedStack.Push(1);
            myLinkedStack.Push(2);
            myLinkedStack.Push(3);

            // Display the items in the LinkedStack
            Console.WriteLine("Items in the LinkedStack:");
            foreach (int item in myLinkedStack)
            {
                Console.WriteLine(item);
            }

            myLinkedStack.Pop();
            myLinkedStack.Pop();

            // Display the items in the LinkedStack after removal
            Console.WriteLine("Items in the LinkedStack after removal:");
            foreach (int item in myLinkedStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine();

            ArrayQueue<int> myArrayQueue = new(10);
            myArrayQueue.Enqueue(1);
            myArrayQueue.Enqueue(2);
            myArrayQueue.Enqueue(3);

            // Display the items in the ArrayQueue
            Console.WriteLine("Items in the ArrayQueue:");
            foreach (int item in myArrayQueue)
            {
                Console.WriteLine(item);
            }

            myArrayQueue.Dequeue();
            myArrayQueue.Dequeue();

            // Display the items in the ArrayQueue after removal
            Console.WriteLine("Items in the ArrayQueue after removal:");
            foreach (int item in myArrayQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine();

            LinkedQueue<int> myLinkedQueue = new();
            myLinkedQueue.Enqueue(1);
            myLinkedQueue.Enqueue(2);
            myLinkedQueue.Enqueue(3);

            // Display the items in the LinkedQueue
            Console.WriteLine("Items in the LinkedQueue:");
            foreach (int item in myLinkedQueue)
            {
                Console.WriteLine(item);
            }

            myLinkedQueue.Dequeue();
            myLinkedQueue.Dequeue();

            // Display the items in the LinkedQueue after removal
            Console.WriteLine("Items in the LinkedQueue after removal:");
            foreach (int item in myLinkedQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine();

            ArraySet<int> myArraySet = new(10);
            myArraySet.Add(1);
            myArraySet.Add(2);
            myArraySet.Add(3);

            // Display the items in the ArraySet
            Console.WriteLine("Items in the ArraySet:");
            foreach (int item in myArraySet)
            {
                Console.WriteLine(item);
            }

            myArraySet.Remove(1);
            myArraySet.Remove(2);

            // Display the items in the ArraySet after removal
            Console.WriteLine("Items in the ArraySet after removal:");
            foreach (int item in myArraySet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine();

            LinkedSet<int> myLinkedSet = new();
            myLinkedSet.Add(1);
            myLinkedSet.Add(2);
            myLinkedSet.Add(3);

            // Display the items in the LinkedSet
            Console.WriteLine("Items in the LinkedSet:");
            foreach (int item in myLinkedSet)
            {
                Console.WriteLine(item);
            }

            myLinkedSet.Remove(1);
            myLinkedSet.Remove(2);

            // Display the items in the LinkedSet after removal
            Console.WriteLine("Items in the LinkedSet after removal:");
            foreach (int item in myLinkedSet)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


        }
    }
}

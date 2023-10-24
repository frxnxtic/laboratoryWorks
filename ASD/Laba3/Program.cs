using Laba1.Laba3;

public class Program
{
    public static void Main()
    {
        ArrayQueue<int> arrayStack = new ArrayQueue<int>(10);
        LinkedQueue<int> linkedStack = new LinkedQueue<int>();
        arrayStack.Enqueue(1);
        arrayStack.Enqueue(2);
        arrayStack.Enqueue(3);
        arrayStack.Enqueue(4);
        arrayStack.Enqueue(5);
        arrayStack.Dequeue();
        arrayStack.Dequeue();
        arrayStack.Peek();
        linkedStack.Enqueue(1);
        linkedStack.Enqueue(2);
        linkedStack.Enqueue(3);
        linkedStack.Enqueue(4);
        linkedStack.Enqueue(5);
        linkedStack.Dequeue();
        linkedStack.Dequeue();
        linkedStack.Peek();
        Console.WriteLine(arrayStack);
        Console.WriteLine(linkedStack);
    }
}
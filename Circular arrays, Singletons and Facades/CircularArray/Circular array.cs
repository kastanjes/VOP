using System;

namespace CircularArray;
class CircularArray<T>
{
    private T[] buffer;
    private int head = 0;
    private int tail = 0;
    private int count = 0;
    private int capacity;

    public CircularArray(int size)
    {
        capacity = size;
        buffer = new T[size];
    }

    public void Enqueue(T item)
    {
        if (count == capacity)
        {
            Console.WriteLine("Buffer is full!");
            return;
        }
        buffer[tail] = item;
        tail = (tail + 1) % capacity;
        count++;
    }

    public T Dequeue()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Buffer is empty!");
        }
        T item = buffer[head];
        head = (head + 1) % capacity;
        count--;
        return item;
    }

    public void PrintBuffer()
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(buffer[(head + i) % capacity] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        CircularArray<int> circularQueue = new CircularArray<int>(5);
        
        circularQueue.Enqueue(1);
        circularQueue.Enqueue(2);
        circularQueue.Enqueue(3);
        circularQueue.PrintBuffer(); // Output: 1 2 3

        circularQueue.Dequeue();
        circularQueue.PrintBuffer(); // Output: 2 3

        circularQueue.Enqueue(4);
        circularQueue.Enqueue(5);
        circularQueue.Enqueue(6);
        circularQueue.PrintBuffer(); // Output: 2 3 4 5 6

        circularQueue.Enqueue(7); // Buffer is full!
    }
}

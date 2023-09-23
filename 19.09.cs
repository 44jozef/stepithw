#region Task1
/*
static void Swap<T>(ref T first,ref T second)
{
    T tmp = first;
    first = second;
    second = tmp;
}
Console.WriteLine("Enter your first number");
int Fnum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter your second number");
int Snum = Int32.Parse(Console.ReadLine());
Console.WriteLine($"Before swap: {Fnum},{Snum}"); 
Swap<int>(ref Fnum, ref Snum);
Console.WriteLine($"Swap: {Fnum},{Snum}");
*/
#endregion
#region Task2
/*
QueuePriority<int> queuepriority = new QueuePriority<int>();
queuepriority.Enqueue(5, 1);
queuepriority.Enqueue(2, 10);
queuepriority.Enqueue(4, 7);
while(!queuepriority.IsEmpty)
{
    var item = queuepriority.Dequeue();
    Console.WriteLine($"Dequeue: {item}" );
}
public class QueuePriority<T>
{
    private List<(T item, int priority)> element = new List<(T item, int priority)> ();
    public void Enqueue(T item,int priority)
    {
        element.Add ((item,priority));
        element.Sort((x,y) => x.priority.CompareTo (y.priority));
    }
    public T Dequeue()
    {
        if(IsEmpty)
            throw new InvalidOperationException ("Empty");
        T item = element[0].item;
        element.RemoveAt(0);   
        return item;
    }
    public bool IsEmpty => element.Count == 0;
    public int Count => element.Count;
}
*/
#endregion
#region Task3
/*
CurcularQueue<int> curcularQueue = new CurcularQueue<int>(3);
curcularQueue.Enqueue(2);
curcularQueue.Enqueue(10);
curcularQueue.Enqueue(9);
Console.WriteLine("Dequeu" + curcularQueue.Dequeue());

public class CurcularQueue<T>
{
    private T[] elements;
    private int capacity;
    private int front;
    private int back;
    public CurcularQueue(int capacity)
    {
        this.capacity = capacity;
        elements = new T[capacity];
        front = back - 1;
    }
    public void Enqueue (T item)
    {
        if (IsFull)
            throw new InvalidOperationException("Queue full");
        else if (IsEmpty)
            front = back = 0;
        else
            back = (back + 1) % capacity;
        elements[back] = item;
    }
    public T Dequeue()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Queue empty");
        T item = elements[front];
        if (front == back)
            front = back = -1;
        else
            front = (front + 1) % capacity;
        return item;
    }
    public bool IsEmpty => front == -1;
    public bool IsFull => (back + 1) % capacity == front;
}
*/
#endregion
#region Task4
/*
SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
singlyLinkedList.AddStart(0);
singlyLinkedList.AddStart(1);
singlyLinkedList.AddStart(2);
singlyLinkedList.AddStart(3);
singlyLinkedList.AddEnd(5);
var tmp = singlyLinkedList.Head;
while (tmp != null)
{
    Console.WriteLine(tmp.Value);
    tmp = tmp.Next;
}


public class LLNode<T>
{
    public T Value { get; set; }
    public LLNode<T> Next { get; set; }
    
    public LLNode(T value)
    {
        Value = value;
        Next = null;
    }
}
public class SinglyLinkedList<T>
{
    public LLNode<T> Head { get; set; }
    public LLNode<T> Last { get; set; }

    public void AddStart(T value)
    {
        var newNum = new LLNode<T>(value);
        if (Head == null)
            Head = Last = newNum;
        else
        {
            newNum.Next = Head;
            Head = newNum;
        }
    }
    public void AddEnd(T value)
    {
        var newNum = new LLNode<T>(value);
        if (Last == null)
            Head = Last = newNum;
        else
        {
            Last.Next = newNum;
            Last = newNum;
        }
    }
}
*/
#endregion
#region Task5
/*
SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
singlyLinkedList.AddStart(0);
singlyLinkedList.AddStart(1);
singlyLinkedList.AddStart(2);
singlyLinkedList.AddStart(3);
singlyLinkedList.AddEnd(5);
var tmp = singlyLinkedList.Head;
while (tmp != null)
{
    Console.WriteLine(tmp.Value);
    tmp = tmp.Next;
}


public class DoubleLLNode<T>
{
    public T Value { get; set; }
    public DoubleLLNode<T> Previous { get; set; }
    public DoubleLLNode<T> Next { get; set; }

    public DoubleLLNode(T value)
    {
        Value = value;
        Next = null;
        Previous = null;
    }
}
public class SinglyLinkedList<T>
{
    public DoubleLLNode<T> Head { get; set; }
    public DoubleLLNode<T> Last { get; set; }

    public void AddStart(T value)
    {
        var newNum = new DoubleLLNode<T>(value);
        if (Head == null)
            Head = Last = newNum;
        else
        {
            newNum.Next = Head;
            Head.Previous = newNum;
            Head = newNum;
        }
    }
    public void AddEnd(T value)
    {
        var newNum = new DoubleLLNode<T>(value);
        if (Last == null)
            Head = Last = newNum;
        else
        {
            Last.Next = newNum;
            Last.Previous = newNum;
            Last = newNum;
        }
    }
}
*/
#endregion
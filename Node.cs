using System;

/// <summary>
/// Summary description for Class1
/// </summary>

public class Node<T>
{
    public Node<T> Next { get; set; }
    public T Data {get; set; }

public Node(T t)
{
    Next = null;
    Data = t;
}
}


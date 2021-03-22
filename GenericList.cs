using System;

/// <summary>
/// Summary description for Class1
/// </summary>
//泛型链表类
public class GenericList<T>
{
    private Node<T> head;
    private Node<T> tail;
    public GenericList()
    {
        tail = head = null;
    }
    
public Node<T> Head
    {
        get => head;
    }

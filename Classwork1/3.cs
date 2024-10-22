using System;
using System.Collections.Generic;

public class ArrayOfLists<T>
{

    private List<T>[] arrayOfLists;


    public ArrayOfLists(int size)
    {
        arrayOfLists = new List<T>[size];
        for (int i = 0; i < size; i++)
        {
            arrayOfLists[i] = new List<T>();
        }
    }


    public void Add(int index, T item)
    {
        if (index >= 0 && index < arrayOfLists.Length)
        {
            arrayOfLists[index].Add(item);
        }
        else
        {
            throw new IndexOutOfRangeException("Index out of bounds");
        }
    }


    public void Remove(int index, T item)
    {
        if (index >= 0 && index < arrayOfLists.Length)
        {
            arrayOfLists[index].Remove(item);
        }
        else
        {
            throw new IndexOutOfRangeException("Index out of bounds");
        }
    }


    public List<T> GetList(int index)
    {
        if (index >= 0 && index < arrayOfLists.Length)
        {
            return arrayOfLists[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Index out of bounds");
        }
    }


    public int Count
    {
        get { return arrayOfLists.Length; }
    }


    public void PrintAllLists()
    {
        for (int i = 0; i < arrayOfLists.Length; i++)
        {
            Console.Write($"List {i}: ");
            foreach (T item in arrayOfLists[i])
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

class Prog
{
    static void Main()
    {

        ArrayOfLists<int> arrayOfLists = new ArrayOfLists<int>(3);


        arrayOfLists.Add(0, 10);
        arrayOfLists.Add(0, 20);
        arrayOfLists.Add(1, 30);
        arrayOfLists.Add(2, 40);
        arrayOfLists.Add(2, 50);


        arrayOfLists.PrintAllLists();


        arrayOfLists.Remove(2, 40);
        arrayOfLists.PrintAllLists();


        List<int> list1 = arrayOfLists.GetList(1);
        Console.WriteLine("List 1: " + string.Join(", ", list1));
    }
}
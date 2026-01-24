/// <summary>
/// A basic implementation of a Queue
/// </summary>

using System.Collections.Generic;

public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        // FIX: Use Add() to put the person at the back of the list.
        // Insert(0) was putting them at the front, turning this into a Stack.
        _queue.Add(person);
    }
    public Person Dequeue()
    {
        if (IsEmpty())
        {
            throw new System.InvalidOperationException("Queue is empty");
        }

        var person = _queue[0];
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}
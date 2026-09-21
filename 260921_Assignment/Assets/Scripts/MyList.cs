using UnityEngine;

public class MyList<T>
{
    private T[] _items;
    private int _count;

    public int Count
    {
        get { return _count; }
    }

    public int Capacity
    {
        get { return _items.Length; }
    }

    public MyList()
    {
        _items = new T[] { };
    }

    public MyList(int capacity)
    {
        _items = new T[capacity];
    }

    public T Get(int index)
    {
        if (_items[index].Equals(default(T)))
        {
            return default(T);
        }
        else
        {
            return _items[index];
        }
    }

    public void Set(int index, T value)
    {
        _items[index] = value;
    }

    public string ToText()
    {
        string text = "";

        for (int i = 0; i < _count; i++)
        {
            if (i > 0)
            {
                text += ", ";
            }
            
            text += _items[i];
        }
        
        return text;
    }

    public void Add(T value)
    {
        if (Capacity.Equals(default(T)) || !_items[0].Equals(default(T)))
        {
            GrowIfFull();
        }
        
        _items[Count] = value;
        _count++;
        
        Debug.Log($"Test : {value}");
    }

    public void Insert(int index, T value)
    {
        if (Capacity.Equals(default(T)) || !_items[Count - 1].Equals(default(T)))
        {
            GrowIfFull();
        }
        
        for(int i = Count; i > index; i--)
        {
            _items[Count - i] = _items[Count - 1 - i];
        }
        
        _items[index] = value;
        _count++;
    }

    private void GrowIfFull()
    {
        if (Count < Capacity)
        {
        }
        else
        {
            if (Capacity.Equals(default(T)))
            {
                _items = new T[4];
            }
            else//  if (!_items[Count].Equals(default(T)))
            {
                _items = new T[Capacity * 2];
            }
        }
    }
}

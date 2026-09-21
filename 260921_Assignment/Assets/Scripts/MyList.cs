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
        if (!_items[_items.Length - 1].Equals(default(T)))
        {
            
        }
    }

    public void Insert(int index, T value)
    {
        
    }

    private void GrowIfFull()
    {
        
    }
}

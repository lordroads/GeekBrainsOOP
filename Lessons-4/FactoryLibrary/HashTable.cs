using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary;

internal class HashTable
{
    private Dictionary<int, Building> _hashTable;

    public HashTable()
    {
        _hashTable = new Dictionary<int, Building>();
    }

    public void Add(Building item)
    {
        _hashTable.Add(item.Number, item);
    }
    public bool Delete(int key)
    {
        return _hashTable.Remove(key);
    }
}

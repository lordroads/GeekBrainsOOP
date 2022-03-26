using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBuildings;

public class BuildingFactory
{
    private static HashTable _hashTable = new HashTable();

    private BuildingFactory() { }

    public static Building CreatedBuilding()
    {
        Building building = new Building();
        _hashTable.Add(building);
        return building;
    }
    public static Building CreatedBuilding(int number, float hieghtInMeters, int quantityFloor, int quantityApartaments, int quantityEntrance)
    {
        Building building = new Building(number, hieghtInMeters, quantityFloor, quantityApartaments, quantityEntrance);
        _hashTable.Add(building);
        return building; ;
    }
    public static bool Delete(int key)
    {
        return _hashTable.Delete(key);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBuildings;

public class Building
{
    private static int _counter;

    private int _number;
    private float _hieghtInMeters;
    private int _quantityFloor;
    private int _quantityApartaments;
    private int _quantityEntrance;

    public int Number
    {
        get { return _number; }
        set { _number = value; }
    }
    public float HieghtInMeters
    {
        get { return _hieghtInMeters; }
        set { _hieghtInMeters = value; }
    }
    public int QuantityFloor
    {
        get { return _quantityFloor; }
        set { _quantityFloor = value; }
    }
    public int QuantityApartaments
    {
        get { return _quantityApartaments; }
        set { _quantityApartaments = value; }
    }
    public int QuantityEntrance
    {
        get { return _quantityEntrance; }
        set { _quantityEntrance = value; }
    }

    public Building()
    {
        _number = GetNumberBuilding();
    }
    public Building(int number, float hieghtInMeters, int quantityFloor, int quantityApartaments, int quantityEntrance)
    {
        _number = number;
        _hieghtInMeters = hieghtInMeters;
        _quantityFloor = quantityFloor;
        _quantityApartaments = quantityApartaments;
        _quantityEntrance = quantityEntrance;
    }

    public float CalculatingTheHeightOfTheFloor()
    {
        return _hieghtInMeters / _quantityFloor;
    }
    public int QuantityOfApartmentsInTheEntrance()
    {
        return _quantityApartaments / _quantityEntrance;
    }
    public int QuantityOfApartmentsPerFloor()
    {
        return _quantityApartaments / _quantityFloor;
    }
    public int QuantityOfApartamentsInEntrancePerFloor()
    {
        return QuantityOfApartmentsInTheEntrance() / _quantityFloor;
    }
    private int GetNumberBuilding()
    {
        return ++_counter;
    }
}
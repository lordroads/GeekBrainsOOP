using FactoryBuildings;

bool resultDelete;

//тестирование функционала классов с использованием свойств.
Building defaultBuilding = BuildingFactory.CreatedBuilding();

defaultBuilding.HieghtInMeters = 100;
defaultBuilding.QuantityEntrance = 10;
defaultBuilding.QuantityFloor = 21;
defaultBuilding.QuantityApartaments = 1000;

Console.WriteLine($"Number - {defaultBuilding.Number}");
Console.WriteLine($"Hieght floor - {defaultBuilding.CalculatingTheHeightOfTheFloor()}");
Console.WriteLine($"Quantity apartaments in entrance - {defaultBuilding.QuantityOfApartmentsInTheEntrance()}");
Console.WriteLine($"Quantity apartanents per floor - {defaultBuilding.QuantityOfApartmentsPerFloor()}");
Console.WriteLine($"Quantity apartamtnts in entrance per floor - {defaultBuilding.QuantityOfApartamentsInEntrancePerFloor()}");
resultDelete = BuildingFactory.Delete(defaultBuilding.Number);

//тестирование функционала классов с использованием конструктора.
Building specificBuilding = BuildingFactory.CreatedBuilding(7, 45, 4, 50, 4);

Console.WriteLine($"Number - {specificBuilding.Number}");
Console.WriteLine($"Hieght floor - {specificBuilding.CalculatingTheHeightOfTheFloor()}");
Console.WriteLine($"Quantity apartaments in entrance - {specificBuilding.QuantityOfApartmentsInTheEntrance()}");
Console.WriteLine($"Quantity apartanents per floor - {specificBuilding.QuantityOfApartmentsPerFloor()}");
Console.WriteLine($"Quantity apartamtnts in entrance per floor - {specificBuilding.QuantityOfApartamentsInEntrancePerFloor()}");
resultDelete = BuildingFactory.Delete(specificBuilding.Number);

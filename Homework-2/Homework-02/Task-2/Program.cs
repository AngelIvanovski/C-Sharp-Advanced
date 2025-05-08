using Task_2.Classes;

Vehicle motorBike = new Motorbike();
Vehicle car = new Car();
Vehicle plane = new Airplane();
Vehicle boat = new Boat();

motorBike.DisplayInfo();
car.DisplayInfo();
plane.DisplayInfo();
boat.DisplayInfo();

Motorbike motorBike2 = new Motorbike();
Car car2 = new Car();
Airplane plane2 = new Airplane();
Boat boat2 = new Boat();

motorBike2.Wheelie();
car2.Drive();
plane2.Fly();
boat2.Sail();
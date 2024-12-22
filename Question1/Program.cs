var car1 = new Car();
car1.make = "Tayota";
car1.model = "Camry";
car1.year = 2020;
car1.displayDetails();

var car2 = new Car();
car2.make = "Honda";
car2.model = "Civic";
car2.year = 2018;
car2.displayDetails();

Console.WriteLine(car1.displayDetails());
Console.WriteLine(car2.displayDetails());
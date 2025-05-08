using PetStore.Classes;

Console.WriteLine("Welcome to the Pet Store!");

PetStore<Dog> dogStore = new PetStore<Dog>();
dogStore.AddPet(new Dog("Rex", "Dog", 5, false, "Beef"));
dogStore.AddPet(new Dog("Luna", "Dog", 3, true, "Turkey"));

PetStore<Cat> catStore = new PetStore<Cat>();
catStore.AddPet(new Cat("Whiskers", "Cat", 4, true, 7));
catStore.AddPet(new Cat("Shadow", "Cat", 10, false, 6));


PetStore<Fish> fishStore = new PetStore<Fish>();
fishStore.AddPet(new Fish("Bubbles", "Fish", 1, "Yellow", "Tiny"));
fishStore.AddPet(new Fish("Finley", "Fish", 3, "Red and Black", "Large"));


dogStore.BuyPet("Rex");
catStore.BuyPet("Mici");

Console.WriteLine("----");
Console.WriteLine("Remaining Dogs:");
dogStore.PrintPets();

Console.WriteLine("----");
Console.WriteLine("Remaining Cats:");
catStore.PrintPets();

Console.WriteLine("----");
Console.WriteLine("Available Fish:");
fishStore.PrintPets();
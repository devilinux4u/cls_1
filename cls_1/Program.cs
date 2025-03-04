using cls_1;

Console.WriteLine("Hello, World!");

PolymorphismExample obj = new PolymorphismExample();
obj.Add(10, 5);
obj.Add(5.5f, 60.9f);
obj.Add("solo", "golo");


Animal d = new Dog();
d.Move();
d.Eat();
//d.Bark();

Console.WriteLine("optr ended");
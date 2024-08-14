using DZ_PaternPrototip2;
using System.Diagnostics;

Console.WriteLine("ДЗ паттерн Прототип - Животные ");
var stopWatch = new Stopwatch();
stopWatch.Start();

Dog original_dog = new("Большой и любимый", "охранять дом", "лаять", "такса", "черный", "Сосиска", 5);
Cat original_cat = new("Красивые, зеленые", "дворянская", "рыжий ","Кузя",10,"Сидеть на подоконике", "Кричать по утрам МЯУУУ");

Console.WriteLine("Исходный: {0}", original_dog.ToString());
Console.WriteLine("Исходный: {0}", original_cat.ToString());
stopWatch.Stop();
Console.WriteLine($"Тест выполнился за {stopWatch.ElapsedMilliseconds}мс...");

stopWatch.Start();
Dog dog_clone = original_dog.MyClone();
Cat cat_clone = original_cat.MyClone();
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Копия(DogMyClone):{0}", dog_clone.ToString());
Console.WriteLine("Копия(CatMyClone):{0}", cat_clone.ToString());
stopWatch.Stop();
Console.WriteLine($"Тест выполнился за {stopWatch.ElapsedTicks} ticks...");

stopWatch.Start();
var dog_ic_clone = original_dog.Clone();
var cat_ic_clone = original_cat.Clone();
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Копия(Clone):{0}", dog_ic_clone.ToString());
Console.WriteLine("Копия(Clone):{0}", cat_ic_clone.ToString());
stopWatch.Stop();
Console.WriteLine($"Тест выполнился за {stopWatch.ElapsedTicks}ticks...");
Console.ReadKey();

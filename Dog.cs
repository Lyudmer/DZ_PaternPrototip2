using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_PaternPrototip2
{
    public class Dog : Predators, IAnimalClone<Dog>, ICloneable
    {
        public Dog(string myleader, string myfunc, string mysound, string breed, string color, string name, int age) 
            : base(breed, color, name, age)
        {
            MyLeader = myleader;
            MyFunc = myfunc;
            MySound = mysound;
        }
        public string MyLeader { get; set; }
        public string MyFunc { get; set; }
        public string MySound { get; set; }
        public override string ToString()
        {

            return $":Пес {base.Name},возраст {base.Age}" +
                $"\n порода {base.Breed} окрас {base.Color} мой хозяин {MyLeader}" +
                $" \n  {base.MainFunction(MyFunc)} и {base.MakeSound(MySound)} ";
        }
        public new Dog MyClone()
        {
            return new(MyLeader,MyFunc,MySound,Breed, Color, Name, Age);
        }
        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

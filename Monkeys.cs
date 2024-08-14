using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_PaternPrototip2
{
    
        public class Monkeys : Primates, IAnimalClone<Monkeys>, ICloneable
        {
            public Monkeys(float weight,  string mysound, string color, string habitat, string name, int age)
                : base(color, habitat, name, age)
            {
                MyWeight = weight;
                MySound = mysound;
            }
            public float MySize { get; set; }
            public float MyWeight { get; set; }
            public string MySound { get; set; }
            public override string ToString()
            {

                return $":Лемур {base.Name},возраст {base.Age}" +
                    $"\n  вес {MyWeight} окрас {base.Color}" +
                    $" \n  {base.MyHabitat} и {base.MakeSound(MySound)} ";
            }

            public new Monkeys MyClone()
            {
                return new(MyWeight, MySound, MyHabitat, Color, Name, Age);
            }
            public new object Clone()
            {
                return this.MemberwiseClone();
            }
        }
    
}

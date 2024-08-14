using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_PaternPrototip2
{
    public class Predators: Animals, IAnimalClone<Predators>, ICloneable
    {
        public Predators(string breed,string color, string name,int age):base(name,age)
        {
            Breed = breed;
            Color = color;
        }
        public string Breed { get; set; }
        public string Color {  get; set; }
        public string MainFunction(string typefunc)
        {
            return typefunc;
        }

        public new Predators MyClone()
        {
          return  new(Breed, Color, Name, Age);
        }
        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

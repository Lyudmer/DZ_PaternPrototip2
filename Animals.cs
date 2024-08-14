

namespace DZ_PaternPrototip2
{
    public class Animals : IAnimalClone<Animals>, ICloneable
    {
        public Animals(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string MakeSound(string typesound)
        {
            return typesound;
        }
       
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Animals MyClone()
        {
            return new Animals(this.Name, this.Age);
        }

      
    }
}

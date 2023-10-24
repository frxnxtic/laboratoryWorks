namespace IZVP.Laba1.Abstract_Factory
{
    public abstract class Animal
    {
        public string name { get; set; }

        public virtual void Speak()
        {
            System.Console.WriteLine("Animal sound!");
        }
    }
}
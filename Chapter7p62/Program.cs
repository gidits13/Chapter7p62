namespace Chapter7p62
{
    class Car<T1>
    {
        public T1 Engine;
        public virtual void ChangePart<T2>(T2 newPart)
        { }
    }
    class  ElectricEngine
        {}
    class GasEngine
    { }
    
    class Battery
    { }

    class Differential
    { }

    class Wheel

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
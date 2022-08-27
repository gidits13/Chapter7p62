namespace Chapter7p62
{
    abstract public class Engine
        {}
    abstract public class CarPart
    { }
    class Car<T1> where T1: Engine
    {
        public T1 Engine;
        public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart
        { }
    }
    class  ElectricEngine: Engine
        {}
    class GasEngine: Engine
    { }
    
    class Battery: CarPart
    { }

    class Differential : CarPart
    { }

    class Wheel: CarPart
    { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
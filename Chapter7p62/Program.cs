namespace Chapter7p62
{
    abstract public class Engine
        {}
    abstract public class CarPart
    { }
    abstract class Car<TEngine> where TEngine: Engine
    {
        public TEngine Engine;
        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        { }
    }
    class ElectricCar: Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            
        }
    }
    class GasCar:Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            
        }
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
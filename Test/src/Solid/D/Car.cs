namespace Test.src.Solid.D
{
    public class Car
    {
        private Engine engine;

        public Car()
        {
            this.engine = new Engine();
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car Started.");
        }
    }    
}
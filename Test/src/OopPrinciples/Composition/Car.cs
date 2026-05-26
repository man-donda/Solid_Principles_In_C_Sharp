namespace Test.src.OopPrinciples.Composition
{
    public class Car
    {
        private Engine engine = new Engine();
        private Wheels wheels = new Wheels();
        private Seats seats = new Seats();
        private Chasis chasis = new Chasis();

        public void StartCar()
        {
            engine.Start();
            wheels.Rotate();
            seats.sit();
            chasis.Support();
            Console.WriteLine("Car is Started.");
        }
    }
}
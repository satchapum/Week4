namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.band = "Toyota";
            myCar.model = "Altis";
            myCar.numberOfDoors = 4;
            myCar.numberOfWheels = 4;

            Car newCar = new Car();
            newCar.band = "Honda";
            newCar.model = "Freed";
            newCar.numberOfDoors = 4;
            newCar.numberOfWheels = 4;

            DogDoor door = new DogDoor();
            door.Open();
            door.Close();
            Console.WriteLine("Door is open ? : {0}", door.IsOpen());

            PrintCarInformation(myCar);
            PrintCarInformation(newCar);
        }

        static void PrintCarInformation(Car car) {
            Console.WriteLine("**************************");
            Console.WriteLine("Band: {0}", car.band);
            Console.WriteLine("Model: {0}", car.model);
            Console.WriteLine("Number of Door: {0}", car.numberOfDoors);
            Console.WriteLine("Number of Wheels: {0}", car.numberOfWheels);
            Console.WriteLine(car.MoveForward());
            Console.WriteLine(car.MoveBackward());
            Console.WriteLine(car.Turn());
            Console.WriteLine(car.Stop());
            Console.WriteLine("**************************");
        }

    }
}
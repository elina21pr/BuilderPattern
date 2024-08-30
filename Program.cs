using BuilderPattern;
using System;

    static void Main(string[] args)
    {
    CarMechanikBuilder mechanik = new CarMechanikBuilder();

    SportCarBuild sportCarBuilder = new SportCarBuild();
    Car sportCar = mechanik.DrawUp(sportCarBuilder);
    Console.WriteLine("Спортивний автомобіль:");
    Console.WriteLine(sportCar.ToString());


    SUVBuilder suvbuilder = new SUVBuilder();
    Car suvCar = mechanik.DrawUp(suvbuilder);
    Console.WriteLine("Позашляховик:");
    Console.WriteLine(suvCar.ToString());


}
public abstract class CarBuild
{
    public Car Car { get; private set; }
    public void CreateCar()
    {
        Car = new Car();
    }
    public abstract void SetTiresCar();
    public abstract void SetTypeEngineCar();
    public abstract void SetTypeBodyCar();
    public abstract void SetGPSCar();
}

public class CarMechanikBuilder
{
    public Car DrawUp(CarBuild carBuild)
    {
        carBuild.CreateCar();
        carBuild.SetTiresCar();
        carBuild.SetTypeEngineCar();
        carBuild.SetTypeBodyCar();
        carBuild.SetGPSCar();

        return carBuild.Car;
    }
}

public class SportCarBuild : CarBuild
{
    public override void SetTiresCar()
    {
        this.Car.TiresCar = new TiresCar { TypeTiresCar = "Літні шини" };
    }

    public override void SetTypeEngineCar()
    {
        this.Car.EngineCar = new EngineCar { TypeEngineCar = "V8" };
    }

    public override void SetTypeBodyCar()
    {
        this.Car.BodyCar = new BodyCar { TypeBodyCar = "Купе" };
    }

    public override void SetGPSCar()
    {
        this.Car.GPSCar = new GPSCar();
    }
}

public class SUVBuilder : CarBuild
{
    public override void SetTiresCar()
    {
        this.Car.TiresCar = new TiresCar { TypeTiresCar = "Зимові шини" };
    }

    public override void SetTypeEngineCar()
    {
        this.Car.EngineCar = new EngineCar { TypeEngineCar = "Q5" };
    }

    public override void SetTypeBodyCar()
    {
        this.Car.BodyCar = new BodyCar { TypeBodyCar = "Позашляховик" };
    }

    public override void SetGPSCar()
    {
        this.Car.GPSCar = new GPSCar();
    }
}

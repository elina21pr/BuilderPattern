using System.Text;

namespace BuilderPattern
{
    public class TiresCar
    {
        public string TypeTiresCar { get; set; }
    }

    public class EngineCar
    {
        public string TypeEngineCar { get; set; }
    }

    public class BodyCar
    {
        public string TypeBodyCar { get; set; }
    }

    public class GPSCar { }

    public class Car
    {
        public TiresCar TiresCar { get; set; }
        public EngineCar EngineCar { get; set; }
        public BodyCar BodyCar { get; set; }
        public GPSCar GPSCar { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (TiresCar != null)
                sb.Append("Шини: " + TiresCar.TypeTiresCar + "\n");
            if (EngineCar != null)
                sb.Append("Двигун: " + EngineCar.TypeEngineCar + "\n");
            if (BodyCar != null)
                sb.Append("Кузов: " + BodyCar.TypeBodyCar + "\n");
            if (GPSCar != null)
                sb.Append("GPS: Наявний" + '\n');
            return sb.ToString();
        }
    }
}

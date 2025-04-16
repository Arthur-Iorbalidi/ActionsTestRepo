namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество объектов недвижимости (1-30): ");
            int count = int.Parse(Console.ReadLine());

            if (count < 1 || count > 30)
            {
                Console.WriteLine("Некорректное количество объектов.");
                return;
            }

            var properties = new RealEstate[count];
            int highValueCount = 0;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите данные для объекта {i + 1}:");

                Console.Write("Площадь (м²): ");
                int area = int.Parse(Console.ReadLine());

                Console.Write("Количество комнат: ");
                int rooms = int.Parse(Console.ReadLine());

                Console.Write("Этаж: ");
                int floor = int.Parse(Console.ReadLine());

                Console.Write("Тип недвижимости (квартира, дом, студия): ");
                string propertyType = Console.ReadLine();

                Console.Write("Состояние объекта (новое, хорошее, требует ремонта): ");
                string condition = Console.ReadLine();

                Console.Write("Расположение (центр, пригород, отдаленный район): ");
                string location = Console.ReadLine();

                properties[i] = new RealEstate(area, rooms, floor, propertyType, condition, location);
                decimal price = properties[i].CalculatePrice();

                Console.WriteLine($"Стоимость объекта {i + 1}: {Math.Round(price, 3)}");

                if (price > 10000000)
                    highValueCount++;
            }

            Console.WriteLine($"Количество объектов с высокой стоимостью (выше 10,000,000): {highValueCount}");
        }
    }
}

class TemperatureConverter{
   static void Main(){
      Console.WriteLine("Вас привествует приложение Конвертер температуры");
      Console.WriteLine("Выбирите единицу измерения,каторую хотите ввести:");
      Console.WriteLine("1.Цельси");
      Console.WriteLine("2.Кельвин");
      Console.WriteLine("3.Фаренгейт");
      Console.Write("Введите номер опции(1-3):");
      string? option = Console.ReadLine();
      Console.Write("Введите значение температуры:");
      double temperature = Convert.ToDouble(Console.ReadLine());
      switch(option)
      {
         case "1": 
            ConvertFromCelsius(temperature);
            break;
         case "2":
            ConvertFromFahrenheit(temperature);
            break;
         case "3":
            ConvertFromKelvin(temperature);
            break;              
         default:
            Console.WriteLine("Такого выбора нет");
            break;
      }
   }
   static void ConvertFromCelsius(double c)
   {
      double Fahrenheit =  (c * 9 / 5) + 32;
      double Kelvin =  c + 273.15;
      Console.WriteLine($"Фаренгейт:{Fahrenheit:F2}°F");
      Console.WriteLine($"Кельвин:{Kelvin:F2}°K");
   }
   static void ConvertFromFahrenheit(double f)
   {
      double Celsius =  (f - 32) * 5 / 9;
      double Kelvin = Celsius + 273.15;
      Console.WriteLine($"Цельси:{Celsius:F2}°C");
      Console.WriteLine($"Кельвин:{Kelvin:F2}°K");
   }
   static void ConvertFromKelvin(double k)
   {
      double Celsius = k - 273.15;
      double Fahrenheit = (Celsius * 9 / 5) + 32;
      Console.WriteLine($"Цельси:{Celsius:F2}°C");
      Console.WriteLine($"Фаренгейт:{Fahrenheit:F2}°F");
   }
}



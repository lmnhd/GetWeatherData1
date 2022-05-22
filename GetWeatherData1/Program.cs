// See https://aka.ms/new-console-template for more information


using GetWeatherData1;

DataParser parser = new DataParser();
string weatherdatastring = @"C:\Users\Jeannine\source\repos\GetWeatherData1\GetWeatherData1\data\weather.dat";


//parser.ParseWeatherOBJ(weatherdatastring);

WeatherOBJ testobj = new WeatherOBJ(weatherdatastring);
testobj.Parse(28);



Console.WriteLine("Hello, World!");

/*using System.Text.RegularExpressions;

Dictionary<String, int> spreads = new Dictionary<string, int>();

StreamReader objInput = new StreamReader("C:\\values.dat", System.Text.Encoding.Default);
string contents = objInput.ReadToEnd().Trim();
string[] split = System.Text.RegularExpressions.Regex.Split(contents, "\\s+", RegexOptions.None);
foreach (string s in split)
     {
   Console.WriteLine(s);
      }

Console.WriteLine("Hello, World!");*/

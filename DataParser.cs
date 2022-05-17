using System;
using System.Text.RegularExpressions;


public class DataParser
{
	public DataParser()
	{
	}

	public WeatherOBJ parseWeatherOBJ(String dataFile)
    {
		WeatherOBJ obj = new WeatherOBJ();
		Dictionary<String, int> data = ParseDatFile(dataFile);
		foreach (String s in data.Keys)
        {
			
        }
		

	}

	public Dictionary<String, int> ParseDatFile(String file)
    {
		

		Dictionary<String, int> spreads = new Dictionary<string, int>();

		StreamReader objInput = new StreamReader(file, System.Text.Encoding.Default);
		string contents = objInput.ReadToEnd().Trim();
		string[] split = System.Text.RegularExpressions.Regex.Split(contents, "\\s+", RegexOptions.None);
		foreach (string s in split)
		{
			spreads.Add(s, spreads.Count);
			//Console.WriteLine(s);
		}

		//Console.WriteLine("Hello, World!");
		return spreads;
	}


}

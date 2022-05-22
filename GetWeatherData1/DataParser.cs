using GetWeatherData1;
using System;
using System.Text.RegularExpressions;

public class DataParser
{
	private List<string> rows;
	private WeatherOBJ wob;
	public DataParser()
	{
	}

	public WeatherOBJ ParseWeatherOBJ(string dataFile)
	{
		
		Dictionary<string, string> data = ParseDatFile(dataFile);
		 wob = new WeatherOBJ(data);
		return wob;


	}
	public void GetDateData(int day)
    {
		//WeatherOBJ obj = new WeatherOBJ(data);
    }

	public Dictionary<string, string> ParseDatFile(String file)
	{


		Dictionary<string, string> spreads = new Dictionary<string, string>();

		StreamReader objInput = new StreamReader(file, System.Text.Encoding.Default);
		string contents = objInput.ReadToEnd().Trim();
		string[] split = System.Text.RegularExpressions.Regex.Split(contents, "\n+", RegexOptions.None);
		string[] valNames = new string[17];
		int[] charLocation = new int[50];
		int i = 0;
		string[] namesplit = new string[0];
		Dictionary<Object,Object> result = new Dictionary<object, object>();



		foreach (string row in split)
		{
			if (i == 0)
			{
			 namesplit = System.Text.RegularExpressions.Regex.Split(row, "\\s+", RegexOptions.None);
				int p = 0;
foreach (string s2 in namesplit)
                {
					charLocation[p] = row.IndexOf(s2);
					p++;
                }
				
			}

			if (i > 0)
			{
				/*string[] split2 = System.Text.RegularExpressions.Regex.Split(s, "\\s+", RegexOptions.None);
				int j = 0;*/
				int j = 0;
				string[] rowValueSplit = new string[row.Length];
				WeatherOBJ obj = new WeatherOBJ();
				

				foreach (string s2 in rowValueSplit)
				{
					spreads = new Dictionary<string, string>();

					if (j >= 0)
					{
                        spreads.Add(namesplit[j],s2);
					}

					j++;
					result.Add(spreads, "");
					
				}

				//spreads.Add(s, spreads.Count);
				//Console.WriteLine(s);
			}
			i++;
			//Console.WriteLine("Hello, World!");

		}
		int iterator = 0;
		foreach(string name in namesplit)
        {
			char val = rows[iterator++].ElementAt(charLocation[iterator]);
			spreads.Add(namesplit[iterator], val.ToString());

			//iterator++;
        }
		return spreads;
	}
}

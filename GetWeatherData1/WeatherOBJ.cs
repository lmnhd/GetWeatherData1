using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GetWeatherData1
{
    public class WeatherOBJ
    {
        private const string Separator = @"\n";

        //Dy MxT   MnT   AvT   HDDay  AvDP 1HrP TPcpn WxType PDir AvSp Dir MxS SkyC MxR MnR AvSLP
        private string[] rows;
        private string[] names;
        public WeatherOBJ(string data)
        {
            //rows = new List<string>();
           // rows = new string[50];

            StreamReader objInput = new StreamReader(data, System.Text.Encoding.Default);

            string contents = objInput.ReadToEnd().Trim();

            rows = System.Text.RegularExpressions.Regex.Split(contents, "\n+", RegexOptions.None);
           


            names = getNames(rows.ToList());
            
         
        }
        public void Parse(int DayNum)
        {
            PopuateFields(rows[DayNum], names, rows[0]);
        }

        //take a row and populate local fields with correct values
        private void PopuateFields(string row, string[] valNames, string valName)
        {
            foreach(string name in valNames)
            {
                int loc = valName.IndexOf(name)+1;
                string val = row.Substring(loc,6);
                switchVal(name, val.Replace(@" ", ""));
            }
        }
        private void switchVal(string n, string v)
        {
            switch (n)
            {
                case "Dy":
                    Dy = v;
                    break;
                case "MxT":
                    MxT = v;
                    break;
                case "MnT":
                    MnT = v;
                    break;
                case "AvT":
                    AvT = v;
                    break;
                case "HDDay":
                    HDDay = v;
                    break;
                case "AvDP":
                    AvDP = v;
                    break;
                case "1HrP":
                    HrP = v;
                    break;
                case "TPcpn":
                    TPcpn = v;
                    break;
                case "WxType":
                    WxType = v;
                    break;
                case "PDir":
                    PDir = v;
                    break;
                case "AvSp":
                    AvSp = v;
                    break;
                case "Dir":
                    Dir = v;
                    break;
                case "MxS":
                    MxS = v;
                    break;
                case "SkyC":
                    SkyC = v;
                    break;
                case "MxR":
                    MxR = v;
                    break;
                case "MnR":
                    MnR = v;
                    break;
                case "AvSLP":
                    AvSLP = v;
                    break;

            }
        }
        private void ParseDataToProperties(string nextRow)
        {
            //rows.Add(nextRow);
        }
        //Get "character starting point" from "this string"
        public int GetCharIndex(string characters, string str)
        {
           // int index = 0;
            int result = str.IndexOf(characters);


            return result;

        }

        public WeatherOBJ()
        {
        }

        public WeatherOBJ(Dictionary<string, string> data)
        {
            this.data = data;
        }

        public string Dy { get { return dy; }
            set { dy = value.Substring(1, 2); } }
        private string dy;
        public string MxT { get; set; }
        public string MnT { get; set; }
        public string AvT { get; set; }
        public string HDDay { get; set; }
        public string AvDP { get; set; }
        public string HrP { get; set; }
        public string TPcpn { get; set; }
        public string WxType { get; set; }
        public string PDir { get; set; }
        public string AvSp { get; set; }
        public string Dir { get; set; }
        public string MxS { get; set; }
        public string SkyC { get; set; }
        public string MxR
        {
            get { return mxR; }
            set { mxR = value.Substring(1, value.Length - 1); }
        }
        private string mxR;

        public string MnR
        {
            get { return mnR; }
            set { mnR = value.Substring(1, 3); }
        }
        private string mnR;
        public string AvSLP { get; set; }
        private readonly Dictionary<string, string> data;

        string[] valNames = new string[17];

        int[] charLocation = new int[50];
        int i = 0;

        string[] namesplit = new string[0];

        Dictionary<Object, Object> result = new Dictionary<object, object>();


        Dictionary<string, string> spreads = new Dictionary<string, string>();


        private string[] getNames(List<string> data)
        {






            
            foreach (string row in data)
            {
               
                
                    namesplit = System.Text.RegularExpressions.Regex.Split(row, "\\s+", RegexOptions.None);

                /* if (namesplit.Length > 0)
                 {

                 }*/
                int iter = 0;
                foreach (string s2 in namesplit)
                    {
                        charLocation[iter++] = row.IndexOf(s2);
                        
                    }

                break;
                
        }
            return namesplit;
    }

        
    }

   

   
}

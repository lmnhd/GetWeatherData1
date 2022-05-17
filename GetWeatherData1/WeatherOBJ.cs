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
        //Dy MxT   MnT   AvT   HDDay  AvDP 1HrP TPcpn WxType PDir AvSp Dir MxS SkyC MxR MnR AvSLP
        private List<string> rows;
        public WeatherOBJ(Dictionary<int, String> data)
        {
            rows = new List<string>();
            foreach (var row in data)
            {
                rows.Add(row.Value);
            }
            
        }

        private void ParseDataToProperties(string nextRow)
        {
            foreach(string section in nextRow.Split(@"\s"))
            {
                switch (section)
                {
                    
                }
            }
        }
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

        private String Dy;
        private String MxT;
        private String MnT;
        private String Avt;
        private String HDDay;
        private String AvDP;
        private String HrP;
        private String TPcpn;
        private String WxType;
        private String PDir;
        private String AvSp;
        private String Dir;
        private String MxS;
        private String SkyC;
        private String MxR;
        private String AvSLP;
        private Dictionary<string, string> data;
    }

   
}

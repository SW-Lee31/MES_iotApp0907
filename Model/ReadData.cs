using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iotApp0907.Model
{
    class ReadData
    {
        string temp;
        string he;
        string date;

        public ReadData(string temp, string he, string date)
        {
            this.temp = temp;
            this.he = he;
            this.date = date;
        }

        public string Temp { get => temp; set => temp = value; }
        public string He { get => he; set => he = value; }
        public string Date { get => date; set => date = value; }
    }
}

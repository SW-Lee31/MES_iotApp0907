using iotApp0907.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iotApp0907.Adapter
{
    class BaseAdapter
    {
        static List<ReadData> datalst;

        public static List<ReadData> dataInstance
        {
            get
            {
                if (datalst == null)
                {
                    datalst = new List<ReadData>();
                }
                return datalst;
            }
        }
    }
}

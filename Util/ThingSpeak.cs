using iotApp0907.Adapter;
using iotApp0907.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace iotApp0907.Util
{
    class ThingSpeak
    {
        const string url = "http://api.thingspeak.com/";
        const string APIKEY_WRITE = "TTNX9UP1GCA5981F";

        public bool sendDataToThingSpeak(string field1, string field2,
            string field3, string field4, string field5,
            string field6, string field7, string field8)
        {
            string sbQS = string.Empty;
            // http 통신
            sbQS += url + "update?key=" + APIKEY_WRITE;
            if (field1 != null)
            {
                sbQS += "&field1=" + HttpUtility.UrlEncode(field1);
            }
            if (field2 != null)
            {
                sbQS += "&field2=" + HttpUtility.UrlEncode(field2);
            }
            if (field3 != null)
            {
                sbQS += "&field3=" + HttpUtility.UrlEncode(field3);
            }
            if (field4 != null)
            {
                sbQS += "&field4=" + HttpUtility.UrlEncode(field4);
            }
            if (field5 != null)
            {
                sbQS += "&field5=" + HttpUtility.UrlEncode(field5);
            }
            if (field6 != null)
            {
                sbQS += "&field6=" + HttpUtility.UrlEncode(field6);
            }
            if (field7 != null)
            {
                sbQS += "&field7=" + HttpUtility.UrlEncode(field7);
            }
            if (field8 != null)
            {
                sbQS += "&field8=" + HttpUtility.UrlEncode(field8);
            }
            int res = Convert.ToInt32(postToThingSpeak(sbQS));
            if (res <= 0)
            {
                return false;
            }
            return true;
        }

        public string postToThingSpeak(string str)
        {
            string response = string.Empty;
            byte[] buf = new byte[8192];

            HttpWebRequest myRequest =
                (HttpWebRequest)WebRequest.Create(str);
            HttpWebResponse webResponse =
                (HttpWebResponse)myRequest.GetResponse();

            try
            {
                Stream myResponse = webResponse.GetResponseStream();
                int count = 0;
                do
                {
                    count = myResponse.Read(buf, 0, buf.Length);
                    if (count != 0)
                    {
                        response += Encoding.ASCII.GetString(buf, 0, count);
                    }
                } while (count > 0);
                return response;
            }
            catch (WebException e)
            {
                Console.WriteLine("응답 에러: " + e.Message);
            }
            return "0";
        }

        public void readThingSpeak()
        {
            string url = "https://api.thingspeak.com/channels/1499963/feeds.json?api_key=Y9L4VFAZPAG1JZMI&results=1";

            WebClient webclient = new WebClient();
            var data = webclient.DownloadString(url);
            dynamic feed = JsonConvert.DeserializeObject<dynamic>(data);
            List<dynamic> feeds = feed.feeds.ToObject<List<dynamic>>();
            Console.WriteLine(string.Format("채널 정보 : {0}", feed.channel.name));

            for (int i = 0; i < feeds.Count; i++)
            {
                string time = feeds[i].created_at;
                string temp_1 = feeds[i].field1;
                string humi_1 = feeds[i].field2;
                string temp_2 = feeds[i].field3;
                string humi_2 = feeds[i].field4;

                ReadData line_fir_data = new ReadData(temp_1, humi_1, time);
                BaseAdapter.dataInstance.Add(line_fir_data);
            }
        }
    }

    class ThingSpeakTimer
    {
        Timer timer;

        public ThingSpeakTimer(Timer timer)
        {
            this.timer = timer;
        }
        ~ThingSpeakTimer()
        {
            stoptimer();
        }

        public void stoptimer()
        {
            timer.Dispose();
        }
    }
}

using iotApp0907.Adapter;
using iotApp0907.Util;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Timer = System.Threading.Timer;
using Etimer = System.Windows.Forms.Timer;
using System.Media;

namespace iotApp0907
{
    public partial class MainUI : MaterialForm
    {
        ThingSpeak thingspeak_ele = new ThingSpeak();
        ThingSpeakTimer sTimer, rTimer;
        Etimer timer = new System.Windows.Forms.Timer();
        SoundPlayer snd;

        string[] temp = {"15", "22", "38", "41", "57", "63",
                "77", "84", "92", "104"};
        string[] humi = {"15", "22", "38", "41", "57", "63",
                "77", "84", "92", "104"};
        Random r = new Random();

        public MainUI()
        {
            InitializeComponent();
            sTimer = new ThingSpeakTimer(new Timer(new TimerCallback(writeHandler), null, 1000, 20000));
            rTimer = new ThingSpeakTimer(new Timer(new TimerCallback(readHandler), null, 2000, 20000));
            timer.Interval = 5000;
            timer.Tick += new EventHandler(but_refresh_Click);
            timer.Start();
        }

        void show_info()
        {
            output_date.Text = BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].Date;
            output_temp.Text = BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].Temp;
            output_he.Text = BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].He;
            tem_meter.Value = double.Parse(BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].Temp);
            he_meter.Value = double.Parse(BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].He);

            int temp_chk = int.Parse(BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].Temp);
            int humi_chk = int.Parse(BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].He);

            if (temp_chk >= 50 && humi_chk >= 75)
            {
                led_alarm.Color = Color.Red;
                led_alarm.Blink = true;
                led_alarm.BlinkInterval = 500;
                new SoundPlayer(@"Alarm.wav").Play();
                tem_meter.NeedleColor = Color.Red;
                he_meter.NeedleColor = Color.Red;
                led_display.Text = "Temp/Humi Is Too High";
            }
            else if (temp_chk >= 50 && humi_chk < 75)
            {
                led_alarm.Color = Color.OrangeRed;
                led_alarm.Blink = true;
                led_alarm.BlinkInterval = 1000;
                tem_meter.NeedleColor = Color.Red;
                he_meter.NeedleColor = Color.Green;
                led_display.Text = "Temp Is Too High";
            }
            else if (temp_chk < 50 && humi_chk >= 75)
            {
                led_alarm.Color = Color.OrangeRed;
                led_alarm.Blink = true;
                led_alarm.BlinkInterval = 1000;
                tem_meter.NeedleColor = Color.Green;
                he_meter.NeedleColor = Color.Red;
                led_display.Text = "Humi Is Too High";
            }
            else
            {
                led_alarm.Color = Color.Green;
                led_alarm.Blink = false;
                tem_meter.NeedleColor = Color.Green;
                he_meter.NeedleColor = Color.Green;
                led_display.Text = "No Problem Found";
            }

            /*if (int.Parse(BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].He) >= 50)
            {
                led_alarm.Color = Color.Red;
                tem_meter.NeedleColor = Color.Red;
                led_display.Text = "Humi Is Too High";
            }
            else
            {
                led_alarm.Color = Color.Green;
                tem_meter.NeedleColor = Color.Red;
                led_display.Text = "No Problem";
            }*/
        }

        void writeHandler(object args)
        {
            bool chk = thingspeak_ele.sendDataToThingSpeak(temp[r.Next(10)],
                    humi[r.Next(10)], temp[r.Next(10)], humi[r.Next(10)],
                    null, null, null, null);
            if (chk == true)
            {
                Console.WriteLine("데이터 전송 성공!");
            }
            else
            {
                Console.WriteLine("데이터 전송 실패!");
            }
        }

        void readHandler(object args)
        {
            thingspeak_ele.readThingSpeak();

            int temp = int.Parse(BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].Temp);
            int humi = int.Parse(BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].He);

            Console.WriteLine(string.Format("시간 : {0}", BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].Date));
            Console.WriteLine(string.Format("부품 1라인 온도 : {0}℃", BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].Temp));
            Console.WriteLine(string.Format("부품 1라인 습도 : {0}%", BaseAdapter.dataInstance[BaseAdapter.dataInstance.Count - 1].He));
            Console.WriteLine();

            Console.WriteLine("[부품 라인 모니터링 정보]");
            if (temp >= 50)
            {
                Console.WriteLine("생산 1라인 온도가 50℃ 이상입니다.");
                Console.WriteLine("알림 : 생산 1라인 에어컨 가동");
                Console.WriteLine();
            }
            /*else if (int.Parse(temp_1) <= 10)
            {
                Console.WriteLine("생산 1라인 온도가 10℃ 이하입니다.");
                Console.WriteLine("알림 : 생산 1라인 히터 가동");
                Console.WriteLine();
            }*/

            if (humi >= 75)
            {
                Console.WriteLine("생산 1라인 습도가 75% 이상입니다.");
                Console.WriteLine("알림 : 생산 1라인 제습기 가동");
                Console.WriteLine();
            }
            /*else if (int.Parse(temp_2) <= 10)
            {
                Console.WriteLine("생산 2라인 온도가 10℃ 이하입니다.");
                Console.WriteLine("알림 : 생산 2라인 히터 가동");
                Console.WriteLine();
            }*/

            Console.WriteLine("--------------------------------------------------------");
        }

        private void but_refresh_Click(object sender, EventArgs e)
        {
            show_info();
        }

        private void uiSymbolLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            /*Common.InitTheme(this);*/
        }
    }
}


namespace iotApp0907
{
    partial class MainUI
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.output_he = new Sunny.UI.UISymbolLabel();
            this.output_date = new Sunny.UI.UISymbolLabel();
            this.output_temp = new Sunny.UI.UISymbolLabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.led_alarm = new Sunny.UI.UILedBulb();
            this.tem_meter = new Sunny.UI.UIAnalogMeter();
            this.led_display = new Sunny.UI.UILedDisplay();
            this.uiBarChart1 = new Sunny.UI.UIBarChart();
            this.uiLineChart1 = new Sunny.UI.UILineChart();
            this.he_meter = new Sunny.UI.UIAnalogMeter();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.but_refresh = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(49, 150);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(238, 46);
            this.uiSymbolLabel1.Symbol = 61573;
            this.uiSymbolLabel1.SymbolSize = 40;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "생산 1라인 정보";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // output_he
            // 
            this.output_he.BackColor = System.Drawing.Color.White;
            this.output_he.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_he.Location = new System.Drawing.Point(49, 273);
            this.output_he.MinimumSize = new System.Drawing.Size(1, 1);
            this.output_he.Name = "output_he";
            this.output_he.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.output_he.Size = new System.Drawing.Size(188, 46);
            this.output_he.Symbol = 61546;
            this.output_he.SymbolColor = System.Drawing.Color.Silver;
            this.output_he.SymbolSize = 25;
            this.output_he.TabIndex = 1;
            this.output_he.Text = "0％";
            this.output_he.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // output_date
            // 
            this.output_date.BackColor = System.Drawing.Color.White;
            this.output_date.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_date.Location = new System.Drawing.Point(49, 325);
            this.output_date.MinimumSize = new System.Drawing.Size(1, 1);
            this.output_date.Name = "output_date";
            this.output_date.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.output_date.Size = new System.Drawing.Size(238, 46);
            this.output_date.Symbol = 61546;
            this.output_date.SymbolColor = System.Drawing.Color.Silver;
            this.output_date.SymbolSize = 25;
            this.output_date.TabIndex = 2;
            this.output_date.Text = "등록시간";
            this.output_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.output_date.Click += new System.EventHandler(this.uiSymbolLabel3_Click);
            // 
            // output_temp
            // 
            this.output_temp.BackColor = System.Drawing.Color.White;
            this.output_temp.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_temp.Location = new System.Drawing.Point(49, 212);
            this.output_temp.MinimumSize = new System.Drawing.Size(1, 1);
            this.output_temp.Name = "output_temp";
            this.output_temp.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.output_temp.Size = new System.Drawing.Size(188, 46);
            this.output_temp.Symbol = 61546;
            this.output_temp.SymbolColor = System.Drawing.Color.Silver;
            this.output_temp.SymbolSize = 25;
            this.output_temp.TabIndex = 3;
            this.output_temp.Text = "0℃";
            this.output_temp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(49, 193);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(238, 3);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 4;
            // 
            // led_alarm
            // 
            this.led_alarm.BackColor = System.Drawing.Color.Transparent;
            this.led_alarm.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led_alarm.Location = new System.Drawing.Point(12, 73);
            this.led_alarm.Name = "led_alarm";
            this.led_alarm.Size = new System.Drawing.Size(60, 55);
            this.led_alarm.TabIndex = 5;
            this.led_alarm.Text = "uiLedBulb1";
            // 
            // tem_meter
            // 
            this.tem_meter.BackColor = System.Drawing.Color.White;
            this.tem_meter.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tem_meter.Location = new System.Drawing.Point(26, 372);
            this.tem_meter.MaxValue = 100D;
            this.tem_meter.MinimumSize = new System.Drawing.Size(1, 1);
            this.tem_meter.MinValue = 0D;
            this.tem_meter.Name = "tem_meter";
            this.tem_meter.NeedleColor = System.Drawing.Color.Red;
            this.tem_meter.Renderer = null;
            this.tem_meter.Size = new System.Drawing.Size(169, 171);
            this.tem_meter.TabIndex = 6;
            this.tem_meter.Text = "uiAnalogMeter1";
            this.tem_meter.Value = 78D;
            // 
            // led_display
            // 
            this.led_display.BackColor = System.Drawing.Color.Black;
            this.led_display.CharCount = 20;
            this.led_display.ForeColor = System.Drawing.Color.Lime;
            this.led_display.IntervalOn = 5;
            this.led_display.IntervalV = 10;
            this.led_display.Location = new System.Drawing.Point(78, 73);
            this.led_display.Name = "led_display";
            this.led_display.Size = new System.Drawing.Size(733, 65);
            this.led_display.TabIndex = 30;
            this.led_display.Text = "--------------------------------------------------------------------";
            // 
            // uiBarChart1
            // 
            this.uiBarChart1.BackColor = System.Drawing.Color.Transparent;
            this.uiBarChart1.FillColor = System.Drawing.Color.Transparent;
            this.uiBarChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiBarChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiBarChart1.Location = new System.Drawing.Point(486, 150);
            this.uiBarChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBarChart1.Name = "uiBarChart1";
            this.uiBarChart1.RectColor = System.Drawing.Color.Transparent;
            this.uiBarChart1.Size = new System.Drawing.Size(334, 188);
            this.uiBarChart1.Style = Sunny.UI.UIStyle.Custom;
            this.uiBarChart1.TabIndex = 8;
            this.uiBarChart1.Text = "uiBarChart1";
            // 
            // uiLineChart1
            // 
            this.uiLineChart1.BackColor = System.Drawing.Color.Transparent;
            this.uiLineChart1.FillColor = System.Drawing.Color.Transparent;
            this.uiLineChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLineChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiLineChart1.Location = new System.Drawing.Point(486, 388);
            this.uiLineChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLineChart1.Name = "uiLineChart1";
            this.uiLineChart1.RectColor = System.Drawing.Color.Transparent;
            this.uiLineChart1.Size = new System.Drawing.Size(334, 188);
            this.uiLineChart1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLineChart1.TabIndex = 9;
            this.uiLineChart1.Text = "uiLineChart1";
            // 
            // he_meter
            // 
            this.he_meter.BackColor = System.Drawing.Color.White;
            this.he_meter.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.he_meter.Location = new System.Drawing.Point(243, 372);
            this.he_meter.MaxValue = 100D;
            this.he_meter.MinimumSize = new System.Drawing.Size(1, 1);
            this.he_meter.MinValue = 0D;
            this.he_meter.Name = "he_meter";
            this.he_meter.NeedleColor = System.Drawing.Color.Lime;
            this.he_meter.Renderer = null;
            this.he_meter.Size = new System.Drawing.Size(169, 171);
            this.he_meter.TabIndex = 10;
            this.he_meter.Text = "uiAnalogMeter2";
            this.he_meter.Value = 36.5D;
            // 
            // uiLine2
            // 
            this.uiLine2.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.LineColor = System.Drawing.Color.Gray;
            this.uiLine2.Location = new System.Drawing.Point(486, 129);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(3, 780);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 11;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(26, 550);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(169, 26);
            this.uiSymbolLabel2.Symbol = 62152;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.Silver;
            this.uiSymbolLabel2.SymbolSize = 25;
            this.uiSymbolLabel2.TabIndex = 12;
            this.uiSymbolLabel2.Text = "온도표시미터";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(243, 550);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(169, 26);
            this.uiSymbolLabel3.Symbol = 62152;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.Silver;
            this.uiSymbolLabel3.SymbolSize = 25;
            this.uiSymbolLabel3.TabIndex = 13;
            this.uiSymbolLabel3.Text = "습도표시미터";
            // 
            // but_refresh
            // 
            this.but_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_refresh.FillColor = System.Drawing.Color.White;
            this.but_refresh.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.but_refresh.FillPressColor = System.Drawing.Color.Silver;
            this.but_refresh.FillSelectedColor = System.Drawing.Color.Silver;
            this.but_refresh.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.but_refresh.ForeColor = System.Drawing.Color.Silver;
            this.but_refresh.ForeHoverColor = System.Drawing.Color.Black;
            this.but_refresh.ForePressColor = System.Drawing.Color.Black;
            this.but_refresh.ForeSelectedColor = System.Drawing.Color.Black;
            this.but_refresh.Location = new System.Drawing.Point(293, 161);
            this.but_refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.but_refresh.Name = "but_refresh";
            this.but_refresh.RectColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectHoverColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectPressColor = System.Drawing.Color.Transparent;
            this.but_refresh.RectSelectedColor = System.Drawing.Color.Transparent;
            this.but_refresh.Size = new System.Drawing.Size(42, 35);
            this.but_refresh.Style = Sunny.UI.UIStyle.Custom;
            this.but_refresh.Symbol = 61473;
            this.but_refresh.TabIndex = 14;
            this.but_refresh.Click += new System.EventHandler(this.but_refresh_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 588);
            this.Controls.Add(this.but_refresh);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.he_meter);
            this.Controls.Add(this.uiLineChart1);
            this.Controls.Add(this.uiBarChart1);
            this.Controls.Add(this.led_display);
            this.Controls.Add(this.tem_meter);
            this.Controls.Add(this.led_alarm);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.output_temp);
            this.Controls.Add(this.output_date);
            this.Controls.Add(this.output_he);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MES 생상관리 모니터링 V1.0.0";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel output_he;
        private Sunny.UI.UISymbolLabel output_date;
        private Sunny.UI.UISymbolLabel output_temp;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILedBulb led_alarm;
        private Sunny.UI.UIAnalogMeter tem_meter;
        private Sunny.UI.UILedDisplay led_display;
        private Sunny.UI.UIBarChart uiBarChart1;
        private Sunny.UI.UILineChart uiLineChart1;
        private Sunny.UI.UIAnalogMeter he_meter;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolButton but_refresh;
    }
}


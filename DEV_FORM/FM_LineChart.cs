﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DEV_FORM
{
    public partial class FM_LineChart : DEV_FORM.BaseMDIChildForm
    {
        public FM_LineChart()
        {
            InitializeComponent();
        }

        private void FM_LineChart_Load(object sender, EventArgs e)
        {
            //---------------첫번째 시르즈 생성---------------------------
            chart1.Series.Clear();
            Series series1 = new Series();   //시르지 1 객체 생성
            series1.Name = "TEST_Series1";
            series1.ChartType = SeriesChartType.Line;  //라인차트
            chart1.Series.Add(series1);

            int[] ivalue = new int[] { 100, 110, 90, 80, 100, 90, 100, 150, 130, 120 };
            string[] sText = new string[] { "05-01", "05-02", "05-03", "05-04", "05-05", "05-06", "05-07", "05-08", "05-09", "05-10" };
            
            int x = 0;
            foreach (var v in ivalue)  //값을 차트에 하나씩 대입한다.
            {
                chart1.Series[0].Points.AddXY(sText[x], v);
                x++;
            }
            series1.IsValueShownAsLabel = true;



            //---------------두번째 시르즈 생성---------------------------
            Series series2 = new Series();   //시르지 1 객체 생성
            series2.Name = "TEST_Series2";
            series2.ChartType = SeriesChartType.Line;  //라인차트
            chart1.Series.Add(series2);

            ivalue = new int[] { 80, 40, 60,130, 110,150, 60, 90, 110,170 };
            sText = new string[] { "05-01", "05-02", "05-03", "05-04", "05-05", "05-06", "05-07", "05-08", "05-09", "05-10" };

            x = 0;
            foreach (var v in ivalue)  //값을 차트에 하나씩 대입한다.
            {
                chart1.Series[1].Points.AddXY(sText[x], v);
                x++;
            }
            series2.IsValueShownAsLabel = true;   //값표시
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;  //차트 간격 지정
        }
    }
}

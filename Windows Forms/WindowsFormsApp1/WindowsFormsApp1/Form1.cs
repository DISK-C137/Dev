using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblNow.Text = "วันที่และเวลา : " + DateTime.Now.ToString();
            lblDate.Text = "วันที่แบบยาว : " + DateTime.Now.Date.ToLongDateString();
            lblTimeOfDay.Text = "เวลา : " + DateTime.Now.TimeOfDay.ToString();
            lblDay.Text = "วันที่ : " + DateTime.Now.Day.ToString();
            lblMonth.Text = "เดือน : " + DateTime.Now.Month.ToString();
            lblYear.Text = "ปี : " + DateTime.Now.Year.ToString();
            lblTodayLong.Text = "วันที่ปัจจุบันแบบยาว : " + DateTime.Today.ToLongDateString();
            lblTodayShort.Text = "วันที่ปัจจุบันแบบสั้น : " + DateTime.Today.ToShortDateString();

            cboStyle.Items.Add("d");
            cboStyle.Items.Add("dd");
            cboStyle.Items.Add("ddd");
            cboStyle.Items.Add("dddd");
            cboStyle.Items.Add("m");
            cboStyle.Items.Add("mm");
            cboStyle.Items.Add("mmm");
            cboStyle.Items.Add("mmmm");
            cboStyle.Items.Add("yy");
            cboStyle.Items.Add("yyyy");
            cboStyle.Items.Add("d MMMM yyyy");
            cboStyle.Items.Add("d MM yyyy");
            cboStyle.Items.Add("d MM yy");
            cboStyle.Items.Add("dd-MM-yy");
            cboStyle.Items.Add("dddd, MMMM dd ");
            cboStyle.Items.Add("u");
            cboStyle.Items.Add("U");
            cboStyle.Items.Add("t");
            cboStyle.Items.Add("T");
            cboStyle.Items.Add("m");
            cboStyle.Items.Add("r");
            cboStyle.Items.Add("s");
            cboStyle.Items.Add("y");
            cboStyle.Items.Add("g");
            cboStyle.Items.Add("G");
            cboStyle.Items.Add("f");
            cboStyle.Items.Add("F");
            cboStyle.SelectedIndex = 0;

            cboStyle1.Items.Add("d MMMM yyyy");
            cboStyle1.Items.Add("d MM yyyy");
            cboStyle1.Items.Add("d MM yy");
            cboStyle1.Items.Add("hh.mm.ss");
            cboStyle1.Items.Add("hh.mm");
            cboStyle1.SelectedIndex = 0;

            int tmpVal;
            tmpVal = (int)30.60;
            lblResult.Text = tmpVal.ToString();
        }
        const float PI = 3.14f;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float Radius;
                float Area;
                Radius = float.Parse(txtRadius.Text);
                Area = PI * (Radius * Radius);
                MessageBox.Show("พื้นที่เท่ากับ : " + Area, "ผลการคำนวณ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด เนื่องจาก : " + ex.Message);
            }
        }

        private void cmdFormat_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTimeFormatInfo dtfInfo;
            string DateStyle = "";
            if (optInvariant.Checked)
            {
                dtfInfo = DateTimeFormatInfo.InvariantInfo;
            }
            else
            {
                dtfInfo = DateTimeFormatInfo.CurrentInfo;
            }
            DateStyle = cboStyle.Text;
            lblDisplay.Text = dt.ToString(DateStyle, dtfInfo);
        }

        private void cmdFormat1_Click(object sender, EventArgs e)
        {
            string DateStyle = "";
            DateTime dt = DateTime.Now; 
            CultureInfo Thai_CInfo = new CultureInfo("th-TH");
            DateTimeFormatInfo Thai_dtfInfo = Thai_CInfo.DateTimeFormat;
            DateStyle = cboStyle1.Text;
            lblDisplay1.Text = dt.ToString(DateStyle, Thai_dtfInfo);
        }

        private void cmdConvert_Click(object sender, EventArgs e)
        {
            int UserInput = Convert.ToInt32(txtInput.Text);
            lblResult.Text = UserInput.ToString();
        }
    }
}

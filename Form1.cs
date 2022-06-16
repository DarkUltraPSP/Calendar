using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Calendar
{
    public partial class form1 : Form
    {
        Form2 form2;
        DateTime curDate;
        DateTime pickerDate;

        public form1()
        {
            InitializeComponent();
            this.Text = "Calendar";
            curDate = DateTime.Now;
            pickerDate = dateTimePicker1.Value;
        }

        private void hideBtn(int dayInCurMonth)
        {
            button29.Show(); button30.Show(); button31.Show();

            switch (dayInCurMonth)
            {
                case 28:
                    button29.Hide(); button30.Hide(); button31.Hide();
                    break;
                case 30:
                    button31.Hide();
                    break;
            }
        }

        private List<Evenement> getEvenements()
        {
            string path = @"..\..\..\Calendar\Events.json";
            string strEvent = File.ReadAllText(path);
            string[] strEventSplit = strEvent.Split(';');
            List<Evenement> eventList = new List<Evenement>();
            foreach (string str in strEventSplit)
            {
                Evenement eventObj = JsonConvert.DeserializeObject<Evenement>(str);
                eventList.Add(eventObj);
            }
            return eventList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = pickerDate.ToString("Y");
            int dayInCurMonth = DateTime.DaysInMonth(curDate.Year, curDate.Month);
            hideBtn(dayInCurMonth);
            Button[] tabBtn = new Button[] {
                button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
                button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
                button21, button22, button23, button24, button25, button26, button27, button28, button29, button30,
                button31
            };

            //Name all buttons
            for (int cpt = 0; cpt < tabBtn.Length; cpt++)
            {
                tabBtn[cpt].Text = (cpt+1).ToString();
            }

            // Today button set to blue
            tabBtn[curDate.Day - 1].ForeColor = System.Drawing.Color.Blue;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button1.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button2.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button3.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button4.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button5.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button6.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button7.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button8.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button9.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button10.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button11.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button12.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button13.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button14.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button15.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button16.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button17.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button18.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button19.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button20.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button21.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button22.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button23.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button24.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button25.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button26.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button27.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button28.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button29.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button30.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = new DateTime(pickerDate.Year, pickerDate.Month, Int32.Parse(button31.Text));
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString("Y");

            hideBtn(DateTime.DaysInMonth(curDate.Year, dateTimePicker1.Value.Month));
            // tabBtn[dateTimePicker1.Value.Day - 1].ForeColor = System.Drawing.Color.Red;
        }
    }
}

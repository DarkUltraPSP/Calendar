using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Reflection;
using System.Diagnostics;

namespace Calendar
{
    public partial class Form2 : Form
    {
        DateTime selectedDate;

        public Form2(DateTime btn)
        {
            InitializeComponent();
            selectedDate = btn;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = selectedDate.ToString("D");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            Evenement newEvent = new Evenement(selectedDate, textBox1.Text, richTextBox1.Text);
            Debug.WriteLine(newEvent.ToString());
            // Add the new event to a JSON file
            string json = JsonConvert.SerializeObject(newEvent);
            Debug.WriteLine(json);
            string path = @"..\..\..\Calendar\Events.json";
            File.AppendAllText(path, json + "," + Environment.NewLine);
            this.Hide();
        }
    }
}

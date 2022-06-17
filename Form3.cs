using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form3 : Form
    {
        Form2 form2;
        DateTime selectedDate;
        public Form3(DateTime btn)
        {
            InitializeComponent();
            selectedDate = btn;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Evenement ev in EvenementDto.getEvenements())
            {
                Debug.WriteLine(ev);
                //listBox1.Items.Add(ev);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            form2 = new Form2(selectedDate);
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                Evenement ev = listBox1.SelectedItem as Evenement;
                EvenementDto.deleteEvenement(ev.id);
                listBox1.Refresh();
            }
        }
    }
}

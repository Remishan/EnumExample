using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Reslut DoorResult = new Reslut();
            if (comboBox1.Text == "Open")
            {
                DoorResult = Playing(Door.Open);
            }
            else if (comboBox1.Text == "Close")
            {
                DoorResult = Playing(Door.close);
            }
            this.Text = DoorResult.ToString();
        }
        public Reslut Playing(Door move)
       {
            Random random = new Random();
            random.Next(1, 3);
            this.Text = random.Next(1, 3).ToString();
            int rndNumber = random.Next(1, 3);

            if (rndNumber == (int)move)
            {
                return Reslut.win;
            }
            else 
            {
                return Reslut.loss;
            }
        }
    }
}

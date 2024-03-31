using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PirateChan
{
    public partial class Figurines : Form
    {
        public Figurines()
        {
            InitializeComponent();
           
        }

        private void figurine_btn_Click(object sender, EventArgs e)
        {
            Figurines fig = new Figurines();
            fig.Show();
            this.Hide();
        }

        private void plushy_btn_Click(object sender, EventArgs e)
        {
            Plushy pls = new Plushy();
            pls.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}

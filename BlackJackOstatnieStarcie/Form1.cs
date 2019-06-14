using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackOstatnieStarcie
{
    public partial class Form1 : Form, IView
    {
        public int PValue
        {
            get
            {
                return int.Parse(labelPP.Text);
            }
            set
            {

                labelPP.Text = $"{int.Parse(labelPP.Text)+value}";
            }

        }

        public int CValue
        {
            get
            {
                return int.Parse(labelCP.Text);
            }
            set
            {
                labelPP.Text = $"{int.Parse(labelPP.Text) + value}";
            }

        }

        public int CLeft
        {
            get
            {
                return int.Parse(labelNumCL.Text);
            }
            set
            {
                labelCP.Text = $"{value}";
            }

        }

        public event Action Hit;
        public event Action Stand;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonHit_Click(object sender, EventArgs e)
        {

            Hit?.Invoke();
        }

       

        private void ButtonStand_Click(object sender, EventArgs e)
        {
            Stand?.Invoke();

        }
    }
}

﻿using System;
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
                labelPP.Text = $"{value}";
            }
        }

        public int PValueConst
        {
            get
            {
                return int.Parse(labelPP.Text);
            }
            set
            {
                labelPP.Text = $"{value}";
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
                labelCP.Text = $"{value}";
            }

        }



        public int GR
        {
            set
            {
                labelWins.Text = $"{int.Parse(labelWins.Text) + 1}";
            }
            get
                { return int.Parse(labelWins.Text); }
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AFNDConverter
{
    public partial class Form2 : Form
    {
        private CurrencyManager currencyManager = null;
        AFD automata;
        public Form2(AFD final)
        {
            InitializeComponent();
            automata = final;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            currencyManager = (CurrencyManager)dataGridView1.BindingContext[automata.Trancisiones];
        }

    }
}

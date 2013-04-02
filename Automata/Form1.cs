using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace AFNDConverter
{
    public partial class Form1 : Form
    {
        List<string> _alphabet = new List<string>();
        List<string> _states = new List<string>();
        List<string> _initialState = new List<string>();
        List<string> _finalsStates = new List<string>();
        public List<Transition> _transitions;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _states.Add(textBox1.Text);
            MessageBox.Show("Se añadio un estado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _alphabet.Add(textBox2.Text);
            MessageBox.Show("Se añadio una letra al alfabeto");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _initialState.Add(textBox3.Text);
            MessageBox.Show("se añadio un estado inicial");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _finalsStates.Add(textBox4.Text);
            MessageBox.Show("se añadio un estado final");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AFND nuevo = new AFND(_alphabet, _states, _initialState, _finalsStates, _transitions);
            Converter cambio = new Converter(nuevo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

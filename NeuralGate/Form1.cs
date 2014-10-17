using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NeuralGate
{
    public partial class Form1 : Form
    {
        DigitalNeuralGate gate;

        public Form1()
        {
            InitializeComponent();

            gate = new DigitalNeuralGate();
            radAndGate.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gatename = "Gate";
            if (radAndGate.Checked)
                gatename += "And";
            else if (radOrGate.Checked)
                gatename += "Or";
            else if (radXorGate.Checked)
                gatename += "Xor";
            gatename += ".gate";
            gate.Save(gatename);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string gatename = "Gate";
            if (radAndGate.Checked)
                gatename += "And";
            else if (radOrGate.Checked)
                gatename += "Or";
            else if (radXorGate.Checked)
                gatename += "Xor";
            gatename += ".gate";
            if (File.Exists(gatename))
                gate.Load(gatename);
        }

        private void radGate_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked || true)
            {
                if (sender == radXorGate)
                {
                    tbxOut1.Text = "0";
                    tbxOut2.Text = "1";
                    tbxOut3.Text = "1";
                    tbxOut4.Text = "0";
                } else if (sender == radOrGate)
                {
                    tbxOut1.Text = "0";
                    tbxOut2.Text = "1";
                    tbxOut3.Text = "1";
                    tbxOut4.Text = "1";
                } else if (sender == radAndGate)
                {
                    tbxOut1.Text = "1";
                    tbxOut2.Text = "0";
                    tbxOut3.Text = "0";
                    tbxOut4.Text = "1";
                }
            }
        }

        private void btnTrain1000_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                TrainOnce();
            }
        }

        private void TrainOnce()
        {
            try
            {
                gate.Train(int.Parse(tbxIn11.Text), int.Parse(tbxIn12.Text), int.Parse(tbxOut1.Text));
                gate.Train(int.Parse(tbxIn21.Text), int.Parse(tbxIn22.Text), int.Parse(tbxOut2.Text));
                gate.Train(int.Parse(tbxIn31.Text), int.Parse(tbxIn32.Text), int.Parse(tbxOut3.Text));
                gate.Train(int.Parse(tbxIn41.Text), int.Parse(tbxIn42.Text), int.Parse(tbxOut4.Text));
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("All textboxes should be filled with an integer");
            }
            catch (FormatException)
            {
                MessageBox.Show("All textboxes should contain integer only");
            }
            catch (OverflowException)
            {
                MessageBox.Show("One of the textboxes have a too big number");
            }

        }

        private void btnTrainOnce_Click(object sender, EventArgs e)
        {
            TrainOnce();
        }

        private void btnRunGate_Click(object sender, EventArgs e)
        {
            tbxOutResult1.Text = gate.Run(int.Parse(tbxInResult11.Text), int.Parse(tbxInResult12.Text)).ToString();
            tbxOutResult2.Text = gate.Run(int.Parse(tbxInResult21.Text), int.Parse(tbxInResult22.Text)).ToString();
            tbxOutResult3.Text = gate.Run(int.Parse(tbxInResult31.Text), int.Parse(tbxInResult32.Text)).ToString();
            tbxOutResult4.Text = gate.Run(int.Parse(tbxInResult41.Text), int.Parse(tbxInResult42.Text)).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gate = new DigitalNeuralGate();
        }
    }
}

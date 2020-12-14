using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift_Forms1
{
    public partial class Form1 : Form
    {
        Random slump = new Random();
        int AntalGissningar = 0;
        int slumptal;

        public Form1()
        {
            InitializeComponent();
            slumptal = slump.Next(101);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Gissa_Click(object sender, EventArgs e)
        {
            AntalGissningar++;
            int tal = int.Parse(gissningBox.Text);
            if (tal < 1 || tal > 100)
                Meddelande.Text = "Talet är mindre än 1!";
            else
                Meddelande.Text = "Talet är större än 100!";
            {
                int tal1 = int.Parse(gissningBox.Text);
                if (tal > slumptal && !(tal > 100))
                    Meddelande.Text = "Fel gissat, Talet är lägre än vad du har gissat!";
            }
            if (tal < slumptal && !(tal < 1))
            {
                Meddelande.Text = "Fel gissat, Talet är högre än det du gissade på!";
            }

            if (tal == slumptal)
            {
                Meddelande.Text = ("Rätt gissat!" + " Det tog dig " + AntalGissningar + " gånger att gissa!");
            }
        }
    }
}

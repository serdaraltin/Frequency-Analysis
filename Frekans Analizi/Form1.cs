using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frekans_Analizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_analizet_Click(object sender, EventArgs e)
        {
            int[] alfabe = new int[26];
            //0,0,0,0,0,0,0...
            //a,b,c,d,e,f,g...
            prgb_durum.Maximum = tx_analizmetin.TextLength;
            for (int i = 0; i < tx_analizmetin.TextLength; i++)
            {
                if(tx_analizmetin.Text[i] > 96 && tx_analizmetin.Text[i] < 123) // örnek : a = 97 - 97 = 0
                {
                    alfabe[tx_analizmetin.Text[i] - 97] += 1; // 
                }
                prgb_durum.Value += 1;
            }

            for(int a = 0; a < alfabe.Length; a++)
            {
                char harf = (char)(a + 97);
                lstb_analizsonucu.Items.Add(harf.ToString() + " = " + alfabe[a].ToString());
            }

        }
    }
}

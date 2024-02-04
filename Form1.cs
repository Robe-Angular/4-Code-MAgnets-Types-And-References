using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Code_MAgnets_Types_And_References
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] islands = new String[4];
            int y = 0;
            int refNum;
            String result = "";
            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;
            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";
            
            while (y < 4)
            {
                refNum = index[y];
                result += "\nisland = ";
                result += islands[refNum];
                y = y + 1;
            }
            MessageBox.Show(result);
        }
    }
}

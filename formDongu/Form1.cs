using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formDongu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i = 1;
            for (; ; )
            {
                MessageBox.Show(i + ".Mesaj");
                i++;
                if (i > 5)
                {
                    break;
                }
            }
        }


    }
}

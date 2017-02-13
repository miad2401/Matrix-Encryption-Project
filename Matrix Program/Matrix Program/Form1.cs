using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char[] AsciiData = new char[234];
            char[] EncMess;
            int[,] EncMatrix = new int[6, 6] { { 15, 2, 6, 2, 9, 8 }, { 7, 1, 4, 5, 2, 4 }, { 3, 0, 229, 2, 1, 1 }, { 1, 2, 5, 61, 3, 6 }, { 2, 7, 1, 109, 212, 3 }, { 229, 214, 230, 94, 3, 33 } };
            string inputstr = txtEncMess.Text;
            EncMess = inputstr.ToCharArray();

        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] DecMatrix = new int[6,6] { { 149, 185, 195, 134, 139, 16 }, { 108, 102, 114, 97, 183, 113 }, { 100, 78, 163, 224, 220, 125 }, { 47, 88, 205, 143, 108, 225 }, { 226, 41, 167, 198, 233, 126 }, { 201, 86, 122, 0, 0, 1 } };

        }
    }
}

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
        public Char[,] message = new Char[6, 6] { { 'T', 'h', 'e', ' ', 'a', 'n' }, { 's', 'w', 'e', 'r', ' ', 'i' }, { 's', ',', ' ', 'o', 'f', ' ' }, { 'c', 'o', 'u', 'r', 's', 'e' }, { ',', ' ', 'M', 'a', 'r', 'l' }, { 'e', 't', '.', ' ', ' ', ' ' } };
        public Char[] AsciiData = new Char[234] { '♀', '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ':', ';', '<', '=', '>', '?', '@', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '[', '\\', ']', '^', '_', '`', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '{', '|', '}', '~', '⌂', 'Ç', 'ü', 'é', 'â', 'ä', 'à', 'å', 'ç', 'ê', 'ë', 'è', 'ï', 'î', 'ì', 'Ä', 'Å', 'É', 'æ', 'Æ', 'ô', 'ö', 'ò', 'û', 'ù', 'ÿ', 'Ö', 'Ü', '¢', '£', '¥', '₧', 'ƒ', 'á', 'í', 'ó', 'ú', 'ñ', 'Ñ', 'ª', 'º', '¿', '⌐', '¬', '½', '¼', '¡', '«', '»', '░', '▒', '▓', '│', '┤', '╡', '╢', '╖', '╕', '╣', '║', '╗', '╝', '╜', '╛', '┐', '└', '┴', '┬', '├', '─', '┼', '╞', '╧', '╚', '╔', '╩', '╦', '╠', '═', '╬', '╧', '╨', '╤', '╥', '╙', '╘', '╒', '╓', '╫', '→', '┘', '┌', '█', '▄', '▌', '▐', '▀', 'α', 'ß', 'Γ', 'π', 'Σ', 'σ', 'µ', 'τ', 'Φ', 'Ω', 'δ', '∞', 'φ', 'ε', '∩', '≡', '±', '≥', '≤', '⌠', '⌡', '÷', '≈', '°', '∙', '·', '√', 'ⁿ', '²', '■', ' ', '☺', '☻', '♥', '♦', '♣', '♠', '•', '◘', '○', '◙', '♂' };
        public int[,] Encrypter = new int[6, 6] { { 15, 2, 6, 2, 9, 8 }, { 7, 1, 4, 5, 2, 4 }, { 3, 0, 229, 2, 1, 1 }, { 1, 2, 5, 61, 3, 6 }, { 2, 7, 1, 109, 212, 3 }, { 229, 214, 230, 94, 3, 33 } };
        public int[,] Decrypter = new int[6,6] { { 149, 185, 195, 134, 139, 16 }, { 108, 102, 114, 97, 183, 113 }, { 100, 78, 163, 224, 220, 125 }, { 47, 88, 205, 143, 108, 225 }, { 226, 41, 167, 198, 233, 126 }, { 201, 86, 122, 0, 0, 1 } };
        public int[,] numberSet = new int[6, 6];
        public int[,] Answer = new int[6, 6];
        public int[,] DecAnswer = new int[6, 6];
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblEncMess.Text = "";
            for (Int32 i = 0; i < 6; i++)
            {
                for (Int32 j = 0; j < 6; j++)
                {
                   for (Int32 k = 0; k < 234; k++)
                   {
                       if (message[i, j] == AsciiData[k])
                       {
                           numberSet[i, j] = k;
                           break;
                       }
                   }
                }
            }
            for (Int32 i=0; i < 6; i++)
            {
                for (Int32 j =0; j < 6; j++)
                {
                    int placeholder = 0;
                    for (Int32 k =0; k < 6; k++)
                    {
                        placeholder += (numberSet[i, k] * Encrypter[k, j]);
                    }
                    Answer[i, j] = placeholder % 234;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    lblEncMess.Text += AsciiData[Answer[i, j]];
                }
            }
        }
        

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDecMess.Text = "";
            /*for (Int32 i = 0; i < 6; i++)
            {
                for (Int32 j = 0; j < 6; j++)
                {
                    for (Int32 k = 0; k < 234; k++)
                    {
                        if (message[i, j] == AsciiData[k])
                        {
                            numberSet[i, j] = k;
                            break;
                        }
                    }
                }
            }*/
            for (Int32 i = 0; i < 6; i++)
            {
                for (Int32 j = 0; j < 6; j++)
                {
                    int placeholder = 0;
                    for (Int32 k = 0; k < 6; k++)
                    {
                        placeholder += (numberSet[i, k] * Decrypter[k, j]);
                    }
                    DecAnswer[i, j] = placeholder % 234;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    lblDecMess.Text += AsciiData[DecAnswer[i, j]];
                }
            }
        }
    }
}

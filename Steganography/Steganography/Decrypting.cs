using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Decrypting : Form
    {
        public Decrypting()
        {
            InitializeComponent();
        }

        string rFile;
        Bitmap bPic;
        string aText = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя+-*/.,?!()\" :;=0123456789";

        private void MainScreenbut_Click(object sender, EventArgs e)
        {
            MainScreen temp = new MainScreen();
            temp.Show();
            Hide();
        }

        private void Exiting_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Decrypting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void OpenImg_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            openFileDialog1.Filter = "BMP files (*.bmp)|*.bmp";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            rFile = openFileDialog1.FileName.ToString();
                            bPic = new Bitmap(rFile);
                            Img.ImageLocation = rFile;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void OpenKey_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            StreamReader myStream = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myStream = new StreamReader(openFileDialog1.FileName.ToString(), Encoding.GetEncoding(1251));
                Key.Text = myStream.ReadLine();
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            string key = Key.Text;
            string text;
            if (bPic == null)
            {
                MessageBox.Show("Вы не загрузили картинку", "Оповищение", MessageBoxButtons.OK);
            }
            else if (key == "")
            {
                MessageBox.Show("Вы не загрузили ключ", "Оповищение", MessageBoxButtons.OK);
            }
            else
            {
                text = Dsteganograp();
                var pad = new vernama(aText);
                string encrypt = pad.Crypt(text, key, false);
                TextEncr.Text = encrypt;
            }
        }

        private string Dsteganograp()
        {
            if (!isEncryption(bPic))
            {
                MessageBox.Show("В файле нет зашифрованной информации", "Информация", MessageBoxButtons.OK);
                return "err";
            }

            int countSymbol = ReadCountText(bPic); //считали количество  символов
            byte[] message = new byte[countSymbol];
            int index = 0;
            int height = 0;
            int width = 1;
            bool flag = true;
            while (flag)
            {

                if (height > bPic.Height)
                {
                    height = 0;
                    width++;
                }

                Color pixelColor = bPic.GetPixel(width, height);
                BitArray colorArray = ByteToBit(pixelColor.R);
                BitArray messageArray = ByteToBit(pixelColor.R); ;
                messageArray[0] = colorArray[0];
                messageArray[1] = colorArray[1];

                colorArray = ByteToBit(pixelColor.G);
                messageArray[2] = colorArray[0];
                messageArray[3] = colorArray[1];
                messageArray[4] = colorArray[2];

                colorArray = ByteToBit(pixelColor.B);
                messageArray[5] = colorArray[0];
                messageArray[6] = colorArray[1];
                messageArray[7] = colorArray[2];
                message[index] = BitToByte(messageArray);

                if (message[index] == 0)
                    height+=4;
                else
                {
                    height += message[index];
                }
                index++;

                if (index == message.Length)
                {
                    flag = false;
                }
            }
            string temp = Encoding.Unicode.GetString(message);
            return temp;
        }

        private BitArray ByteToBit(byte src)
        {
            BitArray bitArray = new BitArray(8);
            bool st = false;
            for (int i = 0; i < 8; i++)
            {
                if ((src >> i & 1) == 1)
                {
                    st = true;
                }
                else st = false;
                bitArray[i] = st;
            }
            return bitArray;
        }

        private byte BitToByte(BitArray scr)
        {
            byte num = 0;
            for (int i = 0; i < scr.Count; i++)
                if (scr[i] == true)
                    num += (byte)Math.Pow(2, i);
            return num;
        }


        private bool isEncryption(Bitmap scr)
        {
            byte[] rez = new byte[1];
            Color color = scr.GetPixel(0, 0);
            BitArray colorArray = ByteToBit(color.R); //получаем байт цвета и преобразуем в массив бит
            BitArray messageArray = ByteToBit(color.R); ;//инициализируем результирующий массив бит
            messageArray[0] = colorArray[0];
            messageArray[1] = colorArray[1];

            colorArray = ByteToBit(color.G);//получаем байт цвета и преобразуем в массив бит
            messageArray[2] = colorArray[0];
            messageArray[3] = colorArray[1];
            messageArray[4] = colorArray[2];

            colorArray = ByteToBit(color.B);//получаем байт цвета и преобразуем в массив бит
            messageArray[5] = colorArray[0];
            messageArray[6] = colorArray[1];
            messageArray[7] = colorArray[2];
            rez[0] = BitToByte(messageArray); //получаем байт символа, записанного в 1 пикселе
            string m = Encoding.GetEncoding(1251).GetString(rez);
            if (m == "/")
            {
                return true;
            }
            else return false;
        }        

        private int ReadCountText(Bitmap src)
        {
            byte[] rez = new byte[3]; //массив на 3 элемента, т.е. максимум 999 символов шифруется
            for (int i = 0; i < 3; i++)
            {
                Color color = src.GetPixel(0, i + 1); //цвет 1, 2, 3 пикселей 
                BitArray colorArray = ByteToBit(color.R); //биты цвета
                BitArray bitCount = ByteToBit(color.R); ; //инициализация результирующего массива бит
                bitCount[0] = colorArray[0];
                bitCount[1] = colorArray[1];

                colorArray = ByteToBit(color.G);
                bitCount[2] = colorArray[0];
                bitCount[3] = colorArray[1];
                bitCount[4] = colorArray[2];

                colorArray = ByteToBit(color.B);
                bitCount[5] = colorArray[0];
                bitCount[6] = colorArray[1];
                bitCount[7] = colorArray[2];
                rez[i] = BitToByte(bitCount);
            }

            string m = Encoding.GetEncoding(1251).GetString(rez);
            return Convert.ToInt32(m, 10);
        }
    }

    class dvernama
    {
        Dictionary<char, int> alph = new Dictionary<char, int>();
        Dictionary<int, char> alph_r = new Dictionary<int, char>();

        public dvernama(IEnumerable<char> Alphabet)
        {
            int i = 0;
            foreach (char c in Alphabet)
            {
                alph.Add(c, i);
                alph_r.Add(i++, c);
            }
        }
        public string Crypt(string Text, string Key, bool Crypt)
        {
            char[] key = Key.ToCharArray();
            char[] text = Text.ToCharArray();
            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                int idx;
                if (alph.TryGetValue(text[i], out idx))
                {
                    int r = alph.Count + idx;
                    r += (Crypt ? 1 : -1) * alph[key[i % key.Length]];
                    sb.Append(alph_r[r % alph.Count]);
                }
            }

            return sb.ToString();
        }
    }
}

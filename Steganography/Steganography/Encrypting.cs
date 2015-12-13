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
    public partial class Encrypting : Form
    {
        public Encrypting()
        {
            InitializeComponent();
        }

        bool flagkey = false;
        string rFile;
        Bitmap bPic;
        string aText = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя+-*/.,?!()\" :;=0123456789";

        private void MainScreenBut_Click(object sender, EventArgs e)
        {

            MainScreen temp2 = new MainScreen();
            temp2.Show();
            Hide();
        }

        private void Exiting_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Encrypting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void OpenImg_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
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
                            FileInfo file = new FileInfo(openFileDialog1.FileName);
                            double size = file.Length / 1024;
                            StartSize.Text = size.ToString() + " KB";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void TextEncr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char blockCifr = e.KeyChar;
            if ((blockCifr >= 'a' && blockCifr <= 'z'
                || blockCifr >= 'A' && blockCifr <= 'Z'))
            {
                e.Handled = true;
            }
            
        }

        private void AutoKey_Click(object sender, EventArgs e)
        {
            if (TextEncr.Text != "")
            {
                var temp = new vernama(aText);
                Key.Text = temp.Gener(TextEncr.Text);
            }
            else
            {
                MessageBox.Show("Вы не ввели сообщени!","Оповещение", MessageBoxButtons.OK);
                TextEncr.Focus();
            }
        }

        private void ClearKey_Click(object sender, EventArgs e)
        {
            Key.Clear();
        }

        private void SaveKey_Click(object sender, EventArgs e)
        {
            if (Key.Text != "")
            {
                saveFileDialog1.Filter = "Key files(*.txt)|*.txt";
                saveFileDialog1.FileName = "Key";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile(), System.Text.Encoding.Default))
                    {
                        sw.Write(Key.Text);
                        sw.Close();
                    }
                }
                flagkey = true;
            }
            else
            {
                MessageBox.Show("Вы не сгенерировали ключ","Оповищение", MessageBoxButtons.OK);
            }
        }

        private void SaveImg_Click(object sender, EventArgs e)
        {   
            saveFileDialog1.Filter = "BMP files(*.bmp)|*.bmp";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bPic.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                FileInfo file = new FileInfo(saveFileDialog1.FileName);
                double size = file.Length / 1024;
                EndSize.Text = size.ToString() + " KB";
                return;
            }
            if (!flagkey)
            {
                MessageBox.Show("Небыл сохранён ключ, сохрание пожалуйста!", "Оповещение", MessageBoxButtons.OK);
                AutoKey_Click(sender, e);
            }
        }

        

        private void Steganohrap(string rText)
        {
            byte[] bText = Encoding.Unicode.GetBytes(rText);

            List<byte> bList = new List<byte>();

            bList = bText.ToList();
            int CountText = bList.Count;

            if (CountText > ((bPic.Width * bPic.Height)) - 4)
            {
                MessageBox.Show("Выбранная картинка мала для размещения выбранного текста", "Информация", MessageBoxButtons.OK);
                return;
            }

            if (isEncryption(bPic))
            {
                MessageBox.Show("Файл уже зашифрован", "Информация", MessageBoxButtons.OK);
                return;
            }

            byte[] Symbol = Encoding.GetEncoding(1251).GetBytes("/");
            BitArray ArrBeginSymbol = ByteToBit(Symbol[0]);
            Color curColor = bPic.GetPixel(0, 0);
            BitArray tempArray = ByteToBit(curColor.R);
            tempArray[0] = ArrBeginSymbol[0];
            tempArray[1] = ArrBeginSymbol[1];
            byte nR = BitToByte(tempArray);

            tempArray = ByteToBit(curColor.G);
            tempArray[0] = ArrBeginSymbol[2];
            tempArray[1] = ArrBeginSymbol[3];
            tempArray[2] = ArrBeginSymbol[4];
            byte nG = BitToByte(tempArray);

            tempArray = ByteToBit(curColor.B);
            tempArray[0] = ArrBeginSymbol[5];
            tempArray[1] = ArrBeginSymbol[6];
            tempArray[2] = ArrBeginSymbol[7];
            byte nB = BitToByte(tempArray);

            Color nColor = Color.FromArgb(nR, nG, nB);
            bPic.SetPixel(0, 0, nColor);

            WriteCountText(CountText, bPic); //записываем количество символов исходного текста

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
                BitArray messageArray = ByteToBit(bList[index]);
                colorArray[0] = messageArray[0]; //меняем
                colorArray[1] = messageArray[1]; // в нашем цвете биты
                byte newR = BitToByte(colorArray);

                colorArray = ByteToBit(pixelColor.G);
                colorArray[0] = messageArray[2];
                colorArray[1] = messageArray[3];
                colorArray[2] = messageArray[4];
                byte newG = BitToByte(colorArray);

                colorArray = ByteToBit(pixelColor.B);
                colorArray[0] = messageArray[5];
                colorArray[1] = messageArray[6];
                colorArray[2] = messageArray[7];
                byte newB = BitToByte(colorArray);

                Color newColor = Color.FromArgb(newR, newG, newB);
                bPic.SetPixel(width, height, newColor);

                if (bList[index] == 0)
                    height+=4;
                else
                {
                    height += bList[index];
                }
                index++;

                if (index == bList.Count)
                {
                    flag = false;
                }
            }
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

        private void WriteCountText(int count, Bitmap src)
        {
            byte[] CountSymbols;
            if (count < 100)
            {
                CountSymbols = Encoding.GetEncoding(1251).GetBytes("0" + count.ToString());
            }
            else
            {
                CountSymbols = Encoding.GetEncoding(1251).GetBytes(count.ToString());
            }
            for (int i = 0; i < 3; i++)
            {
                BitArray bitCount = ByteToBit(CountSymbols[i]); //биты количества символов
                Color pColor = src.GetPixel(0, i + 1); //1, 2, 3 пикселы
                BitArray bitsCurColor = ByteToBit(pColor.R); //бит цветов текущего пикселя
                bitsCurColor[0] = bitCount[0];
                bitsCurColor[1] = bitCount[1];
                byte nR = BitToByte(bitsCurColor); //новый бит цвета пиксея

                bitsCurColor = ByteToBit(pColor.G);//бит бит цветов текущего пикселя
                bitsCurColor[0] = bitCount[2];
                bitsCurColor[1] = bitCount[3];
                bitsCurColor[2] = bitCount[4];
                byte nG = BitToByte(bitsCurColor);//новый цвет пиксея

                bitsCurColor = ByteToBit(pColor.B);//бит бит цветов текущего пикселя
                bitsCurColor[0] = bitCount[5];
                bitsCurColor[1] = bitCount[6];
                bitsCurColor[2] = bitCount[7];
                byte nB = BitToByte(bitsCurColor);//новый цвет пиксея

                Color nColor = Color.FromArgb(nR, nG, nB); //новый цвет из полученных битов
                src.SetPixel(0, i + 1, nColor); //записали полученный цвет в картинку
            }
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

        private void Encrip_Click(object sender, EventArgs e)
        {
            string text = TextEncr.Text;
            string key = Key.Text;

            if (bPic == null)
            {
                MessageBox.Show("Вы не загрузили картинку", "Оповищение", MessageBoxButtons.OK);
            }
            else if (text == "")
            {
                MessageBox.Show("Вы не ввели сообщение", "Оповищение", MessageBoxButtons.OK);
                TextEncr.Focus();
            }
            else if (key == "")
            {
                MessageBox.Show("Вы не сгенерировали ключ", "Оповищение", MessageBoxButtons.OK);
            }
            else
            {
                var pad = new vernama(aText);
                string encrypt = pad.Crypt(text, key, true);
                Steganohrap(encrypt);
            } 
        }

        private void Help1_Click(object sender, EventArgs e)
        {
            Helper temp = new Helper();
            temp.Show();
            temp.Helping.LoadFile("Helper/Help2.rtf");
        }
    

    }

    class vernama
    {
        Dictionary<char, int> alph = new Dictionary<char, int>();
        Dictionary<int, char> alph_r = new Dictionary<int, char>();

        public vernama(IEnumerable<char> Alphabet)
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

        public string Gener(string Text)
        {
            Random temp = new Random();
            int len = Text.Length;
            string Textkey = "";
            char[] m = new char[len];

            for (int i = 0; i < len; i++)
            {
                m[i] = alph_r[temp.Next(0, 91)];
                Textkey += m[i];
            }
            return Textkey;
        }
    }

        
}

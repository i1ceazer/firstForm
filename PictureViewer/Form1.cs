using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Очистка рисунка
            pictureBox1.Image = null;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Закрытие приложения
            this.Close();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            {
                // Показывает диалоговое окно цвета. Если пользователь нажмет ОК, изменит
                // фон в цвет выбранное пользователем.
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.BackColor = colorDialog1.Color;
                }
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Открывает диалоговое окно "Открыть Файл". Если пользователь нажимает ОК,
            // загрузиться изображение, котроое выбрал пользователь.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Если пользователь установил флажок "Растянуть", PictureBox изменит свойство SizeMode на "Stretch"
            // Если пользователь очистит флажок, то изменит его свойство на "Нормальный"
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void рисунокToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Очистка рисунка
            pictureBox1.Image = null;
        }

        private void растяунтьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void даToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Растягивает изображение
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void нетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Возвращает изображение к нормальному состоянию
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void выборЦветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Показывает диалоговое окно цвета. Если пользователь нажмет ОК, изменит
            // фон в цвет выбранное пользователем.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открывает диалоговое окно "Открыть Файл". Если пользователь нажимает ОК,
            // загрузиться изображение, котроое выбрал пользователь.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Заркывает файл
            this.Close();
        }

        private void рисунокToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void растянутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void сжатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}

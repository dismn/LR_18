using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double[] arr = Array.ConvertAll(txtArray.Text.Split(','), double.Parse);

            double product = 1;
            for (int i = 0; i < arr.Length; i += 2)
            {
                product *= arr[i];
            }

            double sum = 0;
            int firstZeroIndex = Array.IndexOf(arr, 0);
            int lastZeroIndex = Array.LastIndexOf(arr, 0);
            if (firstZeroIndex >= 0 && lastZeroIndex >= 0 && firstZeroIndex != lastZeroIndex)
            {
                for (int i = firstZeroIndex + 1; i < lastZeroIndex; i++)
                {
                    sum += arr[i];
                }
            }

            double[] positiveArr = arr.Where(x => x >= 0).ToArray();
            double[] negativeArr = arr.Where(x => x < 0).ToArray();
            Array.Sort(positiveArr);
            Array.Reverse(positiveArr);
            Array.Sort(negativeArr);
            double[] sortedArr = positiveArr.Concat(negativeArr).ToArray();

            txtProduct.Text = product.ToString();
            txtSum.Text = sum.ToString();
            txtSortedArray.Text = string.Join(", ", sortedArr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[,]
    {
        { 1, 2, 3, 4 },
        { 5, 6, 7, 8 },
        { 9, 10, 11, 12 },
        { 13, 14, 15, 16 }
    };

            bool hasEvenNumberLeft = false;
            bool hasNumberEndingWithZeroRight = false;

            // Перевірка на наявність парних чисел у лівих кутах
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0] % 2 == 0 || matrix[i, matrix.GetLength(1) - 1] % 2 == 0)
                {
                    hasEvenNumberLeft = true;
                    break;
                }
            }

            // Перевірка на наявність чисел, що закінчуються нулем, у правих кутах
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, matrix.GetLength(1) - 1] % 10 == 0)
                {
                    hasNumberEndingWithZeroRight = true;
                    break;
                }
            }

            // Повідомлення про результат
            if (hasEvenNumberLeft)
            {
                MessageBox.Show("Знайдено парне число у лівому куті");
            }
            else
            {
                MessageBox.Show("У лівому куті немає парних чисел");
            }

            if (hasNumberEndingWithZeroRight)
            {
                MessageBox.Show("Знайдено число, що закінчується на 0, у правому куті");
            }
            else
            {
                MessageBox.Show("У правому куті немає чисел, що закінчуються на 0");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

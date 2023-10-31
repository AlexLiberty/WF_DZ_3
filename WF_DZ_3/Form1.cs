namespace WF_DZ_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int matrixSize = GetSelectedMatrixSize();

            int[,] matrixA = new int[matrixSize, matrixSize];
            int[,] matrixB = new int[matrixSize, matrixSize];

            ReadMatrixValues(matrixA, matrixSize, groupBox1);
            ReadMatrixValues(matrixB, matrixSize, groupBox2);

            int[,] resultMatrix = AddMatrices(matrixA, matrixB, matrixSize);

            DisplayMatrixValues(resultMatrix, matrixSize, textBox1);
        }
        private int GetSelectedMatrixSize()
        {
            int matrixSize = 0;

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                if (radioButton1.Checked)
                {
                    matrixSize = 3;
                }
                else if (radioButton2.Checked)
                {
                    matrixSize = 6;
                }
                else if (radioButton3.Checked)
                {
                    matrixSize = 9;
                }
            }

            if (radioButton4.Checked || radioButton5.Checked || radioButton6.Checked)
            {
                if (radioButton4.Checked)
                {
                    matrixSize = 3;
                }
                else if (radioButton5.Checked)
                {
                    matrixSize = 6;
                }
                else if (radioButton6.Checked)
                {
                    matrixSize = 9;
                }
            }

            return matrixSize;
        }
        private void ReadMatrixValues(int[,] matrix, int size, GroupBox groupBox)
        {
            Random random = new Random();

            int index = 0;

            foreach (RadioButton radioButton in groupBox.Controls)
            {
                if (radioButton.Checked)
                {
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            matrix[i, j] = random.Next(1, 101);
                            index++;
                        }
                    }
                    break;
                }
            }
        }
        private void DisplayMatrixValues(int[,] matrix, int size, TextBox textBox)
        {
            textBox.Clear();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    textBox.AppendText(matrix[i, j].ToString() + "\t");
                }
                textBox.AppendText(Environment.NewLine);
            }
        }
        private int[,] AddMatrices(int[,] matrixA, int[,] matrixB, int size)
        {
            int[,] resultMatrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            return resultMatrix;
        }
    }
}
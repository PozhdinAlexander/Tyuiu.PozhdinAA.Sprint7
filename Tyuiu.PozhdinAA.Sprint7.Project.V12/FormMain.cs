using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PozhdinAA.Sprint7.Project.V12.Lib;

namespace Tyuiu.PozhdinAA.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //openFileDialogTable_PAA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            //saveFileDialogNewData_PAA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            dateTimePickerRelease_PAA.CustomFormat = "DD MM YYYY";
        }
        DataService ds = new DataService();
        string pathPC = @"..\Back-end\personal_computer.csv";
        string pathSeller = @"..\Back-end\selling_company.csv";
        private void toolStripButtonInfoProgram_PAA_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.ShowDialog();
        }
        private void buttonPC_PAA_Click(object sender, EventArgs e)
        {
            dataGridViewPC_PAA.Visible = true;
            dataGridViewSeller_PAA.Visible = false;

            labelSearch_PAA.Visible = true;
            textBoxSearch_PAA.Visible = true;
            buttonSearchPC_PAA.Visible = true;
            buttonSearchSeller_PAA.Visible = false;

            textBoxManufacturer_PAA.Visible = true;
            textBoxClockFrequency_PAA.Visible = true;
            textBoxCountDisk_PAA.Visible = true;
            textBoxTypeCPU_PAA.Visible = true;
            textBoxPrice_PAA.Visible = true;
            numericUpDownCountCore_PAA.Visible = true;
            numericUpDownCountMemory_PAA.Visible = true;
            dateTimePickerRelease_PAA.Visible = true;
            buttonAddNewPC_PAA.Visible = true;
            buttonSavePC_PAA.Visible = true;
            buttonStatistic_PAA.Visible = true;
            labelClockFrequency_PAA.Visible = true;
            labelCountCore_PAA.Visible = true;
            labelCountDisk_PAA.Visible = true;
            labelCountMemory_PAA.Visible = true;
            labelManufacturer_PAA.Visible = true;
            labelPrice_PAA.Visible = true;
            labelTypeCPU_PAA.Visible = true;
            labelRelease_PAA.Visible = true;

            dataGridViewSeller_PAA.Visible = false;
            textBoxNameSeller_PAA.Visible = false;
            textBoxPhoneNumber_PAA.Visible = false;
            textBoxURL_PAA.Visible = false;
            textBoxAddress_PAA.Visible = false;
            buttonAddNewSeller_PAA.Visible = false;
            buttonSaveSeller_PAA.Visible = false;
            labelAddress_PAA.Visible = false;
            labelNameSeller_PAA.Visible = false;
            labelPhoneNumber_PAA.Visible = false;
            labelURL_PAA.Visible = false;


            textBoxTitle_PAA.Text = "Электронно-вычислительные машины";
            try
            {

                string[,] DataMatrix = ds.GetData(pathPC);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewPC_PAA.RowCount = rows;
                dataGridViewPC_PAA.ColumnCount = columns;

                dataGridViewPC_PAA.Columns[0].HeaderText = "Производитель";
                dataGridViewPC_PAA.Columns[1].HeaderText = "Тип процессора";
                dataGridViewPC_PAA.Columns[2].HeaderText = "Кол-во ядер";
                dataGridViewPC_PAA.Columns[3].HeaderText = "Тактовая частота";
                dataGridViewPC_PAA.Columns[4].HeaderText = "Объем ОЗУ";
                dataGridViewPC_PAA.Columns[5].HeaderText = "Объем ЖД";
                dataGridViewPC_PAA.Columns[6].HeaderText = "Дата выпуска";
                dataGridViewPC_PAA.Columns[7].HeaderText = "Цена";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewPC_PAA.Columns[i].Width = 150;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewPC_PAA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSeller_PAA_Click(object sender, EventArgs e)
        {
            dataGridViewPC_PAA.Visible = false;
            dataGridViewSeller_PAA.Visible = true;

            labelSearch_PAA.Visible = true;
            textBoxSearch_PAA.Visible = true;
            buttonSearchPC_PAA.Visible = false;
            buttonSearchSeller_PAA.Visible = true;

            textBoxManufacturer_PAA.Visible = false;
            textBoxClockFrequency_PAA.Visible = false;
            textBoxCountDisk_PAA.Visible = false;
            textBoxTypeCPU_PAA.Visible = false;
            textBoxPrice_PAA.Visible = false;
            numericUpDownCountCore_PAA.Visible = false;
            numericUpDownCountMemory_PAA.Visible = false;
            dateTimePickerRelease_PAA.Visible = false;
            buttonAddNewPC_PAA.Visible = false;
            buttonSavePC_PAA.Visible = false;
            buttonStatistic_PAA.Visible = false;
            labelClockFrequency_PAA.Visible = false;
            labelCountCore_PAA.Visible = false;
            labelCountDisk_PAA.Visible = false;
            labelCountMemory_PAA.Visible = false;
            labelManufacturer_PAA.Visible = false;
            labelPrice_PAA.Visible = false;
            labelTypeCPU_PAA.Visible = false;
            labelRelease_PAA.Visible = false;

            dataGridViewSeller_PAA.Visible = true;
            textBoxNameSeller_PAA.Visible = true;
            textBoxPhoneNumber_PAA.Visible = true;
            textBoxURL_PAA.Visible = true;
            textBoxAddress_PAA.Visible = true;
            buttonAddNewSeller_PAA.Visible = true;
            buttonSaveSeller_PAA.Visible = true;
            labelAddress_PAA.Visible = true;
            labelNameSeller_PAA.Visible = true;
            labelPhoneNumber_PAA.Visible = true;
            labelURL_PAA.Visible = true;

            textBoxTitle_PAA.Text = "Фирмы-реализаторы";
            try
            {

                string[,] DataMatrix = ds.GetData(pathSeller);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewSeller_PAA.RowCount = rows;
                dataGridViewSeller_PAA.ColumnCount = columns;

                dataGridViewSeller_PAA.Columns[0].HeaderText = "Наименование";
                dataGridViewSeller_PAA.Columns[1].HeaderText = "Адрес";
                dataGridViewSeller_PAA.Columns[2].HeaderText = "Номер телефона";
                dataGridViewSeller_PAA.Columns[3].HeaderText = "Ссылка на сайт";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewSeller_PAA.Columns[i].Width = 150;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewSeller_PAA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonManual_PAA_Click(object sender, EventArgs e)
        {
            FormManual manual = new FormManual();
            manual.Show();
        }

        private void buttonAbout_PAA_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.ShowDialog();
        }

        private void buttonSearchPC_PAA_Click(object sender, EventArgs e)
        {
            var data = ds.GetData(pathPC);
            var searchText = textBoxSearch_PAA.Text.ToLower();
            if (string.IsNullOrEmpty(searchText)) return;
            var filteredData = new List<string[]>();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0].ToLower().Contains(searchText) || data[i, 1].ToLower().Contains(searchText))
                {
                    var row = new string[data.GetLength(1)];
                    for (int j = 0; j < row.Length; j++)
                    {
                        row[j] = data[i, j];
                    }
                    filteredData.Add(row);
                }
            }

            var filteredDataArray = filteredData.ToArray();
            dataGridViewPC_PAA.RowCount = filteredDataArray.Length;
            dataGridViewPC_PAA.ColumnCount = filteredDataArray.Length == 0 ? 0 : filteredDataArray[0].Length;

            for (int r = 0; r < filteredDataArray.Length; r++)
            {
                for (int c = 0; c < filteredDataArray[0].Length; c++)
                {
                    dataGridViewPC_PAA.Rows[r].Cells[c].Value = filteredDataArray[r][c];
                }
            }
        }

        private void buttonAddNewSeller_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxURL_PAA.Text == "" || textBoxPhoneNumber_PAA.Text == "" || textBoxNameSeller_PAA.Text == "" || textBoxAddress_PAA.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] row = new string[] { $"{textBoxNameSeller_PAA.Text}", $"{textBoxAddress_PAA.Text}",
                    $"{textBoxPhoneNumber_PAA.Text}", $"{textBoxURL_PAA.Text}" };
                    dataGridViewSeller_PAA.Rows.Add(row);
                    bool completed = ds.AddNewData(pathSeller, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBoxNameSeller_PAA.Clear();
                    textBoxAddress_PAA.Clear();
                    textBoxPhoneNumber_PAA.Clear();
                    textBoxURL_PAA.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStatistic_PAA_Click(object sender, EventArgs e)
        {
            FormStatistic statistic = new FormStatistic();
            statistic.Show();
        }

        private void buttonSaveSeller_PAA_Click(object sender, EventArgs e)
        {
            string[,] data = new string[dataGridViewSeller_PAA.RowCount, dataGridViewSeller_PAA.ColumnCount];
            for (int i = 0; i < dataGridViewSeller_PAA.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewSeller_PAA.ColumnCount; j++)
                {
                    data[i, j] = dataGridViewSeller_PAA.Rows[i].Cells[j].Value.ToString();
                }
            }
            bool completed = ds.UpdateData(pathSeller, data);

            if (completed)
            {
                MessageBox.Show("Данные обновлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAddNewPC_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxManufacturer_PAA.Text == "" || textBoxTypeCPU_PAA.Text == "" || numericUpDownCountCore_PAA.Text == "" ||
                    textBoxClockFrequency_PAA.Text == "" || numericUpDownCountMemory_PAA.Text == "" || textBoxCountDisk_PAA.Text == "" ||
                    dateTimePickerRelease_PAA.Text == "" || textBoxPrice_PAA.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] row = new string[] { $"{textBoxManufacturer_PAA.Text}", $"{textBoxTypeCPU_PAA.Text}",
                    $"{numericUpDownCountCore_PAA.Text}", $"{textBoxClockFrequency_PAA.Text}",
                    $"{numericUpDownCountMemory_PAA.Text}", $"{textBoxCountDisk_PAA.Text}",
                    $"{dateTimePickerRelease_PAA.Text}", $"{textBoxPrice_PAA.Text}" };
                    dataGridViewPC_PAA.Rows.Add(row);
                    bool completed = ds.AddNewData(pathPC, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    textBoxManufacturer_PAA.Clear();
                    textBoxTypeCPU_PAA.Clear();
                    numericUpDownCountCore_PAA.Text = "0";
                    textBoxClockFrequency_PAA.Clear();
                    numericUpDownCountMemory_PAA.Text = "0";
                    textBoxCountDisk_PAA.Clear();
                    dateTimePickerRelease_PAA.Text = $"{DateTime.Now}";
                    textBoxPrice_PAA.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSavePC_PAA_Click(object sender, EventArgs e)
        {
            string[,] data = new string[dataGridViewPC_PAA.RowCount, dataGridViewPC_PAA.ColumnCount];
            for (int i = 0; i < dataGridViewPC_PAA.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewPC_PAA.ColumnCount; j++)
                {
                    data[i, j] = dataGridViewPC_PAA.Rows[i].Cells[j].Value.ToString();
                }
            }
            bool completed = ds.UpdateData(pathPC, data);

            if (completed)
            {
                MessageBox.Show("Данные обновлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
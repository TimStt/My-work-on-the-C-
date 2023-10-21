using EgoldsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zanetki_design;
using Zanetki_design.Controls;


namespace yt_DesignUI.Forms
{
    public partial class History_2 : Form
    {
        private Textbox_Control nameNote;
        private Textbox_Control textNote;
        private yt_Button cancelButton;
        private yt_Button saveButton;
        private yt_Button deleteBut;
        private string nmNote;
        private string txNote;


        //---------подключение к бд и создание стобцов в таблице-----------
        ConnectedDb database = new ConnectedDb();
        int selectedRow;
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        //-------настраиваем таблицу-------
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("№", "№");
            dataGridView1.Columns.Add("Название заметки", "Название");
            dataGridView1.Columns.Add("Описание", "Описание");
            dataGridView1.Columns.Add("Дата", "Дата");
            dataGridView1.Columns.Add("IsNew", String.Empty);

            dataGridView1.DefaultCellStyle.Font = new Font("Сalibri", 19, GraphicsUnit.Pixel);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 20, FontStyle.Bold);

            //вычисляем положение таблицы относительно центра контейнера
            int x = (panel1.Width - dataGridView1.Width) / 2 - 50;
            int y = (panel1.Height - dataGridView1.Height) / 2 - 10;

            //устанавливаем свойства Location и Anchor для таблицы
            dataGridView1.Location = new Point(x, y);
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.Dock = DockStyle.None;

            // отключаем автоматическое изменение размеров ячеек
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            //устанавливаем равномерную ширину для всех столбцов
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = 370;
            }
            //установка высоты шаблона строки
            dataGridView1.RowTemplate.Height = 100;

            // убираем из видимости лишние столбцы 
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            // устанавливаем свойство AllowUserToAddRows в false
            dataGridView1.AllowUserToAddRows = false;

            // Запрещаем пользователю изменять размеры столбцов
            dataGridView1.AllowUserToResizeColumns = false;

            // Запрещаем пользователю изменять размеры строк
            dataGridView1.AllowUserToResizeRows = false;

            // Устанавливаем таблицу только для чтения
            dataGridView1.ReadOnly = true;

            // Разрешаем выбирать только строки целиком, а не отдельные ячейки
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Выравнивание по середине
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void History_2_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        //-------настраиваем таблицу-------
        public History_2()
        {
            InitializeComponent();


        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from NoteTb";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetDateTime(3), RowState.ModifiedNew);
        }

        //---------подключение к бд и создание стобцов таблицы-----
        private void History_2_Load(object sender, EventArgs e)
        {
            if (yt_DesignUI.Properties.Settings.Default.checkBox == true)
            {
                this.BackColor = FlatColors.MidnightBlue;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                textbox_Control1_search.BackColor = FlatColors.MidnightBlue;

            }
            else
            {
                this.BackColor = Color.White;
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(109, 116, 174);
                dataGridView1.GridColor = Color.FromArgb(109, 116, 174);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.RowsDefaultCellStyle.SelectionBackColor = FlatColors.purpleWhite;
                textbox_Control1_search.BackColor = Color.White;
                textbox_Control1_search.ForeColor = Color.Black;
                iconPictureBox1.IconColor = Color.Black;
                label1.ForeColor= Color.Black;
                label1.BackColor= Color.White;
                iconPictureBox1.BackColor = Color.White;
            }
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            dataGridView1.ClearSelection();


            dataGridView1.CurrentCell = null;


        }

        private void History_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(nameNote.Texts) || !string.IsNullOrEmpty(textNote.Texts))
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть? Остались не сохраненные данные.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Отменяем закрытие формы
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                nmNote = row.Cells[1].Value.ToString();
                txNote = row.Cells[2].Value.ToString();
            }
        }

        private void History_2_SizeChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void History_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (!dataGridView1.DisplayRectangle.Contains(e.Location))
            {
                dataGridView1.ClearSelection();
                dataGridView1.CurrentCell = null;
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                CustomDialog2.Show("Выберите заметку!");
            }
            else
            {
                string nameNt2 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string textNt2 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                Add_elements(nameNt2, textNt2);

                this.Refresh();
            }

        }

        // добавление элементов на форму
        private void Add_elements(string name, string text1)
        {
            // скрываем таблицу и кнопку
            dataGridView1.Hide();
            yt_Button1.Hide();
            yt_Button2.Hide();
            textbox_Control1_search.Hide();
            iconPictureBox1.Hide();
            label1.Hide();

            // создаем новый экземпляр Textbox_Control и устанавливаем свойства Location и Anchor
            nameNote = new Textbox_Control();
            nameNote.Font = new Font("Tahoma", 48, FontStyle.Bold);
            nameNote.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            nameNote.Location = new Point(85, 54);
            nameNote.Size = new Size(1444, 111);
            nameNote.ShowScrollbar = false;
            nameNote.MultiLine = true;
            nameNote.UnderlinesStyle = true;
            nameNote.MaxChars = 30;
            nameNote.PlaceholderText = "ывывыввыв";
            nameNote.Texts = name;


            // Создаем второй контрол
            textNote = new Textbox_Control();
            textNote.Font = new Font("Onest Regular", 22);
            textNote.Location = new Point(85, 196);
            textNote.Size = new Size(1450, 450);
            textNote.MultiLine = true;
            textNote.ShowScrollbar = true;
            textNote.MaxChars = 10000;
            textNote.PlaceholderText = "ывывыввыв";
            if (yt_DesignUI.Properties.Settings.Default.checkBox == true)
            {
                nameNote.BackColor = FlatColors.MidnightBlue;
                textNote.BackColor = FlatColors.MidnightBlue;
                nameNote.ForeColor = Color.White;
                textNote.ForeColor = Color.White;
            }
            else
            {
                nameNote.ForeColor = Color.Black;
                textNote.ForeColor = Color.Black;
            }
            textNote.Texts = text1;

            // Создаем кнопку Сохранить
            saveButton = new yt_Button();
            saveButton.Text = "Сохранить";
            saveButton.Location = new Point(79, 783);
            saveButton.Size = new Size(213, 75);
            saveButton.BackColor = Color.FromArgb(109, 116, 174);

            // Создаем кнопку Отменить
            cancelButton = new yt_Button();
            cancelButton.Text = "Отменить";
            cancelButton.Location = new Point(1323, 777);
            cancelButton.Size = new Size(213, 75);
            cancelButton.BackColor = Color.FromArgb(109, 116, 174);

            cancelButton.Click += cancelButton_Click;
            saveButton.Click += saveButton_Click;

            textNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // привязываем событие 
            this.FormClosing += History_2_FormClosing;

            // Добавляем все контролы на форму
            panel1.Controls.Add(nameNote);
            panel1.Controls.Add(textNote);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(cancelButton);

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // проверяем пустые ли поля 
            var result = CustomDialog.Show("Вы уверены, что хотите закрыть?");
            if (result == DialogResult.OK)
            {
                this.FormClosing -= History_2_FormClosing;

                // Удаляем добавленные элементы управления
                nameNote.Dispose();
                textNote.Dispose();
                saveButton.Dispose();
                cancelButton.Dispose();

                // Показываем скрытые элементы управления
                dataGridView1.Show();
                yt_Button1.Show();
                yt_Button2.Show();
                textbox_Control1_search.Show();
                iconPictureBox1.Show();
                label1.Show();
            }
            else
            {
                return;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.FormClosing -= History_2_FormClosing;
            // Сохраняем изменения в базе данных
            Change();

            // Удаляем добавленные элементы управления
            nameNote.Dispose();
            textNote.Dispose();
            saveButton.Dispose();
            cancelButton.Dispose();

            // Показываем скрытые элементы управления
            dataGridView1.Show();
            yt_Button1.Show();
            yt_Button2.Show();
            iconPictureBox1.Show();
            label1.Show();
            textbox_Control1_search.Show();

            // Обновляем и сохраняем изменения в бд
            UpdateRow();

        }

        // изменяем данные в таблице НО не сохраняем бд
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var nNote = nameNote.Texts;
            var tNote = textNote.Texts;

            if (string.IsNullOrEmpty(nNote) && string.IsNullOrEmpty(tNote))
            {
                CustomDialog.Show("Введите данные для сохранения");
            }
            else
            {
                dataGridView1.Rows[selectedRowIndex].Cells[1].Value = nNote;
                dataGridView1.Rows[selectedRowIndex].Cells[2].Value = tNote;
                dataGridView1.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                // Удаляем добавленные элементы управления
                nameNote.Dispose();
                textNote.Dispose();
                saveButton.Dispose();
                cancelButton.Dispose();

                // Показываем скрытые элементы управления
                dataGridView1.Show();
                yt_Button1.Show();
                yt_Button2.Show();

                // Обновляем и сохраняем изменения в бд
                UpdateRow();
            }
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void UpdateRow()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from NoteTb where [№] = {id}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();

                }
                if (rowState == RowState.Modified)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var nameNote = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
                    var tNote = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
                    var data = Convert.ToDateTime(dataGridView1.Rows[index].Cells[3].Value);


                    var changeQuery = $"update NoteTb set [Название заметки] = '{nameNote}',Описание = '{tNote}',Дата = '{data}' where [№] ='" + id + "'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();




                }
            }
            database.closeConnection();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                CustomDialog2.Show("Выберите заметку!");

            }
            else
            {
                var result = CustomDialog.Show("Вы точно хотите удалить?");
                if (result == DialogResult.OK)
                {
                    DeleteRow();
                    UpdateRow();
                }
                else
                {
                    return;
                }

            }


        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = "";
            string[] searchParams = textbox_Control1_search.Texts.Split(':');

            if (searchParams.Length == 2)
            {
                string columnName = searchParams[0].Trim();
                string searchValue = searchParams[1].Trim();

                switch (columnName)
                {
                    case "Название заметки":
                        searchString = $"Select * from NoteTb where [Название заметки] like '%{searchValue}%'";
                        break;
                    case "Описание":
                        searchString = $"Select * from NoteTb where Описание like '%{searchValue}%'";
                        break;
                    case "Дата":
                        searchString = $"Select * from NoteTb where Дата like '%{searchValue}%'";
                        break;
                    default:
                        searchString = $"Select * from NoteTb where concat ( [Название заметки], Описание, Дата) like '%{searchValue}%'";
                        break;
                }
            }
            else
            {
                searchString = $"Select * from NoteTb where concat ( [Название заметки], Описание, Дата) like '%{textbox_Control1_search.Texts}%'";
            }

            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgv, read);
            }
            read.Close();
        }


        private void textbox_Control1__TextChanged(object sender, EventArgs e)
        {


        }

        private void textbox_Control1_search__TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
    }
}








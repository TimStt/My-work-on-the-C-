using EgoldsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using yt_DesignUI.Forms;
using Zanetki_design;
using Zanetki_design.Controls;

namespace yt_DesignUI
{
    public partial class SelfMakling_1 : ShadowedForm
    {
        ConnectedDb database = new ConnectedDb();

        private const int MaxChars = 100;
        private bool isNumbered = false; // флаг для определения типа списка
        bool isListEnabled = false;
        int firstItemPos = -3;

        public SelfMakling_1()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Opacity = 0;
            //  this.FormClosing += SelfMakling_1_FormClosing; // добавляем обработчик события

            if (string.IsNullOrEmpty(textbox_Control1_text.PlaceholderText))
            {
                if (string.IsNullOrEmpty(textbox_Control1_name.PlaceholderText))
                {
                    textbox_Control1_text.PlaceholderText = "Введите текст заметки";
                    textbox_Control1_name.PlaceholderText = "Введите текст заметки";
                }
            }


            // подключение к базе данных
            ConnectedDb database = new ConnectedDb();

            saveFileDialog1.Filter = "Note (*.txt)|*.txt|Notes file (*.nf)|*.nf";


        }
        private void contextExitBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelfMakling_Load(object sender, EventArgs e)
        {
            numberedToolStripButton.FlatAppearance.BorderSize = 0;
            dropdownMenu1.Closed += dropdownMenu1_DropDownClosed;

            // ----изменение темы----
            if (yt_DesignUI.Properties.Settings.Default.checkBox == true)
            {
                this.BackColor = FlatColors.MidnightBlue;
                textbox_Control1_text.BackColor = FlatColors.MidnightBlue;
                textbox_Control1_text.ForeColor = Color.White;
                textbox_Control1_text.PlaceholderColor = Color.Gray;
                // textbox_Control1_text.BorderColor = FlatColors.MidnightBlue;
                // textbox_Control1_text.BorderFocusColor = FlatColors.MidnightBlue;
                textbox_Control1_name.BackColor = FlatColors.MidnightBlue;
                textbox_Control1_name.ForeColor = Color.White;
                textbox_Control1_name.PlaceholderColor = Color.Gray;
                //textbox_Control1_zametka.BorderColor = FlatColors.MidnightBlue;
                textbox_Control1_name.BorderFocusColor = FlatColors.MidnightBlue;
                iconPictureBox1.BackColor = FlatColors.MidnightBlue;
                iconPictureBox1.IconColor = Color.White;
                numberedToolStripButton.BackColor = FlatColors.MidnightBlue;
                numberedToolStripButton.IconColor = Color.White;
            }
            else
            {

                return;
            }
            // ----изменение темы----

            textbox_Control1_text.KeyDown += Textbox_Control1_text_KeyDown;
            textbox_Control1_text.MouseUp += Textbox_Control1_text_MouseUp;
            textbox_Control1_text.KeyPress += new KeyPressEventHandler(textbox_Control1_text_KeyPress);
            
        }

        private void Textbox_Control1_text_MouseUp(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Textbox_Control1_text_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textbox_Control2__TextChange(object sender, EventArgs e)
        {

        }

        private void btnGradient_Click(object sender, EventArgs e)
        {

        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            yt_Button1.Text = "Сохраняем...";
            dropdownMenu1.Show(yt_Button1, yt_Button1.Width, 0);

        }
        private void dropdownMenu1_DropDownClosed(object sender, EventArgs e)
        {
            yt_Button1.Text = "Сохранить";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void egoldsToggleSwitch1_CheckedChanged(object sender)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ----сохранение заметки-----
            if (string.IsNullOrEmpty(textbox_Control1_text.Texts))
            {
                if (string.IsNullOrEmpty(textbox_Control1_name.Texts))
                {
                    MessageBox.Show("Нет текста");
                    return;
                }
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, "Название заметки: " + textbox_Control1_name.Texts + " Текст заметки: " + textbox_Control1_text.Texts);

            // подключаем базу данных
            database.openConnection();
            string nameNote = textbox_Control1_name.Texts;
            string textNote = textbox_Control1_text.Texts;
            var dateNote = DateTime.Now;
            var addQuerry = $"insert into NoteTb ( [Название заметки], Описание, Дата) values ('{nameNote}','{textNote}','{dateNote}')";
            var command = new SqlCommand(addQuerry, database.getConnection());
            command.ExecuteNonQuery();
            textbox_Control1_name.Texts = "";
            textbox_Control1_text.Texts = "";
            CustomDialog2.Show("Заметка сохранена");
            // ----сохранение заметки-----
        }

        private void textbox_Control1_zametka__TextChange(object sender, EventArgs e)
        {

        }

        private void textbox_Control1_zametka_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textbox_Control1__TextChange(object sender, EventArgs e)
        {

        }

        private void customScrollBar1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTrackbar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void customScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void cjhfybnmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ----сохранение заметки-----
            if (string.IsNullOrEmpty(textbox_Control1_text.Texts))
            {
                if (string.IsNullOrEmpty(textbox_Control1_name.Texts))
                {
                    MessageBox.Show("Нет текста");
                    return;

                }
            }
            // подключаем базу данных
            database.openConnection();
            string nameNote = textbox_Control1_name.Texts;
            string textNote = textbox_Control1_text.Texts;
            var dateNote = DateTime.Now;
            var addQuerry = $"insert into NoteTb ( [Название заметки], Описание, Дата) values ('{nameNote}','{textNote}','{dateNote}')";
            var command = new SqlCommand(addQuerry, database.getConnection());
            command.ExecuteNonQuery();
            textbox_Control1_name.Texts = "";
            textbox_Control1_text.Texts = "";
            textbox_Control1_text.PlaceholderText = "Введите текст заметки";
            textbox_Control1_name.PlaceholderText = "Введите название заметки";
            CustomDialog2.Show("Заметка сохранена");
        }


        private void textbox_Control1_name__TextChange(object sender, EventArgs e)
        {

        }

        // импорт файла 
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            ImportFail();

        }

        private void ImportFail()
        {

            if (string.IsNullOrEmpty(textbox_Control1_text.Texts))
            {
                if (string.IsNullOrEmpty(textbox_Control1_name.Texts))
                {


                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Text Files (*.txt;*.doc)|*.txt;*.doc";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = openFileDialog.FileName;

                        // выводим имя файла в другое текстовое поле и избавляемся от расширения

                        textbox_Control1_name.Texts = Path.GetFileNameWithoutExtension(openFileDialog.FileName);


                        if (Path.GetExtension(fileName) == ".txt")
                        {
                            // импортируем содержимое файла в текстовое поле

                            textbox_Control1_text.Texts = File.ReadAllText(fileName);

                        }


                        else if (Path.GetExtension(fileName) == ".doc")
                        {
                            // используем библиотеку Microsoft.Office.Interop.Word для чтения содержимого файла .doc
                            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                            object miss = System.Reflection.Missing.Value;
                            object path = fileName;
                            object readOnly = true;
                            Microsoft.Office.Interop.Word.Document doc = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
                            string text = doc.Content.Text;
                            textbox_Control1_text.Texts = text;
                            doc.Close();
                            word.Quit();
                        }


                    }
                }
                else
                {
                    var result = MessageBox.Show(" Вы действительно хотите импортировать данные? У вас есть не сохраненные данные!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.Filter = "Text Files (*.txt;*.doc)|*.txt;*.doc";

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = openFileDialog.FileName;

                            // выводим имя файла в другое текстовое поле и избавляемся от расширения
                            textbox_Control1_name.Texts = Path.GetFileNameWithoutExtension(openFileDialog.FileName);


                            if (Path.GetExtension(fileName) == ".txt")
                            {
                                // импортируем содержимое файла в текстовое поле
                                textbox_Control1_text.Texts = File.ReadAllText(fileName);

                            }



                            else if (Path.GetExtension(fileName) == ".doc")
                            {
                                // используем библиотеку Microsoft.Office.Interop.Word для чтения содержимого файла .doc
                                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                                object miss = System.Reflection.Missing.Value;
                                object path = fileName;
                                object readOnly = true;
                                Microsoft.Office.Interop.Word.Document doc = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
                                string text = doc.Content.Text;
                                textbox_Control1_text.Texts = text;
                                doc.Close();
                                word.Quit();
                            }

                        }
                    }
                    else
                    {
                        return;
                    }

                }


            }
        }

        private void textNoteBox(string nameNt1, string textNt1)
        {
            textbox_Control1_name.Texts = nameNt1;
            textbox_Control1_name.Texts = textNt1;
        }
        private void textbox_Control1_text__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textbox_Control1_text_Enter(object sender, EventArgs e)
        {

        }

        private void textbox_Control1_name__TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_Control1_name_Enter(object sender, EventArgs e)
        {

        }

        private void textbox_Control1_text_Leave(object sender, EventArgs e)
        {

        }

        private void textbox_Control1_name_Leave(object sender, EventArgs e)
        {

        }

        private void numberedToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void numberedToolStripButton_Click_1(object sender, EventArgs e)
        {
            if (!isListEnabled)
            {
                // проверяем, выделен ли текст в тексбоксе
                if (textbox_Control1_text.SelectionLength > 0)
                {
                    // если текст выделен, заменяем его на список
                    int start = textbox_Control1_text.SelectionStart;
                    int end = start + textbox_Control1_text.SelectionLength;
                    string textToReplace = textbox_Control1_text.SelectedText.TrimEnd('\n', '\r');
                    string[] lines = textToReplace.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < lines.Length; i++)
                    {
                        sb.AppendLine((i + 1) + ". " + lines[i]);
                    }
                    textbox_Control1_text.Texts = textbox_Control1_text.Texts.Remove(start, end - start).Insert(start, sb.ToString().TrimEnd('\n', '\r'));
                    textbox_Control1_text.SelectionStart = start;
                    textbox_Control1_text.SelectionLength = sb.Length;
                }
                else
                {
                    // если текст не выделен, добавляем первую строку списка на место курсора
                    int cursorPosition = textbox_Control1_text.SelectionStart;
                    textbox_Control1_text.SelectedText = "1. ";
                    textbox_Control1_text.SelectionStart = cursorPosition + 3;
                    textbox_Control1_text.Focus();
                }

                // Включаем список
                isListEnabled = true;

                if (textbox_Control1_text.TextLength == 0)
                {
                    textbox_Control1_text.AppendText("1. ");
                    firstItemPos = 2;
                }
                else
                {
                    // Иначе добавляем первый элемент на место курсора
                    firstItemPos = textbox_Control1_text.SelectionStart + 3;
                }
                numberedToolStripButton.IconColor = Color.LightBlue;
            }
            else
            {
                // Выключаем список
                isListEnabled = false;
                if (yt_DesignUI.Properties.Settings.Default.checkBox == true)
                {
                    numberedToolStripButton.IconColor = Color.White;
                }
                else
                {
                    numberedToolStripButton.IconColor = Color.Black;
                }
            }
        }

        private void textbox_Control1_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isListEnabled)
            {
                // Проверяем, нажал ли пользователь клавишу Enter
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // Если пользователь нажал Enter, то добавляем следующую строку списка
                    textbox_Control1_text.AppendText(Environment.NewLine + (textbox_Control1_text.Lines.Length + 1).ToString() + ". ");
                    e.Handled = true;
                }
            }
        }

        private void textbox_Control1_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (isListEnabled)
            {
               
                if (e.KeyCode == Keys.Tab)
                {
                    // Если пользователь нажал Tab, то добавляем отступ в начале строки
                    int cursorPosition = textbox_Control1_text.SelectionStart;
                    textbox_Control1_text.Texts = textbox_Control1_text.Texts.Insert(cursorPosition, "    ");
                    textbox_Control1_text.SelectionStart = cursorPosition + 4;
                    e.Handled = true;
                }

                else if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
                {
                    // Если пользователь нажал Ctrl+V, то проверяем, есть ли выделенный текст
                    if (textbox_Control1_text.SelectionLength > 0)
                    {
                        // Если текст выделен, то заменяем его на список
                        string list = "";
                        int lineNum = 1;
                        foreach (string line in textbox_Control1_text.SelectedText.Split('\n'))
                        {
                            if (line.Trim() != "")
                            {
                                list += lineNum.ToString() + ". " + line.Trim() + Environment.NewLine;
                                lineNum++;
                            }
                        }
                        int start = textbox_Control1_text.SelectionStart;
                        textbox_Control1_text.SelectedText = list;
                        textbox_Control1_text.SelectionStart = start;
                    }
                    else
                    {
                        // Если текст не выделен, то добавляем начальное значение списка на месте курсора
                        int cursorPosition = textbox_Control1_text.SelectionStart;
                        textbox_Control1_text.SelectionStart = cursorPosition + 3;
                    }
                    e.Handled = true;
                }
            }
        }



            private void textbox_Control1_text_MouseUp(object sender, MouseEventArgs e)
        {


           
        }

        private void textbox_Control2_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_Control2_text_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void textbox_Control2_text_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
                

    











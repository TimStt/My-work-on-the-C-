using EgoldsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zanetki_design.Controls
{
    [DefaultEvent("_TextChanged")]
    public partial class Textbox_Control : UserControl
    {
        #region ----Поля----
        private Color borderColor = Color.MediumSlateBlue; // цвет обводки текстбокса по умолчанию 
        private int borderSize = 2; // толщина обводки текстбокса по умолчанию
        private bool underlinesStyle = false;
        private Color borderFocusColor = FlatColors.BlueDark; // цвет обводки текстбокса при нажатии 
        private bool isFocused = false;
        private Color placeholderColor = Color.DarkGray; // цвет placeholder  
        private string placeholderText = ""; // текст placeholder
        private bool isPlaceHolder = false;
        private bool isPasswordChar = false;
        private int maxChars;
        private bool _showscrollbar = true;
        private Timer cursorTimer = new Timer();
        private bool  showCursor = true;
        private Point cursorPosition = new Point(0, 0);
        public event EventHandler SelectionChanged;


        #endregion
        public Textbox_Control(int borderSize = 0, bool underlinesStyle = false)
        {
            InitializeComponent();
            BorderSize = borderSize;
            UnderlinesStyle = underlinesStyle;
            this.DoubleBuffered = true;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(0, this.Height);
            vScrollBar2.Scroll += VScrollBar2_Scroll;
            textBox1.MouseWheel += TextBox1_MouseWheel;
            vScrollBar2.BackColor = Color.Green; // задаем цвет фона
            vScrollBar2.ForeColor = Color.White; // задаем цвет шрифта
            vScrollBar2.Scroll += (sender, e) => vScrollBar2.Invalidate(); // перерисовываем скроллбар

            // настройка таймера мигания курсора
            cursorTimer.Interval = 500; // интервал 0,5 секунды
            cursorTimer.Tick += CursorTimer_Tick;
            cursorTimer.Enabled = true;

            SetPlaceHolder();
        }

        // какое-либо событие 
        public event EventHandler _TextChanged;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }


            if(ShowScrollbar == true)
            {
                UpdateScrollbarVisibility();
                vScrollBar2.Maximum = textBox1.GetLineFromCharIndex(textBox1.Text.Length) + 1;
            }
            
        }



        private void DrawCursor()
        {
            using (Graphics g = textBox1.CreateGraphics())
            {
                Rectangle cursorRect = new Rectangle(cursorPosition, new Size(2, this.Font.Height));
                g.FillRectangle(Brushes.Black, cursorRect);
            }
        }
        // обработчик события таймера мигания курсора
        private void CursorTimer_Tick(object sender, EventArgs e)
        {
            showCursor = !showCursor;
            Refresh();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }

        #region ---свойства текстбокса---
        public Color BorderColor  // цвет обводки
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public string SelectedText
        {
            get { return textBox1.SelectedText; }
            set { textBox1.SelectedText = value; }
            
        }
 

        public int BorderSize // толщина обводки
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public int GetFirstCharIndexOfCurrentLine()
        {
            return textBox1.GetFirstCharIndexOfCurrentLine();
        }
        public void AppendText(string text)
        {
            textBox1.AppendText(text);
        }
        public int GetFirstCharIndexFromLine(int lineNumber)
        {
            int index = textBox1.GetFirstCharIndexFromLine(lineNumber);
            if (index < 0 || lineNumber < 0)
                return -1;

            int line = 0;
            for (int i = 0; i < this.Text.Length; i++)
            {
                if (line == lineNumber)
                {
                    return i;
                }

                if (this.Text[i] == '\n')
                {
                    line++;
                }
            }

            return -1;
        }
        
        public string[] Lines
        {
            get { return textBox1.Lines; }
            set { textBox1.Lines = value; }
        }
        public void Select(int start, int length)
        {
            textBox1.Select(start, length);
            
        }
        public int GetLineFromCharIndex(int charIndex)
        {
            return textBox1.GetLineFromCharIndex(charIndex);
        }

        public void ScrollToCaret()
        {
            textBox1.ScrollToCaret();
        }

        public bool ShowScrollbar
        {
            get { return _showscrollbar; }
            set
            {
                _showscrollbar = value;
                if (!_showscrollbar)
                {
                    this.Controls.Remove(vScrollBar2);
                }
                else
                {
                    this.Controls.Add(vScrollBar2);
                    UpdateScrollbarVisibility();
                }
            }
        }
                
         
        public int MaxChars
        {
            get { return maxChars; }
            set
            {
                maxChars = value;
                if (textBox1.Text.Length > maxChars)
                {
                    textBox1.Text = textBox1.Text.Substring(0, maxChars);
                }
            }
        }


 
        public bool UnderlinesStyle // стиль обводки
        {
            get
            {
                return underlinesStyle;
            }
            set
            {
                underlinesStyle = value;
                this.Invalidate();
            }

        }
        public bool AcceptsReturns
        {
            get
            {
                return textBox1.AcceptsReturn;
            }
            set
            {
                textBox1.AcceptsReturn = value;
            }

        }
        public string[] Liness
        {
            get
            {
                return textBox1.Lines;
            }
            set
            {
                textBox1.Lines = value;
            }

        }
        public int SelectionStart
        {
            get
            {
                return textBox1.SelectionStart;
            }
            set
            {
                textBox1.SelectionStart = value;
            }
        }
        public int SelectionLength
        {
            get
            {
                return textBox1.SelectionLength;
            }
            set
            {
                textBox1.SelectionLength = value;
            }
        }
        public int TextLength
        {
            get
            {
                return textBox1.TextLength;
            }
           
        }
        

        public bool PasswordChar // пороль 
                {
                    get 
                    {
                        return isPasswordChar; 
                    }
                    set 
                    {
                        isPasswordChar = value;
                        textBox1.UseSystemPasswordChar = value; 
                    }

                }
        public bool MultiLine // возможность растягивания элемента
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        public override Color BackColor // цвет заднего фона
        {
            get
            {
                return base.BackColor;

            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        public override Color ForeColor // цвет текста
        {
            get
            {
                return base.ForeColor;

            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        public override Font Font // шрифт
        {
            get
            {
                return base.Font;

            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();              
            }
        }
        public int MaxLengths
        {
            get
            {
                return textBox1.MaxLength;
            }
            set
            {
                textBox1.MaxLength = value;
            }
        }

        public string Texts
        {
            get
            {
                if (isPlaceHolder) return "";
                else return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                if (string.IsNullOrWhiteSpace(value) || value == placeholderText)
                {
                    SetPlaceHolder();
                }
                else
                {
                    isPlaceHolder = false;
                    textBox1.ForeColor = this.ForeColor;
                    if (isPasswordChar)
                        textBox1.UseSystemPasswordChar = true;
                }
            }
        }
        public Color BorderFocusColor // цвет при нажатии  
        {
            get
            {
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
            }
        }


   

        public Color PlaceholderColor // цвет placeholder
        {
            get
            {
                return placeholderColor;
            }
            set
            {
                placeholderColor = value;
                if (isPlaceHolder)
                    textBox1.ForeColor = value;
            }
        }

        public string PlaceholderText  // текст placeholder
        {
            get
            {
                return placeholderText;
            }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceHolder();
            }       
        }
        #endregion


        private void SetPlaceHolder()
        {
            isPlaceHolder = true;
            textBox1.ForeColor = placeholderColor;
            textBox1.UseSystemPasswordChar = false;
            textBox1.Text = placeholderText;
        }

        private void RemovePlaceHolder() // удаление текста в placeholder
        {

            if (isPlaceHolder && placeholderText != "")
            {
                isPlaceHolder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }


        private void VScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.ScrollToCaret();
        }


        // Метод рисования 
        protected override void OnPaint(PaintEventArgs e)
        {
            // вызываем базовый метод 
            base.OnPaint(e);

            // объявим объект класса в котором содержатся все нужные методы для визуализации графического интерфейса
            Graphics graph = e.Graphics;

            //рисуем границы


            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (!isFocused)
                {
                    if (underlinesStyle) // стиль обводки                
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlinesStyle) // стиль обводки                
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                

            }
            if (string.IsNullOrEmpty(Text) && !Focused)
            {
                using (var brush = new SolidBrush(PlaceholderColor))
                {
                    e.Graphics.DrawString(PlaceholderText, Font, brush, new Point(0, 0));
                }
            }
            // отрисовка курсора, если он должен отображаться
            if (showCursor && this.Focused)
            {
                DrawCursor();
            }

        }
        private void UpdateScrollbarVisibility()
        {
            int visibleLines = textBox1.ClientSize.Height / textBox1.Font.Height;
            int totalLines = textBox1.GetLineFromCharIndex(textBox1.Text.Length) + 1;

            vScrollBar2.Visible = _showscrollbar && (visibleLines < totalLines);
            textBox1.ScrollBars = vScrollBar2.Visible ? ScrollBars.None : ScrollBars.Vertical;
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int textHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, textHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;

            }
        }
        // конструктор 
        public Textbox_Control()
        {
            InitializeComponent();
        }

        #region ---события--- 
     

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {

        
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
            if (textBox1.TextLength >= maxChars && e.KeyChar != (char)Keys.Back) // проверка, достигнут ли лимит символов и нажата ли клавиша Backspace
            {
                e.Handled = true; // блокировка ввода символов
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
           
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            if (isPlaceHolder)
            {
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
            RemovePlaceHolder();
            this.Invalidate();
        }

        private void TextBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (vScrollBar2.Visible)
            {
                int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
                int numberOfPixelsToMove = numberOfTextLinesToMove * textBox1.Font.Height;
                int newValue = vScrollBar2.Value - numberOfPixelsToMove;

                vScrollBar2.Value = Math.Max(vScrollBar2.Minimum, Math.Min(vScrollBar2.Maximum - vScrollBar2.LargeChange, newValue));
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SetPlaceHolder();
            }
            this.Invalidate();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        
            // Получаем количество символов в текстбоксе
            int currentLength = textBox1.TextLength;

            // Получаем количество символов, которые будут добавлены при вставке текста
            int addedLength = 0;

            if (e.Control && e.KeyCode == Keys.V) // Если нажата комбинация клавиш Ctrl+V
            {
                if (Clipboard.ContainsText())
                {
                    addedLength = Clipboard.GetText().Length;
                }
            }
            else // Если вставка не осуществляется, получаем количество добавленных символов по событию KeyPress
            {
                addedLength = 1;
            }

            // Проверяем, достигнуто ли максимальное количество символов
            if (currentLength + addedLength > maxChars)
            {
                // Отменяем ввод символов, если лимит превышен
                e.SuppressKeyPress = true;
                e.Handled = true;

                // Выводим сообщение о превышении лимита символов
                MessageBox.Show($"Предупреждение: Достигнут максимальный лимит символов {maxChars}.");
               
            }
          
        }
       

        private void vScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Top = -vScrollBar2.Value;
        }
        #endregion

        private void Textbox_Control_Load(object sender, EventArgs e)
        {

        }
    }
}
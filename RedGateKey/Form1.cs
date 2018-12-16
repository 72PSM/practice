using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedGateKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MyInitializeComponent();
            //this.Text = Class5.string_0 + " Keygen [LineZer0]";
            this.Text = Class5.string_0 + "Key";
            this.comboBox1.DataSource = Class5.string_1;
            if (Class5.string_1.Length == 1)
            {
                this.comboBox1.SelectedIndex = 0;
                Control control = this.comboBox1;
                this.label1.Visible = false;
                control.Visible = false;
            }
            this.textBox1.Text = Class3.smethod_0();
        }

        private void MyInitializeComponent()
        {
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.label2 = new Label();
            this.numericUpDown1 = new NumericUpDown();
            this.textBox1 = new TextBox();
            this.button1 = new Button();
            this.comboBox1 = new ComboBox();
            this.label1 = new Label();
            ((ISupportInitialize)this.numericUpDown1).BeginInit();
            base.SuspendLayout();
            this.textBox2.BackColor = Color.FromArgb(238, 238, 238);
            this.textBox2.BorderStyle = BorderStyle.FixedSingle;
            this.textBox2.Font = new Font("Lucida Console", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox2.ForeColor = Color.FromArgb(51, 51, 51);
            this.textBox2.Location = new Point(12, 36);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(468, 120);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += this.textBox2_TextChanged;
            this.textBox2.MouseEnter += this.textBox2_MouseEnter;
            this.textBox3.BackColor = Color.FromArgb(238, 238, 238);
            this.textBox3.BorderStyle = BorderStyle.FixedSingle;
            this.textBox3.Font = new Font("Lucida Console", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox3.ForeColor = Color.FromArgb(51, 51, 51);
            this.textBox3.Location = new Point(12, 162);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new Size(570, 204);
            this.textBox3.TabIndex = 2;
            this.textBox3.MouseEnter += this.textBox3_MouseEnter;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(483, 43);
            this.label2.Name = "label2";
            this.label2.Size = new Size(79, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Count :";
            this.numericUpDown1.BackColor = Color.FromArgb(238, 238, 238);
            this.numericUpDown1.BorderStyle = BorderStyle.None;
            this.numericUpDown1.ForeColor = Color.Black;
            this.numericUpDown1.Location = new Point(486, 66);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new Size(93, 18);
            this.numericUpDown1.TabIndex = 6;
            NumericUpDown numericUpDown = this.numericUpDown1;
            int[] array = new int[4];
            array[0] = 1;
            numericUpDown.Value = new decimal(array);
            this.numericUpDown1.ValueChanged += this.numericUpDown1_ValueChanged;
            this.textBox1.BackColor = Color.FromArgb(238, 238, 238);
            this.textBox1.BorderStyle = BorderStyle.FixedSingle;
            this.textBox1.Font = new Font("Lucida Console", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textBox1.ForeColor = Color.FromArgb(51, 51, 51);
            this.textBox1.Location = new Point(12, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(468, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = HorizontalAlignment.Center;
            this.textBox1.MouseEnter += this.textBox1_MouseEnter;
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button1.Location = new Point(490, 9);
            this.button1.Name = "button1";
            this.button1.Size = new Size(92, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.comboBox1.BackColor = Color.FromArgb(238, 238, 238);
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = FlatStyle.Flat;
            this.comboBox1.ForeColor = Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(486, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(96, 23);
            this.comboBox1.TabIndex = 10;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(486, 98);
            this.label1.Name = "label1";
            this.label1.Size = new Size(55, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Edition :";
            base.AcceptButton = this.button1;
            base.AutoScaleDimensions = new SizeF(7f, 15f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(238, 238, 238);
            base.ClientSize = new Size(594, 378);
            base.Controls.Add(this.comboBox1);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.numericUpDown1);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.textBox2);
            this.Font = new Font("Lucida Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Black;
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(4);
            this.MaximumSize = new Size(600, 400);
            this.MinimumSize = new Size(600, 400);
            base.Name = "Main";
            this.Text = "This is a keygen.";
            ((ISupportInitialize)this.numericUpDown1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && this.icontainer_0 != null)
        //    {
        //        this.icontainer_0.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Class3.smethod_0();
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.method_1();
        }

        
        private void method_0(object sender, EventArgs e)
        {
            this.method_1();
        }

        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.method_1();
        }

        
        private void method_1()
        {
            string text = this.textBox2.Text;
            string text2 = this.comboBox1.SelectedItem.ToString();
            int num = (int)this.numericUpDown1.Value;
            if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2) && num != 0)
            {
                try
                {
                    this.textBox3.Text = Class4.smethod_1(text, text2, num);
                }
                catch
                {
                    this.textBox3.Text = "";
                }
            }
        }

        
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            this.textBox1.SelectAll();
        }

        
        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.Focus();
            this.textBox2.SelectAll();
        }

        
        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            this.textBox3.Focus();
            this.textBox3.SelectAll();
        }

        
        private IContainer icontainer_0;

        
        private TextBox textBox2;

        
        private TextBox textBox3;

        
        private Label label2;

        
        private NumericUpDown numericUpDown1;

        
        private TextBox textBox1;

       
        private Button button1;

        
        private ComboBox comboBox1;

        
        private Label label1;
    }
}

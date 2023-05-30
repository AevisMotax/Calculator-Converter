namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ClearEntry = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.openP = new System.Windows.Forms.Button();
            this.CloseP = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Exponent = new System.Windows.Forms.Button();
            this.Squareroot = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(527, 307);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ClearEntry
            // 
            this.ClearEntry.BackColor = System.Drawing.Color.DarkOrange;
            this.ClearEntry.Location = new System.Drawing.Point(338, 39);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(75, 75);
            this.ClearEntry.TabIndex = 3;
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = false;
            this.ClearEntry.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DarkOrange;
            this.Clear.Location = new System.Drawing.Point(257, 39);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 75);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // openP
            // 
            this.openP.BackColor = System.Drawing.Color.DarkGray;
            this.openP.Location = new System.Drawing.Point(257, 120);
            this.openP.Name = "openP";
            this.openP.Size = new System.Drawing.Size(75, 75);
            this.openP.TabIndex = 5;
            this.openP.Text = "(";
            this.openP.UseVisualStyleBackColor = false;
            // 
            // CloseP
            // 
            this.CloseP.BackColor = System.Drawing.Color.DarkGray;
            this.CloseP.Location = new System.Drawing.Point(338, 120);
            this.CloseP.Name = "CloseP";
            this.CloseP.Size = new System.Drawing.Size(75, 75);
            this.CloseP.TabIndex = 6;
            this.CloseP.Text = ")";
            this.CloseP.UseVisualStyleBackColor = false;
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(14, 282);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(75, 75);
            this.Zero.TabIndex = 0;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.DarkGray;
            this.Plus.Location = new System.Drawing.Point(257, 282);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 75);
            this.Plus.TabIndex = 10;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.DarkGray;
            this.Minus.Location = new System.Drawing.Point(338, 282);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 75);
            this.Minus.TabIndex = 11;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(176, 201);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(75, 75);
            this.Nine.TabIndex = 9;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(95, 201);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(75, 75);
            this.Eight.TabIndex = 8;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(14, 201);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 75);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(176, 120);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(75, 75);
            this.Six.TabIndex = 6;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(95, 120);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(75, 75);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(14, 120);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(75, 75);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(176, 39);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(75, 75);
            this.Three.TabIndex = 3;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(95, 39);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(75, 75);
            this.Two.TabIndex = 2;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(14, 39);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(75, 75);
            this.One.TabIndex = 1;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(14, 363);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(156, 80);
            this.Equal.TabIndex = 12;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Decimal
            // 
            this.Decimal.BackColor = System.Drawing.Color.DarkGray;
            this.Decimal.Location = new System.Drawing.Point(419, 39);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(75, 75);
            this.Decimal.TabIndex = 13;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = false;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.DarkGray;
            this.Divide.Location = new System.Drawing.Point(338, 201);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 75);
            this.Divide.TabIndex = 18;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.Color.DarkGray;
            this.Multiply.Location = new System.Drawing.Point(257, 201);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 75);
            this.Multiply.TabIndex = 15;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Exponent
            // 
            this.Exponent.BackColor = System.Drawing.Color.DarkGray;
            this.Exponent.Location = new System.Drawing.Point(95, 282);
            this.Exponent.Name = "Exponent";
            this.Exponent.Size = new System.Drawing.Size(75, 75);
            this.Exponent.TabIndex = 19;
            this.Exponent.Text = "xⁿ";
            this.Exponent.UseVisualStyleBackColor = false;
            this.Exponent.Click += new System.EventHandler(this.Exponent_Click);
            // 
            // Squareroot
            // 
            this.Squareroot.BackColor = System.Drawing.Color.DarkGray;
            this.Squareroot.Location = new System.Drawing.Point(176, 282);
            this.Squareroot.Name = "Squareroot";
            this.Squareroot.Size = new System.Drawing.Size(75, 75);
            this.Squareroot.TabIndex = 20;
            this.Squareroot.Text = "√";
            this.Squareroot.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(249, 66);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(184, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 92);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(542, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(537, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Select a Currency to Change";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "*From";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(540, 135);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(187, 96);
            this.richTextBox2.TabIndex = 27;
            this.richTextBox2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "To";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(542, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 21);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 493);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Squareroot);
            this.Controls.Add(this.Exponent);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.CloseP);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.openP);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearEntry);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Zero);
            this.Name = "Calculator";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ClearEntry;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button openP;
        private System.Windows.Forms.Button CloseP;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Exponent;
        private System.Windows.Forms.Button Squareroot;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}


namespace Calculator_App
{
    partial class MyCalculator
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
            this.OutputScreen = new System.Windows.Forms.TextBox();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.ChangeSign = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.MemorySave = new System.Windows.Forms.Button();
            this.MemoryMinus = new System.Windows.Forms.Button();
            this.MemoryPlus = new System.Windows.Forms.Button();
            this.MemoryRecall = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Pi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputScreen
            // 
            this.OutputScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputScreen.Location = new System.Drawing.Point(12, 12);
            this.OutputScreen.Name = "OutputScreen";
            this.OutputScreen.ReadOnly = true;
            this.OutputScreen.Size = new System.Drawing.Size(219, 31);
            this.OutputScreen.TabIndex = 0;
            this.OutputScreen.Text = "0";
            this.OutputScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(13, 131);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(47, 43);
            this.Seven.TabIndex = 1;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(66, 131);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(47, 43);
            this.Eight.TabIndex = 2;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(119, 131);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(47, 43);
            this.Nine.TabIndex = 3;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(13, 180);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(47, 43);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(66, 180);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(47, 43);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(119, 180);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(47, 43);
            this.Six.TabIndex = 6;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(13, 229);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(47, 43);
            this.One.TabIndex = 7;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(66, 229);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(47, 43);
            this.Two.TabIndex = 8;
            this.Two.Text = "2";
            this.Two.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(119, 229);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(47, 43);
            this.Three.TabIndex = 9;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(172, 131);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(59, 43);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(172, 180);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(59, 43);
            this.Plus.TabIndex = 11;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.Location = new System.Drawing.Point(172, 229);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(59, 43);
            this.Minus.TabIndex = 12;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(172, 278);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(59, 43);
            this.Multiply.TabIndex = 13;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(172, 327);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(59, 43);
            this.Divide.TabIndex = 14;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(66, 278);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(47, 43);
            this.Zero.TabIndex = 15;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // ChangeSign
            // 
            this.ChangeSign.Location = new System.Drawing.Point(13, 278);
            this.ChangeSign.Name = "ChangeSign";
            this.ChangeSign.Size = new System.Drawing.Size(47, 43);
            this.ChangeSign.TabIndex = 16;
            this.ChangeSign.Text = "+/-";
            this.ChangeSign.UseVisualStyleBackColor = true;
            this.ChangeSign.Click += new System.EventHandler(this.ChangeSign_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(13, 327);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(153, 43);
            this.Equal.TabIndex = 17;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // MemorySave
            // 
            this.MemorySave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemorySave.Location = new System.Drawing.Point(13, 90);
            this.MemorySave.Name = "MemorySave";
            this.MemorySave.Size = new System.Drawing.Size(47, 35);
            this.MemorySave.TabIndex = 18;
            this.MemorySave.Text = "MS";
            this.MemorySave.UseVisualStyleBackColor = true;
            this.MemorySave.Click += new System.EventHandler(this.MemorySave_Click);
            // 
            // MemoryMinus
            // 
            this.MemoryMinus.Location = new System.Drawing.Point(119, 90);
            this.MemoryMinus.Name = "MemoryMinus";
            this.MemoryMinus.Size = new System.Drawing.Size(47, 35);
            this.MemoryMinus.TabIndex = 19;
            this.MemoryMinus.Text = "M-";
            this.MemoryMinus.UseVisualStyleBackColor = true;
            this.MemoryMinus.Click += new System.EventHandler(this.MemoryMinus_Click);
            // 
            // MemoryPlus
            // 
            this.MemoryPlus.Location = new System.Drawing.Point(66, 90);
            this.MemoryPlus.Name = "MemoryPlus";
            this.MemoryPlus.Size = new System.Drawing.Size(47, 35);
            this.MemoryPlus.TabIndex = 20;
            this.MemoryPlus.Text = "M+";
            this.MemoryPlus.UseVisualStyleBackColor = true;
            this.MemoryPlus.Click += new System.EventHandler(this.MemoryPlus_Click);
            // 
            // MemoryRecall
            // 
            this.MemoryRecall.Location = new System.Drawing.Point(172, 89);
            this.MemoryRecall.Name = "MemoryRecall";
            this.MemoryRecall.Size = new System.Drawing.Size(59, 36);
            this.MemoryRecall.TabIndex = 21;
            this.MemoryRecall.Text = "MR";
            this.MemoryRecall.UseVisualStyleBackColor = true;
            this.MemoryRecall.Click += new System.EventHandler(this.MemoryRecall_Click);
            // 
            // Decimal
            // 
            this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal.Location = new System.Drawing.Point(119, 277);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(47, 43);
            this.Decimal.TabIndex = 22;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // Sin
            // 
            this.Sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sin.Location = new System.Drawing.Point(13, 49);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(47, 35);
            this.Sin.TabIndex = 23;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // Tan
            // 
            this.Tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tan.Location = new System.Drawing.Point(119, 49);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(47, 35);
            this.Tan.TabIndex = 24;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.Tan_Click);
            // 
            // Cos
            // 
            this.Cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cos.Location = new System.Drawing.Point(66, 49);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(47, 35);
            this.Cos.TabIndex = 25;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // Pi
            // 
            this.Pi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pi.Location = new System.Drawing.Point(172, 48);
            this.Pi.Name = "Pi";
            this.Pi.Size = new System.Drawing.Size(59, 36);
            this.Pi.TabIndex = 26;
            this.Pi.Text = "𝜋";
            this.Pi.UseVisualStyleBackColor = true;
            this.Pi.Click += new System.EventHandler(this.Pi_Click);
            // 
            // MyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 471);
            this.Controls.Add(this.Pi);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.MemoryRecall);
            this.Controls.Add(this.MemoryPlus);
            this.Controls.Add(this.MemoryMinus);
            this.Controls.Add(this.MemorySave);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.ChangeSign);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.OutputScreen);
            this.Name = "MyCalculator";
            this.Text = "MyCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputScreen;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button ChangeSign;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button MemorySave;
        private System.Windows.Forms.Button MemoryMinus;
        private System.Windows.Forms.Button MemoryPlus;
        private System.Windows.Forms.Button MemoryRecall;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Pi;
    }
}


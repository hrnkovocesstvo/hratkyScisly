namespace hratkyScisly
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonSuda = new System.Windows.Forms.Button();
            this.buttonLicha = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonSudakromeNuly = new System.Windows.Forms.Button();
            this.button3ne6 = new System.Windows.Forms.Button();
            this.button5ne10 = new System.Windows.Forms.Button();
            this.buttonNe4 = new System.Windows.Forms.Button();
            this.button3a5nebo8 = new System.Windows.Forms.Button();
            this.buttonCif8 = new System.Windows.Forms.Button();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.Location = new System.Drawing.Point(12, 241);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(776, 197);
            this.textBox.TabIndex = 0;
            // 
            // buttonSuda
            // 
            this.buttonSuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSuda.Location = new System.Drawing.Point(12, 39);
            this.buttonSuda.Name = "buttonSuda";
            this.buttonSuda.Size = new System.Drawing.Size(74, 48);
            this.buttonSuda.TabIndex = 1;
            this.buttonSuda.Text = "suda";
            this.buttonSuda.UseVisualStyleBackColor = true;
            // 
            // buttonLicha
            // 
            this.buttonLicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLicha.Location = new System.Drawing.Point(12, 103);
            this.buttonLicha.Name = "buttonLicha";
            this.buttonLicha.Size = new System.Drawing.Size(74, 48);
            this.buttonLicha.TabIndex = 2;
            this.buttonLicha.Text = "licha";
            this.buttonLicha.UseVisualStyleBackColor = true;
            this.buttonLicha.Click += new System.EventHandler(this.buttonLicha_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(92, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "delitelna 3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(92, 103);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 48);
            this.button6.TabIndex = 4;
            this.button6.Text = "delitelna 6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // buttonSudakromeNuly
            // 
            this.buttonSudakromeNuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSudakromeNuly.Location = new System.Drawing.Point(12, 171);
            this.buttonSudakromeNuly.Name = "buttonSudakromeNuly";
            this.buttonSudakromeNuly.Size = new System.Drawing.Size(168, 48);
            this.buttonSudakromeNuly.TabIndex = 5;
            this.buttonSudakromeNuly.Text = "suda kromě nuly";
            this.buttonSudakromeNuly.UseVisualStyleBackColor = true;
            // 
            // button3ne6
            // 
            this.button3ne6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3ne6.Location = new System.Drawing.Point(186, 171);
            this.button3ne6.Name = "button3ne6";
            this.button3ne6.Size = new System.Drawing.Size(161, 48);
            this.button3ne6.TabIndex = 6;
            this.button3ne6.Text = "delitelna 3 ne 6";
            this.button3ne6.UseVisualStyleBackColor = true;
            // 
            // button5ne10
            // 
            this.button5ne10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5ne10.Location = new System.Drawing.Point(353, 171);
            this.button5ne10.Name = "button5ne10";
            this.button5ne10.Size = new System.Drawing.Size(174, 48);
            this.button5ne10.TabIndex = 7;
            this.button5ne10.Text = "delitelna 5 ne 10";
            this.button5ne10.UseVisualStyleBackColor = true;
            // 
            // buttonNe4
            // 
            this.buttonNe4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNe4.Location = new System.Drawing.Point(392, 39);
            this.buttonNe4.Name = "buttonNe4";
            this.buttonNe4.Size = new System.Drawing.Size(153, 48);
            this.buttonNe4.TabIndex = 8;
            this.buttonNe4.Text = "delitelna ne 4";
            this.buttonNe4.UseVisualStyleBackColor = true;
            // 
            // button3a5nebo8
            // 
            this.button3a5nebo8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3a5nebo8.Location = new System.Drawing.Point(221, 103);
            this.button3a5nebo8.Name = "button3a5nebo8";
            this.button3a5nebo8.Size = new System.Drawing.Size(221, 48);
            this.button3a5nebo8.TabIndex = 9;
            this.button3a5nebo8.Text = "delitelna 3 a 5 nebo 8";
            this.button3a5nebo8.UseVisualStyleBackColor = true;
            // 
            // buttonCif8
            // 
            this.buttonCif8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCif8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCif8.Location = new System.Drawing.Point(221, 39);
            this.buttonCif8.Name = "buttonCif8";
            this.buttonCif8.Size = new System.Drawing.Size(165, 48);
            this.buttonCif8.TabIndex = 10;
            this.buttonCif8.Text = "ciferny soucet 8";
            this.buttonCif8.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownMax.Location = new System.Drawing.Point(609, 127);
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(153, 38);
            this.numericUpDownMax.TabIndex = 11;
            this.numericUpDownMax.ValueChanged += new System.EventHandler(this.numericUpDownMax_ValueChanged);
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownMin.Location = new System.Drawing.Point(609, 49);
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(153, 38);
            this.numericUpDownMin.TabIndex = 12;
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.numericUpDownMin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(603, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(603, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.buttonCif8);
            this.Controls.Add(this.button3a5nebo8);
            this.Controls.Add(this.buttonNe4);
            this.Controls.Add(this.button5ne10);
            this.Controls.Add(this.button3ne6);
            this.Controls.Add(this.buttonSudakromeNuly);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonLicha);
            this.Controls.Add(this.buttonSuda);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonSuda;
        private System.Windows.Forms.Button buttonLicha;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonSudakromeNuly;
        private System.Windows.Forms.Button button3ne6;
        private System.Windows.Forms.Button button5ne10;
        private System.Windows.Forms.Button buttonNe4;
        private System.Windows.Forms.Button button3a5nebo8;
        private System.Windows.Forms.Button buttonCif8;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


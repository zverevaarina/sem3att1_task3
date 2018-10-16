namespace att1_task3
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAnimalCount = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.textBoxReserve = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonPayTax = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxn = new System.Windows.Forms.TextBox();
            this.textBoxPayTax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Animal count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Square:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Reserve:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(32, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAnimalCount
            // 
            this.textBoxAnimalCount.Location = new System.Drawing.Point(149, 59);
            this.textBoxAnimalCount.Name = "textBoxAnimalCount";
            this.textBoxAnimalCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxAnimalCount.TabIndex = 1;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(271, 59);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(100, 22);
            this.textBoxBalance.TabIndex = 3;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(392, 59);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 22);
            this.textBoxCity.TabIndex = 6;
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.Location = new System.Drawing.Point(512, 59);
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.Size = new System.Drawing.Size(100, 22);
            this.textBoxSquare.TabIndex = 5;
            // 
            // textBoxReserve
            // 
            this.textBoxReserve.Location = new System.Drawing.Point(634, 59);
            this.textBoxReserve.Name = "textBoxReserve";
            this.textBoxReserve.Size = new System.Drawing.Size(100, 22);
            this.textBoxReserve.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Milk Farm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(149, 178);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(100, 53);
            this.buttonSell.TabIndex = 2;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonPayTax
            // 
            this.buttonPayTax.Location = new System.Drawing.Point(270, 178);
            this.buttonPayTax.Name = "buttonPayTax";
            this.buttonPayTax.Size = new System.Drawing.Size(100, 53);
            this.buttonPayTax.TabIndex = 2;
            this.buttonPayTax.Text = "Pay Tax";
            this.buttonPayTax.UseVisualStyleBackColor = true;
            this.buttonPayTax.Click += new System.EventHandler(this.buttonPayTax_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Name";
            // 
            // textBoxn
            // 
            this.textBoxn.Location = new System.Drawing.Point(149, 258);
            this.textBoxn.Name = "textBoxn";
            this.textBoxn.Size = new System.Drawing.Size(100, 22);
            this.textBoxn.TabIndex = 11;
            // 
            // textBoxPayTax
            // 
            this.textBoxPayTax.Location = new System.Drawing.Point(270, 258);
            this.textBoxPayTax.Name = "textBoxPayTax";
            this.textBoxPayTax.Size = new System.Drawing.Size(100, 22);
            this.textBoxPayTax.TabIndex = 12;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 458);
            this.Controls.Add(this.textBoxPayTax);
            this.Controls.Add(this.textBoxn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonPayTax);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxReserve);
            this.Controls.Add(this.textBoxSquare);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.textBoxAnimalCount);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAnimalCount;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.TextBox textBoxReserve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonPayTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxn;
        private System.Windows.Forms.TextBox textBoxPayTax;
    }
}


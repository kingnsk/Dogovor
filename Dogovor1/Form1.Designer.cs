namespace Dogovor1
{
    partial class Form1
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
            this.button_ok = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.Dog_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dog_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Dog_gorod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdavecBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PokupatelBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.templateBox = new System.Windows.Forms.ComboBox();
            this.checkBoxKR = new System.Windows.Forms.CheckBox();
            this.textBoxSumm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSummpropis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(12, 256);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(399, 256);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Dog_number
            // 
            this.Dog_number.Location = new System.Drawing.Point(105, 51);
            this.Dog_number.Name = "Dog_number";
            this.Dog_number.Size = new System.Drawing.Size(145, 20);
            this.Dog_number.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер Договора:";
            // 
            // Dog_date
            // 
            this.Dog_date.Location = new System.Drawing.Point(321, 50);
            this.Dog_date.Name = "Dog_date";
            this.Dog_date.Size = new System.Drawing.Size(151, 20);
            this.Dog_date.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата:";
            // 
            // Dog_gorod
            // 
            this.Dog_gorod.Location = new System.Drawing.Point(45, 78);
            this.Dog_gorod.Name = "Dog_gorod";
            this.Dog_gorod.Size = new System.Drawing.Size(222, 20);
            this.Dog_gorod.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Город";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ProdavecBox
            // 
            this.ProdavecBox.FormattingEnabled = true;
            this.ProdavecBox.Location = new System.Drawing.Point(5, 118);
            this.ProdavecBox.Name = "ProdavecBox";
            this.ProdavecBox.Size = new System.Drawing.Size(467, 21);
            this.ProdavecBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Продавец:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Покупатель:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PokupatelBox
            // 
            this.PokupatelBox.FormattingEnabled = true;
            this.PokupatelBox.Location = new System.Drawing.Point(5, 158);
            this.PokupatelBox.Name = "PokupatelBox";
            this.PokupatelBox.Size = new System.Drawing.Size(467, 21);
            this.PokupatelBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Шаблон договора:";
            // 
            // templateBox
            // 
            this.templateBox.FormattingEnabled = true;
            this.templateBox.Location = new System.Drawing.Point(5, 23);
            this.templateBox.Name = "templateBox";
            this.templateBox.Size = new System.Drawing.Size(467, 21);
            this.templateBox.TabIndex = 12;
            // 
            // checkBoxKR
            // 
            this.checkBoxKR.AutoSize = true;
            this.checkBoxKR.Location = new System.Drawing.Point(273, 83);
            this.checkBoxKR.Name = "checkBoxKR";
            this.checkBoxKR.Size = new System.Drawing.Size(40, 17);
            this.checkBoxKR.TabIndex = 15;
            this.checkBoxKR.Text = "КР";
            this.checkBoxKR.UseVisualStyleBackColor = true;
            this.checkBoxKR.CheckStateChanged += new System.EventHandler(this.chekboxKRchanged);
            // 
            // textBoxSumm
            // 
            this.textBoxSumm.Location = new System.Drawing.Point(105, 185);
            this.textBoxSumm.Name = "textBoxSumm";
            this.textBoxSumm.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumm.TabIndex = 16;
            this.textBoxSumm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Сумма:";
            // 
            // textBoxSummpropis
            // 
            this.textBoxSummpropis.Location = new System.Drawing.Point(105, 211);
            this.textBoxSummpropis.Multiline = true;
            this.textBoxSummpropis.Name = "textBoxSummpropis";
            this.textBoxSummpropis.Size = new System.Drawing.Size(367, 40);
            this.textBoxSummpropis.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Сумма Прописью:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 291);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSummpropis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSumm);
            this.Controls.Add(this.checkBoxKR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.templateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PokupatelBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProdavecBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dog_gorod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dog_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dog_number);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_ok);
            this.Name = "Form1";
            this.Text = "Dogovor v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox Dog_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dog_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dog_gorod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProdavecBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PokupatelBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox templateBox;
        private System.Windows.Forms.CheckBox checkBoxKR;
        private System.Windows.Forms.TextBox textBoxSumm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSummpropis;
        private System.Windows.Forms.Label label8;
    }
}


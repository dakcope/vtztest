namespace WinFormsApp3
{
    partial class ContractAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractAdd));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.comboBoxDisc = new System.Windows.Forms.ComboBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.dataGridViewCatal = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUpConf = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.comboBoxCont = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonConfirm);
            this.groupBox2.Controls.Add(this.comboBoxDisc);
            this.groupBox2.Controls.Add(this.textBoxTotal);
            this.groupBox2.Controls.Add(this.dataGridViewCatal);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxCount);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 260);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Условия";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Enabled = false;
            this.buttonConfirm.Location = new System.Drawing.Point(457, 219);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(139, 35);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Заключить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // comboBoxDisc
            // 
            this.comboBoxDisc.FormattingEnabled = true;
            this.comboBoxDisc.Items.AddRange(new object[] {
            "0",
            "1",
            "5",
            "10"});
            this.comboBoxDisc.Location = new System.Drawing.Point(457, 69);
            this.comboBoxDisc.Name = "comboBoxDisc";
            this.comboBoxDisc.Size = new System.Drawing.Size(100, 23);
            this.comboBoxDisc.TabIndex = 7;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(342, 129);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotal.TabIndex = 6;
            // 
            // dataGridViewCatal
            // 
            this.dataGridViewCatal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatal.Location = new System.Drawing.Point(6, 108);
            this.dataGridViewCatal.Name = "dataGridViewCatal";
            this.dataGridViewCatal.RowTemplate.Height = 25;
            this.dataGridViewCatal.Size = new System.Drawing.Size(290, 146);
            this.dataGridViewCatal.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(489, 108);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(26, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите предмет сделки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Скидка на товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "В количестве";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(242, 69);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(200, 23);
            this.textBoxCount.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUpConf);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxSerial);
            this.groupBox1.Controls.Add(this.comboBoxCont);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шапка документа";
            // 
            // buttonUpConf
            // 
            this.buttonUpConf.Location = new System.Drawing.Point(242, 124);
            this.buttonUpConf.Name = "buttonUpConf";
            this.buttonUpConf.Size = new System.Drawing.Size(147, 23);
            this.buttonUpConf.TabIndex = 4;
            this.buttonUpConf.Text = "Подтвердить";
            this.buttonUpConf.UseVisualStyleBackColor = true;
            this.buttonUpConf.Click += new System.EventHandler(this.buttonUpConf_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Контрагент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата заключения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Номер документа";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Location = new System.Drawing.Point(406, 20);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(200, 23);
            this.textBoxSerial.TabIndex = 2;
            // 
            // comboBoxCont
            // 
            this.comboBoxCont.FormattingEnabled = true;
            this.comboBoxCont.Location = new System.Drawing.Point(406, 61);
            this.comboBoxCont.Name = "comboBoxCont";
            this.comboBoxCont.Size = new System.Drawing.Size(200, 23);
            this.comboBoxCont.TabIndex = 0;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(27, 61);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 23);
            this.dateTime.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Общая цена с учетом скидки";
            // 
            // ContractAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 476);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContractAdd";
            this.Text = "Создание контракта";
            this.Load += new System.EventHandler(this.ContractAdd_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private Label label10;
        private Label label1;
        private Label label9;
        private TextBox textBoxSerial;
        private ComboBox comboBoxCont;
        private DateTimePicker dateTime;
        private Button buttonUpConf;
        private ComboBox comboBoxDisc;
        private TextBox textBoxTotal;
        private DataGridView dataGridViewCatal;
        private Button buttonAdd;
        private Label label2;
        private Label label3;
        private TextBox textBoxCount;
        private Button buttonConfirm;
        private Label label4;
        private Label label5;
    }
}
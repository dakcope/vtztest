namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxBuyer = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonContEdit = new System.Windows.Forms.Button();
            this.buttonContractAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxContract = new System.Windows.Forms.ComboBox();
            this.dataGridViewContr = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonProductAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productBoxCost = new System.Windows.Forms.TextBox();
            this.productBoxName = new System.Windows.Forms.TextBox();
            this.productBoxAmount = new System.Windows.Forms.TextBox();
            this.productBoxAmountRes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContr)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxTotal);
            this.tabPage3.Controls.Add(this.textBoxBuyer);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.comboBoxContract);
            this.tabPage3.Controls.Add(this.dataGridViewContr);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(890, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Контракты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(515, 72);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(118, 23);
            this.textBoxTotal.TabIndex = 5;
            // 
            // textBoxBuyer
            // 
            this.textBoxBuyer.Location = new System.Drawing.Point(477, 32);
            this.textBoxBuyer.Name = "textBoxBuyer";
            this.textBoxBuyer.Size = new System.Drawing.Size(156, 23);
            this.textBoxBuyer.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonContEdit);
            this.groupBox3.Controls.Add(this.buttonContractAdd);
            this.groupBox3.Location = new System.Drawing.Point(653, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 537);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Действия с контрактами";
            // 
            // buttonContEdit
            // 
            this.buttonContEdit.Location = new System.Drawing.Point(31, 99);
            this.buttonContEdit.Name = "buttonContEdit";
            this.buttonContEdit.Size = new System.Drawing.Size(151, 40);
            this.buttonContEdit.TabIndex = 2;
            this.buttonContEdit.Text = "Изменить котракт";
            this.buttonContEdit.UseVisualStyleBackColor = true;
            this.buttonContEdit.Click += new System.EventHandler(this.buttonContEdit_Click);
            // 
            // buttonContractAdd
            // 
            this.buttonContractAdd.Location = new System.Drawing.Point(31, 41);
            this.buttonContractAdd.Name = "buttonContractAdd";
            this.buttonContractAdd.Size = new System.Drawing.Size(151, 40);
            this.buttonContractAdd.TabIndex = 1;
            this.buttonContractAdd.Text = "Создать контракт";
            this.buttonContractAdd.UseVisualStyleBackColor = true;
            this.buttonContractAdd.Click += new System.EventHandler(this.buttonContractAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Контрагент";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(402, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Общая стоимость";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(466, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Выберите контракт";
            // 
            // comboBoxContract
            // 
            this.comboBoxContract.FormattingEnabled = true;
            this.comboBoxContract.Location = new System.Drawing.Point(411, 139);
            this.comboBoxContract.Name = "comboBoxContract";
            this.comboBoxContract.Size = new System.Drawing.Size(208, 23);
            this.comboBoxContract.TabIndex = 2;
            this.comboBoxContract.SelectionChangeCommitted += new System.EventHandler(this.comboBoxContract_SelectionChangeCommitted);
            // 
            // dataGridViewContr
            // 
            this.dataGridViewContr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContr.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewContr.Name = "dataGridViewContr";
            this.dataGridViewContr.RowTemplate.Height = 25;
            this.dataGridViewContr.Size = new System.Drawing.Size(384, 561);
            this.dataGridViewContr.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 592);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buttonProductAdd);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonChange);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.productBoxCost);
            this.tabPage1.Controls.Add(this.productBoxName);
            this.tabPage1.Controls.Add(this.productBoxAmount);
            this.tabPage1.Controls.Add(this.productBoxAmountRes);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Зарезервировано";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Наличие";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Цена";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Наименование";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonProductAdd
            // 
            this.buttonProductAdd.Location = new System.Drawing.Point(555, 408);
            this.buttonProductAdd.Name = "buttonProductAdd";
            this.buttonProductAdd.Size = new System.Drawing.Size(296, 48);
            this.buttonProductAdd.TabIndex = 6;
            this.buttonProductAdd.Text = "Добавить новый продукт";
            this.buttonProductAdd.UseVisualStyleBackColor = true;
            this.buttonProductAdd.Click += new System.EventHandler(this.buttonProductAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(373, 483);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(198, 46);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить изменения/обновить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(555, 349);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 37);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(712, 349);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(134, 37);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(890, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // productBoxCost
            // 
            this.productBoxCost.Location = new System.Drawing.Point(129, 391);
            this.productBoxCost.Name = "productBoxCost";
            this.productBoxCost.Size = new System.Drawing.Size(192, 23);
            this.productBoxCost.TabIndex = 1;
            // 
            // productBoxName
            // 
            this.productBoxName.Location = new System.Drawing.Point(129, 349);
            this.productBoxName.Name = "productBoxName";
            this.productBoxName.Size = new System.Drawing.Size(192, 23);
            this.productBoxName.TabIndex = 1;
            // 
            // productBoxAmount
            // 
            this.productBoxAmount.Location = new System.Drawing.Point(129, 433);
            this.productBoxAmount.Name = "productBoxAmount";
            this.productBoxAmount.Size = new System.Drawing.Size(192, 23);
            this.productBoxAmount.TabIndex = 1;
            // 
            // productBoxAmountRes
            // 
            this.productBoxAmountRes.Location = new System.Drawing.Point(129, 475);
            this.productBoxAmountRes.Name = "productBoxAmountRes";
            this.productBoxAmountRes.ReadOnly = true;
            this.productBoxAmountRes.Size = new System.Drawing.Size(192, 23);
            this.productBoxAmountRes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 616);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Приложение v1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContr)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabPage3;
        private DataGridView dataGridViewContr;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button buttonProductAdd;
        private Button buttonSave;
        private Button buttonDelete;
        private Button buttonChange;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private TextBox productBoxCost;
        private TextBox productBoxName;
        private TextBox productBoxAmount;
        private TextBox productBoxAmountRes;
        private Label label2;
        private Label label1;
        private Button buttonContractAdd;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxContract;
        private TextBox textBoxTotal;
        private TextBox textBoxBuyer;
        private GroupBox groupBox3;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button buttonContEdit;
    }
}
namespace zkh
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDweller = new System.Windows.Forms.Button();
            this.dataGridViewHouse = new System.Windows.Forms.DataGridView();
            this.dataGridViewFlat = new System.Windows.Forms.DataGridView();
            this.dataGridViewDweller = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonHouse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFlat = new System.Windows.Forms.Button();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDweller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.57678F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.58646F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.71584F));
            this.tableLayoutPanel1.Controls.Add(this.buttonDweller, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewHouse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewFlat, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewDweller, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonHouse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonFlat, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxInfo, 2, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.46348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.096687F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.29186F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.147974F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 514);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonDweller
            // 
            this.buttonDweller.BackColor = System.Drawing.Color.Chocolate;
            this.buttonDweller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDweller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDweller.Location = new System.Drawing.Point(413, 477);
            this.buttonDweller.Name = "buttonDweller";
            this.buttonDweller.Size = new System.Drawing.Size(159, 28);
            this.buttonDweller.TabIndex = 9;
            this.buttonDweller.Text = "Добавить жильца";
            this.buttonDweller.UseVisualStyleBackColor = false;
            this.buttonDweller.Click += new System.EventHandler(this.buttonDweller_Click);
            // 
            // dataGridViewHouse
            // 
            this.dataGridViewHouse.AllowUserToAddRows = false;
            this.dataGridViewHouse.AllowUserToDeleteRows = false;
            this.dataGridViewHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewHouse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewHouse, 3);
            this.dataGridViewHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHouse.GridColor = System.Drawing.Color.Sienna;
            this.dataGridViewHouse.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewHouse.Name = "dataGridViewHouse";
            this.dataGridViewHouse.ReadOnly = true;
            this.dataGridViewHouse.RowHeadersVisible = false;
            this.dataGridViewHouse.Size = new System.Drawing.Size(821, 202);
            this.dataGridViewHouse.TabIndex = 1;
            this.dataGridViewHouse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHouse_CellContentClick);
            // 
            // dataGridViewFlat
            // 
            this.dataGridViewFlat.AllowUserToAddRows = false;
            this.dataGridViewFlat.AllowUserToDeleteRows = false;
            this.dataGridViewFlat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFlat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewFlat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewFlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFlat.GridColor = System.Drawing.Color.Sienna;
            this.dataGridViewFlat.Location = new System.Drawing.Point(3, 274);
            this.dataGridViewFlat.Name = "dataGridViewFlat";
            this.dataGridViewFlat.ReadOnly = true;
            this.dataGridViewFlat.RowHeadersVisible = false;
            this.dataGridViewFlat.Size = new System.Drawing.Size(404, 197);
            this.dataGridViewFlat.TabIndex = 2;
            this.dataGridViewFlat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFlat_CellContentClick);
            // 
            // dataGridViewDweller
            // 
            this.dataGridViewDweller.AllowUserToAddRows = false;
            this.dataGridViewDweller.AllowUserToDeleteRows = false;
            this.dataGridViewDweller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDweller.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDweller.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridViewDweller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewDweller, 2);
            this.dataGridViewDweller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDweller.GridColor = System.Drawing.Color.Sienna;
            this.dataGridViewDweller.Location = new System.Drawing.Point(413, 274);
            this.dataGridViewDweller.Name = "dataGridViewDweller";
            this.dataGridViewDweller.ReadOnly = true;
            this.dataGridViewDweller.RowHeadersVisible = false;
            this.dataGridViewDweller.Size = new System.Drawing.Size(411, 197);
            this.dataGridViewDweller.TabIndex = 3;
            this.dataGridViewDweller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDweller_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(269, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список домов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(413, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список жильцов";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonHouse
            // 
            this.buttonHouse.BackColor = System.Drawing.Color.Chocolate;
            this.buttonHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHouse.Location = new System.Drawing.Point(413, 3);
            this.buttonHouse.Name = "buttonHouse";
            this.buttonHouse.Size = new System.Drawing.Size(159, 28);
            this.buttonHouse.TabIndex = 7;
            this.buttonHouse.Text = "Добавить дом";
            this.buttonHouse.UseVisualStyleBackColor = false;
            this.buttonHouse.Click += new System.EventHandler(this.buttonHouse_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список квартир";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonFlat
            // 
            this.buttonFlat.BackColor = System.Drawing.Color.Chocolate;
            this.buttonFlat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFlat.Location = new System.Drawing.Point(3, 477);
            this.buttonFlat.Name = "buttonFlat";
            this.buttonFlat.Size = new System.Drawing.Size(159, 28);
            this.buttonFlat.TabIndex = 8;
            this.buttonFlat.Text = "Добавить квартиру";
            this.buttonFlat.UseVisualStyleBackColor = false;
            this.buttonFlat.Click += new System.EventHandler(this.buttonFlat_Click);
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Image = global::zkh.Properties.Resources.w256h2561387214968Help;
            this.pictureBoxInfo.Location = new System.Drawing.Point(790, 3);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(34, 28);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfo.TabIndex = 10;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.pictureBoxInfo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Главная";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDweller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewHouse;
        private System.Windows.Forms.DataGridView dataGridViewFlat;
        private System.Windows.Forms.DataGridView dataGridViewDweller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDweller;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHouse;
        private System.Windows.Forms.Button buttonFlat;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
    }
}


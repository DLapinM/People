namespace People
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_add_man = new System.Windows.Forms.Button();
            this.button_assign_changing_for_man_row = new System.Windows.Forms.Button();
            this.button_show_men_data = new System.Windows.Forms.Button();
            this.dataGridView_men_data = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_add_woman = new System.Windows.Forms.Button();
            this.button_assign_changing_for_woman_row = new System.Windows.Forms.Button();
            this.button_show_women_data = new System.Windows.Forms.Button();
            this.dataGridView_women_data = new System.Windows.Forms.DataGridView();
            this.button_connect_db = new System.Windows.Forms.Button();
            this.button_disconnect_db = new System.Windows.Forms.Button();
            this.button_delete_man_row = new System.Windows.Forms.Button();
            this.button_delete_woman_row = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_men_data)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_women_data)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1124, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_delete_man_row);
            this.tabPage1.Controls.Add(this.button_add_man);
            this.tabPage1.Controls.Add(this.button_assign_changing_for_man_row);
            this.tabPage1.Controls.Add(this.button_show_men_data);
            this.tabPage1.Controls.Add(this.dataGridView_men_data);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1116, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные мужчин";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_add_man
            // 
            this.button_add_man.Location = new System.Drawing.Point(867, 484);
            this.button_add_man.Name = "button_add_man";
            this.button_add_man.Size = new System.Drawing.Size(143, 23);
            this.button_add_man.TabIndex = 3;
            this.button_add_man.Text = "Добавить мужчину";
            this.button_add_man.UseVisualStyleBackColor = true;
            this.button_add_man.Click += new System.EventHandler(this.button_add_man_Click);
            // 
            // button_assign_changing_for_man_row
            // 
            this.button_assign_changing_for_man_row.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_assign_changing_for_man_row.Location = new System.Drawing.Point(88, 484);
            this.button_assign_changing_for_man_row.Name = "button_assign_changing_for_man_row";
            this.button_assign_changing_for_man_row.Size = new System.Drawing.Size(243, 23);
            this.button_assign_changing_for_man_row.TabIndex = 2;
            this.button_assign_changing_for_man_row.Text = "Принять изменения для текущей строки";
            this.button_assign_changing_for_man_row.UseVisualStyleBackColor = true;
            this.button_assign_changing_for_man_row.Click += new System.EventHandler(this.button_assign_changing_for_man_row_Click);
            // 
            // button_show_men_data
            // 
            this.button_show_men_data.Location = new System.Drawing.Point(648, 484);
            this.button_show_men_data.Name = "button_show_men_data";
            this.button_show_men_data.Size = new System.Drawing.Size(190, 23);
            this.button_show_men_data.TabIndex = 1;
            this.button_show_men_data.Text = "Отобразить данные о мужчинах";
            this.button_show_men_data.UseVisualStyleBackColor = true;
            this.button_show_men_data.Click += new System.EventHandler(this.button_show_men_data_Click);
            // 
            // dataGridView_men_data
            // 
            this.dataGridView_men_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_men_data.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_men_data.Name = "dataGridView_men_data";
            this.dataGridView_men_data.Size = new System.Drawing.Size(1104, 462);
            this.dataGridView_men_data.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_delete_woman_row);
            this.tabPage2.Controls.Add(this.button_add_woman);
            this.tabPage2.Controls.Add(this.button_assign_changing_for_woman_row);
            this.tabPage2.Controls.Add(this.button_show_women_data);
            this.tabPage2.Controls.Add(this.dataGridView_women_data);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1116, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Данные женщин";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_add_woman
            // 
            this.button_add_woman.Location = new System.Drawing.Point(877, 484);
            this.button_add_woman.Name = "button_add_woman";
            this.button_add_woman.Size = new System.Drawing.Size(170, 23);
            this.button_add_woman.TabIndex = 3;
            this.button_add_woman.Text = "Добавить женщину";
            this.button_add_woman.UseVisualStyleBackColor = true;
            this.button_add_woman.Click += new System.EventHandler(this.button_add_woman_Click);
            // 
            // button_assign_changing_for_woman_row
            // 
            this.button_assign_changing_for_woman_row.Location = new System.Drawing.Point(88, 484);
            this.button_assign_changing_for_woman_row.Name = "button_assign_changing_for_woman_row";
            this.button_assign_changing_for_woman_row.Size = new System.Drawing.Size(243, 23);
            this.button_assign_changing_for_woman_row.TabIndex = 2;
            this.button_assign_changing_for_woman_row.Text = "Принять изменения для текущей строки";
            this.button_assign_changing_for_woman_row.UseVisualStyleBackColor = true;
            this.button_assign_changing_for_woman_row.Click += new System.EventHandler(this.button_assign_changing_for_woman_Click);
            // 
            // button_show_women_data
            // 
            this.button_show_women_data.Location = new System.Drawing.Point(660, 484);
            this.button_show_women_data.Name = "button_show_women_data";
            this.button_show_women_data.Size = new System.Drawing.Size(195, 23);
            this.button_show_women_data.TabIndex = 1;
            this.button_show_women_data.Text = "Отобразить данные о женщинах";
            this.button_show_women_data.UseVisualStyleBackColor = true;
            this.button_show_women_data.Click += new System.EventHandler(this.button_show_women_data_Click);
            // 
            // dataGridView_women_data
            // 
            this.dataGridView_women_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_women_data.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_women_data.Name = "dataGridView_women_data";
            this.dataGridView_women_data.Size = new System.Drawing.Size(1104, 462);
            this.dataGridView_women_data.TabIndex = 0;
            // 
            // button_connect_db
            // 
            this.button_connect_db.Location = new System.Drawing.Point(28, 564);
            this.button_connect_db.Name = "button_connect_db";
            this.button_connect_db.Size = new System.Drawing.Size(183, 25);
            this.button_connect_db.TabIndex = 1;
            this.button_connect_db.Text = "Подключиться к базе данных...";
            this.button_connect_db.UseVisualStyleBackColor = true;
            this.button_connect_db.Click += new System.EventHandler(this.button_connect_db_Click);
            // 
            // button_disconnect_db
            // 
            this.button_disconnect_db.Location = new System.Drawing.Point(28, 604);
            this.button_disconnect_db.Name = "button_disconnect_db";
            this.button_disconnect_db.Size = new System.Drawing.Size(183, 23);
            this.button_disconnect_db.TabIndex = 2;
            this.button_disconnect_db.Text = "Отключиться от базы данных";
            this.button_disconnect_db.UseVisualStyleBackColor = true;
            this.button_disconnect_db.Click += new System.EventHandler(this.button_disconnect_db_Click);
            // 
            // button_delete_man_row
            // 
            this.button_delete_man_row.Location = new System.Drawing.Point(388, 484);
            this.button_delete_man_row.Name = "button_delete_man_row";
            this.button_delete_man_row.Size = new System.Drawing.Size(209, 23);
            this.button_delete_man_row.TabIndex = 4;
            this.button_delete_man_row.Text = "Удалить текущую строку";
            this.button_delete_man_row.UseVisualStyleBackColor = true;
            this.button_delete_man_row.Click += new System.EventHandler(this.button_delete_man_row_Click);
            // 
            // button_delete_woman_row
            // 
            this.button_delete_woman_row.Location = new System.Drawing.Point(398, 484);
            this.button_delete_woman_row.Name = "button_delete_woman_row";
            this.button_delete_woman_row.Size = new System.Drawing.Size(202, 23);
            this.button_delete_woman_row.TabIndex = 4;
            this.button_delete_woman_row.Text = "Удалить текущую строку";
            this.button_delete_woman_row.UseVisualStyleBackColor = true;
            this.button_delete_woman_row.Click += new System.EventHandler(this.button_delete_woman_row_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 643);
            this.Controls.Add(this.button_disconnect_db);
            this.Controls.Add(this.button_connect_db);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Информация о людях";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_men_data)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_women_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_connect_db;
        private System.Windows.Forms.Button button_disconnect_db;
        private System.Windows.Forms.Button button_show_men_data;
        private System.Windows.Forms.DataGridView dataGridView_men_data;
        private System.Windows.Forms.Button button_show_women_data;
        private System.Windows.Forms.DataGridView dataGridView_women_data;
        private System.Windows.Forms.Button button_assign_changing_for_man_row;
        private System.Windows.Forms.Button button_assign_changing_for_woman_row;
        private System.Windows.Forms.Button button_add_man;
        private System.Windows.Forms.Button button_add_woman;
        private System.Windows.Forms.Button button_delete_man_row;
        private System.Windows.Forms.Button button_delete_woman_row;
    }
}


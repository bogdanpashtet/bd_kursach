
namespace RZ
{
    partial class St_Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.new_staff_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.analyst_radioButton = new System.Windows.Forms.RadioButton();
            this.admin_radioButton = new System.Windows.Forms.RadioButton();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.new_login_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.fio_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.on_main_page_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.delete_button = new System.Windows.Forms.Button();
            this.delete_id_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.login_label);
            this.panel1.Location = new System.Drawing.Point(685, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 48);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вы вошли как:";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(211, 9);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(53, 25);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "login";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.new_staff_button);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.password_textBox);
            this.panel2.Controls.Add(this.login_textBox);
            this.panel2.Controls.Add(this.email_textBox);
            this.panel2.Controls.Add(this.fio_textBox);
            this.panel2.Controls.Add(this.password_label);
            this.panel2.Controls.Add(this.new_login_label);
            this.panel2.Controls.Add(this.email_label);
            this.panel2.Controls.Add(this.fio_label);
            this.panel2.Location = new System.Drawing.Point(13, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 371);
            this.panel2.TabIndex = 5;
            // 
            // new_staff_button
            // 
            this.new_staff_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_staff_button.Location = new System.Drawing.Point(148, 276);
            this.new_staff_button.Name = "new_staff_button";
            this.new_staff_button.Size = new System.Drawing.Size(234, 52);
            this.new_staff_button.TabIndex = 11;
            this.new_staff_button.Text = "Добавить";
            this.new_staff_button.UseVisualStyleBackColor = true;
            this.new_staff_button.Click += new System.EventHandler(this.new_stuff_button_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.analyst_radioButton);
            this.panel3.Controls.Add(this.admin_radioButton);
            this.panel3.Location = new System.Drawing.Point(103, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 85);
            this.panel3.TabIndex = 10;
            // 
            // analyst_radioButton
            // 
            this.analyst_radioButton.AutoSize = true;
            this.analyst_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analyst_radioButton.Location = new System.Drawing.Point(79, 47);
            this.analyst_radioButton.Name = "analyst_radioButton";
            this.analyst_radioButton.Size = new System.Drawing.Size(123, 29);
            this.analyst_radioButton.TabIndex = 1;
            this.analyst_radioButton.TabStop = true;
            this.analyst_radioButton.Text = "Аналитик";
            this.analyst_radioButton.UseVisualStyleBackColor = true;
            // 
            // admin_radioButton
            // 
            this.admin_radioButton.AutoSize = true;
            this.admin_radioButton.Checked = true;
            this.admin_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admin_radioButton.Location = new System.Drawing.Point(79, 12);
            this.admin_radioButton.Name = "admin_radioButton";
            this.admin_radioButton.Size = new System.Drawing.Size(185, 29);
            this.admin_radioButton.TabIndex = 0;
            this.admin_radioButton.TabStop = true;
            this.admin_radioButton.Text = "Администратор";
            this.admin_radioButton.UseVisualStyleBackColor = true;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textBox.Location = new System.Drawing.Point(133, 118);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(387, 30);
            this.password_textBox.TabIndex = 9;
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox.Location = new System.Drawing.Point(133, 81);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(387, 30);
            this.login_textBox.TabIndex = 8;
            // 
            // email_textBox
            // 
            this.email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_textBox.Location = new System.Drawing.Point(133, 46);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(387, 30);
            this.email_textBox.TabIndex = 7;
            // 
            // fio_textBox
            // 
            this.fio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_textBox.Location = new System.Drawing.Point(133, 10);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(387, 30);
            this.fio_textBox.TabIndex = 6;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(3, 121);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(80, 25);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Пароль";
            // 
            // new_login_label
            // 
            this.new_login_label.AutoSize = true;
            this.new_login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_login_label.Location = new System.Drawing.Point(3, 84);
            this.new_login_label.Name = "new_login_label";
            this.new_login_label.Size = new System.Drawing.Size(68, 25);
            this.new_login_label.TabIndex = 4;
            this.new_login_label.Text = "Логин";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_label.Location = new System.Drawing.Point(3, 49);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(58, 25);
            this.email_label.TabIndex = 3;
            this.email_label.Text = "email";
            // 
            // fio_label
            // 
            this.fio_label.AutoSize = true;
            this.fio_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_label.Location = new System.Drawing.Point(3, 13);
            this.fio_label.Name = "fio_label";
            this.fio_label.Size = new System.Drawing.Size(60, 25);
            this.fio_label.TabIndex = 2;
            this.fio_label.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Добавить сотрудника";
            // 
            // on_main_page_button
            // 
            this.on_main_page_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.on_main_page_button.Location = new System.Drawing.Point(806, 711);
            this.on_main_page_button.Name = "on_main_page_button";
            this.on_main_page_button.Size = new System.Drawing.Size(234, 52);
            this.on_main_page_button.TabIndex = 12;
            this.on_main_page_button.Text = "На главную";
            this.on_main_page_button.UseVisualStyleBackColor = true;
            this.on_main_page_button.Click += new System.EventHandler(this.on_main_page_button_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.delete_button);
            this.panel4.Controls.Add(this.delete_id_textBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(651, 291);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 371);
            this.panel4.TabIndex = 13;
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(103, 59);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(234, 52);
            this.delete_button.TabIndex = 15;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_stuff_button_Click);
            // 
            // delete_id_textBox
            // 
            this.delete_id_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_id_textBox.Location = new System.Drawing.Point(85, 10);
            this.delete_id_textBox.Name = "delete_id_textBox";
            this.delete_id_textBox.Size = new System.Drawing.Size(277, 30);
            this.delete_id_textBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(646, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Удалить сотрудника";
            // 
            // St_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 775);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.on_main_page_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "St_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет старшего администратора";
            this.Load += new System.EventHandler(this.St_Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton analyst_radioButton;
        private System.Windows.Forms.RadioButton admin_radioButton;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox fio_textBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label new_login_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label fio_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button new_staff_button;
        private System.Windows.Forms.Button on_main_page_button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox delete_id_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
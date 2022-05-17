
namespace RZ
{
    partial class RegistrationForm
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
            this.registration_button = new System.Windows.Forms.Button();
            this.client_radioButton = new System.Windows.Forms.RadioButton();
            this.seller_radioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.fio_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.mail_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.phone_number_textBox = new System.Windows.Forms.TextBox();
            this.phone_number_label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.card_number_textBox = new System.Windows.Forms.TextBox();
            this.card_number_label = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.on_main_page_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // registration_button
            // 
            this.registration_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration_button.Location = new System.Drawing.Point(171, 494);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(258, 81);
            this.registration_button.TabIndex = 0;
            this.registration_button.Text = "Зарегистрироваться";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // client_radioButton
            // 
            this.client_radioButton.AutoSize = true;
            this.client_radioButton.Checked = true;
            this.client_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client_radioButton.Location = new System.Drawing.Point(14, 14);
            this.client_radioButton.Name = "client_radioButton";
            this.client_radioButton.Size = new System.Drawing.Size(143, 29);
            this.client_radioButton.TabIndex = 1;
            this.client_radioButton.TabStop = true;
            this.client_radioButton.Text = "Покупатель";
            this.client_radioButton.UseVisualStyleBackColor = true;
            // 
            // seller_radioButton
            // 
            this.seller_radioButton.AutoSize = true;
            this.seller_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seller_radioButton.Location = new System.Drawing.Point(14, 49);
            this.seller_radioButton.Name = "seller_radioButton";
            this.seller_radioButton.Size = new System.Drawing.Size(124, 29);
            this.seller_radioButton.TabIndex = 2;
            this.seller_radioButton.TabStop = true;
            this.seller_radioButton.Text = "Продавец";
            this.seller_radioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.seller_radioButton);
            this.panel1.Controls.Add(this.client_radioButton);
            this.panel1.Location = new System.Drawing.Point(386, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 89);
            this.panel1.TabIndex = 3;
            // 
            // fio_textBox
            // 
            this.fio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_textBox.Location = new System.Drawing.Point(204, 6);
            this.fio_textBox.Multiline = true;
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(713, 38);
            this.fio_textBox.TabIndex = 4;
            // 
            // fio_label
            // 
            this.fio_label.AutoSize = true;
            this.fio_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_label.Location = new System.Drawing.Point(14, 9);
            this.fio_label.Name = "fio_label";
            this.fio_label.Size = new System.Drawing.Size(60, 25);
            this.fio_label.TabIndex = 10;
            this.fio_label.Text = "ФИО";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fio_textBox);
            this.panel2.Controls.Add(this.fio_label);
            this.panel2.Location = new System.Drawing.Point(12, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 49);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mail_textBox);
            this.panel3.Controls.Add(this.mail_label);
            this.panel3.Location = new System.Drawing.Point(12, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 51);
            this.panel3.TabIndex = 17;
            // 
            // mail_textBox
            // 
            this.mail_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail_textBox.Location = new System.Drawing.Point(204, 6);
            this.mail_textBox.Multiline = true;
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(713, 38);
            this.mail_textBox.TabIndex = 4;
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail_label.Location = new System.Drawing.Point(14, 9);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(70, 25);
            this.mail_label.TabIndex = 10;
            this.mail_label.Text = "Почта";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.phone_number_textBox);
            this.panel4.Controls.Add(this.phone_number_label);
            this.panel4.Location = new System.Drawing.Point(12, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(920, 52);
            this.panel4.TabIndex = 17;
            // 
            // phone_number_textBox
            // 
            this.phone_number_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_number_textBox.Location = new System.Drawing.Point(201, 6);
            this.phone_number_textBox.Multiline = true;
            this.phone_number_textBox.Name = "phone_number_textBox";
            this.phone_number_textBox.Size = new System.Drawing.Size(716, 38);
            this.phone_number_textBox.TabIndex = 4;
            // 
            // phone_number_label
            // 
            this.phone_number_label.AutoSize = true;
            this.phone_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_number_label.Location = new System.Drawing.Point(14, 9);
            this.phone_number_label.Name = "phone_number_label";
            this.phone_number_label.Size = new System.Drawing.Size(177, 25);
            this.phone_number_label.TabIndex = 10;
            this.phone_number_label.Text = "Номер телефона";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.card_number_textBox);
            this.panel5.Controls.Add(this.card_number_label);
            this.panel5.Location = new System.Drawing.Point(12, 192);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(920, 48);
            this.panel5.TabIndex = 17;
            // 
            // card_number_textBox
            // 
            this.card_number_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.card_number_textBox.Location = new System.Drawing.Point(201, 7);
            this.card_number_textBox.Multiline = true;
            this.card_number_textBox.Name = "card_number_textBox";
            this.card_number_textBox.Size = new System.Drawing.Size(716, 38);
            this.card_number_textBox.TabIndex = 4;
            // 
            // card_number_label
            // 
            this.card_number_label.AutoSize = true;
            this.card_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.card_number_label.Location = new System.Drawing.Point(14, 6);
            this.card_number_label.Name = "card_number_label";
            this.card_number_label.Size = new System.Drawing.Size(137, 25);
            this.card_number_label.TabIndex = 10;
            this.card_number_label.Text = "Номер карты";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.login_textBox);
            this.panel6.Controls.Add(this.login_label);
            this.panel6.Location = new System.Drawing.Point(12, 246);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(920, 48);
            this.panel6.TabIndex = 17;
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox.Location = new System.Drawing.Point(201, 3);
            this.login_textBox.Multiline = true;
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(716, 38);
            this.login_textBox.TabIndex = 4;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(14, 6);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(68, 25);
            this.login_label.TabIndex = 10;
            this.login_label.Text = "Логин";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.password_textBox);
            this.panel7.Controls.Add(this.password_label);
            this.panel7.Location = new System.Drawing.Point(12, 300);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(920, 48);
            this.panel7.TabIndex = 17;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textBox.Location = new System.Drawing.Point(201, 7);
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(716, 38);
            this.password_textBox.TabIndex = 4;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(14, 6);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(80, 25);
            this.password_label.TabIndex = 10;
            this.password_label.Text = "Пароль";
            // 
            // on_main_page_button
            // 
            this.on_main_page_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.on_main_page_button.Location = new System.Drawing.Point(516, 494);
            this.on_main_page_button.Name = "on_main_page_button";
            this.on_main_page_button.Size = new System.Drawing.Size(258, 81);
            this.on_main_page_button.TabIndex = 18;
            this.on_main_page_button.Text = "На главную";
            this.on_main_page_button.UseVisualStyleBackColor = true;
            this.on_main_page_button.Click += new System.EventHandler(this.on_main_page_button_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 587);
            this.Controls.Add(this.on_main_page_button);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registration_button);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База 3D модедей. Регистрация.";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.RadioButton client_radioButton;
        private System.Windows.Forms.RadioButton seller_radioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fio_textBox;
        private System.Windows.Forms.Label fio_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.Label mail_label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox phone_number_textBox;
        private System.Windows.Forms.Label phone_number_label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox card_number_textBox;
        private System.Windows.Forms.Label card_number_label;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button on_main_page_button;
    }
}
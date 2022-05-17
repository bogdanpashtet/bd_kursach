namespace RZ
{
    partial class StartForm
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
            this.enter_button = new System.Windows.Forms.Button();
            this.registration_button = new System.Windows.Forms.Button();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter_button
            // 
            this.enter_button.Location = new System.Drawing.Point(313, 271);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(176, 56);
            this.enter_button.TabIndex = 0;
            this.enter_button.Text = "Войти";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // registration_button
            // 
            this.registration_button.Location = new System.Drawing.Point(313, 349);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(176, 56);
            this.registration_button.TabIndex = 1;
            this.registration_button.Text = "Зарегистрироваться";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox.Location = new System.Drawing.Point(247, 151);
            this.login_textBox.Multiline = true;
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(321, 36);
            this.login_textBox.TabIndex = 2;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textBox.Location = new System.Drawing.Point(247, 204);
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(321, 36);
            this.password_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.enter_button);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База 3D моделей";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


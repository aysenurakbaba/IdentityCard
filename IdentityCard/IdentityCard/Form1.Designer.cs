
namespace IdentityCard
{
    partial class Form1
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
            this.id = new System.Windows.Forms.TextBox();
            this.trIdentityNo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.documentNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.ComboBox();
            this.nationality = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.insertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(265, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(209, 20);
            this.id.TabIndex = 0;
            this.id.Text = "REPUBLIC OF TURKEY IDENTITY CARD";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // trIdentityNo
            // 
            this.trIdentityNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trIdentityNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trIdentityNo.Location = new System.Drawing.Point(104, 78);
            this.trIdentityNo.Name = "trIdentityNo";
            this.trIdentityNo.Size = new System.Drawing.Size(100, 13);
            this.trIdentityNo.TabIndex = 1;
            this.trIdentityNo.Text = "TR Identity No";
            this.trIdentityNo.TextChanged += new System.EventHandler(this.trIdentityNo_TextChanged);
            this.trIdentityNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trIdentityNo_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(104, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname.Location = new System.Drawing.Point(210, 114);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 13);
            this.surname.TabIndex = 3;
            this.surname.Text = "Surname";
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Location = new System.Drawing.Point(210, 140);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 13);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // documentNo
            // 
            this.documentNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.documentNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.documentNo.Location = new System.Drawing.Point(210, 192);
            this.documentNo.Name = "documentNo";
            this.documentNo.Size = new System.Drawing.Size(100, 13);
            this.documentNo.TabIndex = 6;
            this.documentNo.Text = "Document No";
            this.documentNo.TextChanged += new System.EventHandler(this.documentNo_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker2.Location = new System.Drawing.Point(210, 211);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gender.ForeColor = System.Drawing.Color.Black;
            this.gender.FormattingEnabled = true;
            this.gender.Location = new System.Drawing.Point(418, 184);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 21);
            this.gender.TabIndex = 8;
            this.gender.Text = "Gender";
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // nationality
            // 
            this.nationality.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nationality.FormattingEnabled = true;
            this.nationality.Location = new System.Drawing.Point(418, 211);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(121, 21);
            this.nationality.TabIndex = 9;
            this.nationality.Text = "Nationality";
            this.nationality.SelectedIndexChanged += new System.EventHandler(this.nationality_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::IdentityCard.Properties.Resources._9986343665714;
            this.pictureBox2.Location = new System.Drawing.Point(565, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 207);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.insertButton.Location = new System.Drawing.Point(620, 327);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(107, 35);
            this.insertButton.TabIndex = 11;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.documentNo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trIdentityNo);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "ID CARD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox trIdentityNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox documentNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.ComboBox nationality;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button insertButton;
    }
}
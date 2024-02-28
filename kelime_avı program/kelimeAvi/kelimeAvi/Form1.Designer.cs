namespace kelimeAvi
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
            this.groupBox_Skor = new System.Windows.Forms.GroupBox();
            this.label_Skor = new System.Windows.Forms.Label();
            this.button_basla = new System.Windows.Forms.Button();
            this.groupBox_Tahmin = new System.Windows.Forms.GroupBox();
            this.button_Dene = new System.Windows.Forms.Button();
            this.textBox_tahmin = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_Deneme = new System.Windows.Forms.GroupBox();
            this.label_deneme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Skor.SuspendLayout();
            this.groupBox_Tahmin.SuspendLayout();
            this.groupBox_Deneme.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Skor
            // 
            this.groupBox_Skor.Controls.Add(this.label1);
            this.groupBox_Skor.Controls.Add(this.label_Skor);
            this.groupBox_Skor.Enabled = false;
            this.groupBox_Skor.Location = new System.Drawing.Point(342, 58);
            this.groupBox_Skor.Name = "groupBox_Skor";
            this.groupBox_Skor.Size = new System.Drawing.Size(88, 45);
            this.groupBox_Skor.TabIndex = 0;
            this.groupBox_Skor.TabStop = false;
            // 
            // label_Skor
            // 
            this.label_Skor.AutoSize = true;
            this.label_Skor.Location = new System.Drawing.Point(56, 19);
            this.label_Skor.Name = "label_Skor";
            this.label_Skor.Size = new System.Drawing.Size(13, 15);
            this.label_Skor.TabIndex = 0;
            this.label_Skor.Text = "0";
            // 
            // button_basla
            // 
            this.button_basla.Location = new System.Drawing.Point(8, 109);
            this.button_basla.Name = "button_basla";
            this.button_basla.Size = new System.Drawing.Size(422, 23);
            this.button_basla.TabIndex = 1;
            this.button_basla.Text = "OYNA";
            this.button_basla.UseVisualStyleBackColor = true;
            // 
            // groupBox_Tahmin
            // 
            this.groupBox_Tahmin.Controls.Add(this.button_Dene);
            this.groupBox_Tahmin.Controls.Add(this.textBox_tahmin);
            this.groupBox_Tahmin.Enabled = false;
            this.groupBox_Tahmin.Location = new System.Drawing.Point(8, 58);
            this.groupBox_Tahmin.Name = "groupBox_Tahmin";
            this.groupBox_Tahmin.Size = new System.Drawing.Size(200, 45);
            this.groupBox_Tahmin.TabIndex = 3;
            this.groupBox_Tahmin.TabStop = false;
            // 
            // button_Dene
            // 
            this.button_Dene.Location = new System.Drawing.Point(112, 15);
            this.button_Dene.Name = "button_Dene";
            this.button_Dene.Size = new System.Drawing.Size(63, 23);
            this.button_Dene.TabIndex = 1;
            this.button_Dene.Text = "DENE";
            this.button_Dene.UseVisualStyleBackColor = true;
            // 
            // textBox_tahmin
            // 
            this.textBox_tahmin.Location = new System.Drawing.Point(6, 16);
            this.textBox_tahmin.Name = "textBox_tahmin";
            this.textBox_tahmin.Size = new System.Drawing.Size(100, 23);
            this.textBox_tahmin.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Enabled = false;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(422, 40);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // groupBox_Deneme
            // 
            this.groupBox_Deneme.Controls.Add(this.label2);
            this.groupBox_Deneme.Controls.Add(this.label_deneme);
            this.groupBox_Deneme.Enabled = false;
            this.groupBox_Deneme.Location = new System.Drawing.Point(252, 58);
            this.groupBox_Deneme.Name = "groupBox_Deneme";
            this.groupBox_Deneme.Size = new System.Drawing.Size(84, 45);
            this.groupBox_Deneme.TabIndex = 1;
            this.groupBox_Deneme.TabStop = false;
            // 
            // label_deneme
            // 
            this.label_deneme.AutoSize = true;
            this.label_deneme.Location = new System.Drawing.Point(63, 19);
            this.label_deneme.Name = "label_deneme";
            this.label_deneme.Size = new System.Drawing.Size(13, 15);
            this.label_deneme.TabIndex = 0;
            this.label_deneme.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skor =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deneme =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 144);
            this.Controls.Add(this.groupBox_Deneme);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox_Tahmin);
            this.Controls.Add(this.groupBox_Skor);
            this.Controls.Add(this.button_basla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "KELİME AVI";
            this.groupBox_Skor.ResumeLayout(false);
            this.groupBox_Skor.PerformLayout();
            this.groupBox_Tahmin.ResumeLayout(false);
            this.groupBox_Tahmin.PerformLayout();
            this.groupBox_Deneme.ResumeLayout(false);
            this.groupBox_Deneme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox_Skor;
        private Label label_Skor;
        private Button button_basla;
        private GroupBox groupBox_Tahmin;
        private Button button_Dene;
        private TextBox textBox_tahmin;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox_Deneme;
        private Label label_deneme;
        private Label label1;
        private Label label2;
    }
}
namespace BaiKT_Nhom5
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
            btnChia = new Button();
            btnNhan = new Button();
            btnTru = new Button();
            btnCong = new Button();
            txt2 = new TextBox();
            txt1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtKQ = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnChia
            // 
            btnChia.Location = new Point(448, 375);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(103, 57);
            btnChia.TabIndex = 8;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(253, 375);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(103, 57);
            btnNhan.TabIndex = 9;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(448, 287);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(103, 57);
            btnTru.TabIndex = 10;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(253, 287);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(103, 57);
            btnCong.TabIndex = 11;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            // 
            // txt2
            // 
            txt2.Location = new Point(369, 209);
            txt2.Name = "txt2";
            txt2.Size = new Size(182, 27);
            txt2.TabIndex = 6;
            // 
            // txt1
            // 
            txt1.Location = new Point(369, 129);
            txt1.Name = "txt1";
            txt1.Size = new Size(182, 27);
            txt1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 209);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Số thứ 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 129);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Số thứ 1:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(391, 84);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 5;
            label1.Text = "THỰC HIỆN PHÉP TOÁN";
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(622, 338);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(153, 27);
            txtKQ.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(661, 287);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 13;
            label4.Text = "KẾT QUẢ:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 516);
            Controls.Add(label4);
            Controls.Add(txtKQ);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChia;
        private Button btnNhan;
        private Button btnTru;
        private Button btnCong;
        private TextBox txt2;
        private TextBox txt1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtKQ;
        private Label label4;
    }
}
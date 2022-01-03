
namespace Cau3
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
            this.btnAddNgot = new System.Windows.Forms.Button();
            this.btnAddEp = new System.Windows.Forms.Button();
            this.btnAddKhoang = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelNgot = new System.Windows.Forms.Button();
            this.btnDelKhoang = new System.Windows.Forms.Button();
            this.btnDelEp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNgot
            // 
            this.btnAddNgot.Location = new System.Drawing.Point(445, 281);
            this.btnAddNgot.Name = "btnAddNgot";
            this.btnAddNgot.Size = new System.Drawing.Size(136, 23);
            this.btnAddNgot.TabIndex = 0;
            this.btnAddNgot.Text = "Thêm vào nước ngọt";
            this.btnAddNgot.UseVisualStyleBackColor = true;
            this.btnAddNgot.Click += new System.EventHandler(this.btnAddNgot_Click);
            // 
            // btnAddEp
            // 
            this.btnAddEp.Location = new System.Drawing.Point(445, 310);
            this.btnAddEp.Name = "btnAddEp";
            this.btnAddEp.Size = new System.Drawing.Size(136, 23);
            this.btnAddEp.TabIndex = 1;
            this.btnAddEp.Text = "Thêm vào nước ép";
            this.btnAddEp.UseVisualStyleBackColor = true;
            this.btnAddEp.Click += new System.EventHandler(this.btnAddEp_Click);
            // 
            // btnAddKhoang
            // 
            this.btnAddKhoang.Location = new System.Drawing.Point(445, 339);
            this.btnAddKhoang.Name = "btnAddKhoang";
            this.btnAddKhoang.Size = new System.Drawing.Size(136, 23);
            this.btnAddKhoang.TabIndex = 2;
            this.btnAddKhoang.Text = "Thêm vào nước khoáng";
            this.btnAddKhoang.UseVisualStyleBackColor = true;
            this.btnAddKhoang.Click += new System.EventHandler(this.btnAddKhoang_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(501, 173);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(571, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 173);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hiển thị chi tiết máy bán hàng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(110, 312);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(329, 20);
            this.txtTenHang.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Hãng";
            // 
            // btnDelNgot
            // 
            this.btnDelNgot.Location = new System.Drawing.Point(587, 281);
            this.btnDelNgot.Name = "btnDelNgot";
            this.btnDelNgot.Size = new System.Drawing.Size(136, 23);
            this.btnDelNgot.TabIndex = 9;
            this.btnDelNgot.Text = "Xóa Nước Ngọt";
            this.btnDelNgot.UseVisualStyleBackColor = true;
            this.btnDelNgot.Click += new System.EventHandler(this.btnDelNgot_Click);
            // 
            // btnDelKhoang
            // 
            this.btnDelKhoang.Location = new System.Drawing.Point(587, 339);
            this.btnDelKhoang.Name = "btnDelKhoang";
            this.btnDelKhoang.Size = new System.Drawing.Size(136, 23);
            this.btnDelKhoang.TabIndex = 10;
            this.btnDelKhoang.Text = "Xóa Nước Khoáng";
            this.btnDelKhoang.UseVisualStyleBackColor = true;
            this.btnDelKhoang.Click += new System.EventHandler(this.btnDelKhoang_Click);
            // 
            // btnDelEp
            // 
            this.btnDelEp.Location = new System.Drawing.Point(587, 310);
            this.btnDelEp.Name = "btnDelEp";
            this.btnDelEp.Size = new System.Drawing.Size(136, 23);
            this.btnDelEp.TabIndex = 11;
            this.btnDelEp.Text = "Xóa Nước Ép";
            this.btnDelEp.UseVisualStyleBackColor = true;
            this.btnDelEp.Click += new System.EventHandler(this.btnDelEp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 384);
            this.Controls.Add(this.btnDelEp);
            this.Controls.Add(this.btnDelKhoang);
            this.Controls.Add(this.btnDelNgot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnAddKhoang);
            this.Controls.Add(this.btnAddEp);
            this.Controls.Add(this.btnAddNgot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNgot;
        private System.Windows.Forms.Button btnAddEp;
        private System.Windows.Forms.Button btnAddKhoang;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelNgot;
        private System.Windows.Forms.Button btnDelKhoang;
        private System.Windows.Forms.Button btnDelEp;
    }
}


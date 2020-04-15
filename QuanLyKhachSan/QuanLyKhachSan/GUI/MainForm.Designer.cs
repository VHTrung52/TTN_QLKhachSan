﻿namespace QuanLyKhachSan.GUI
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addKHBt = new System.Windows.Forms.Button();
            this.checkInBt = new System.Windows.Forms.Button();
            this.checkOutBt = new System.Windows.Forms.Button();
            this.datTruocBt = new System.Windows.Forms.Button();
            this.lichSuBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 385);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // addKHBt
            // 
            this.addKHBt.Location = new System.Drawing.Point(12, 12);
            this.addKHBt.Name = "addKHBt";
            this.addKHBt.Size = new System.Drawing.Size(107, 23);
            this.addKHBt.TabIndex = 1;
            this.addKHBt.Text = "Thêm khách hàng";
            this.addKHBt.UseVisualStyleBackColor = true;
            // 
            // checkInBt
            // 
            this.checkInBt.Location = new System.Drawing.Point(12, 41);
            this.checkInBt.Name = "checkInBt";
            this.checkInBt.Size = new System.Drawing.Size(107, 23);
            this.checkInBt.TabIndex = 2;
            this.checkInBt.Text = "Check-in";
            this.checkInBt.UseVisualStyleBackColor = true;
            // 
            // checkOutBt
            // 
            this.checkOutBt.Location = new System.Drawing.Point(12, 70);
            this.checkOutBt.Name = "checkOutBt";
            this.checkOutBt.Size = new System.Drawing.Size(107, 23);
            this.checkOutBt.TabIndex = 3;
            this.checkOutBt.Text = "Check-out";
            this.checkOutBt.UseVisualStyleBackColor = true;
            // 
            // datTruocBt
            // 
            this.datTruocBt.Location = new System.Drawing.Point(12, 99);
            this.datTruocBt.Name = "datTruocBt";
            this.datTruocBt.Size = new System.Drawing.Size(107, 23);
            this.datTruocBt.TabIndex = 4;
            this.datTruocBt.Text = "Đặt trước";
            this.datTruocBt.UseVisualStyleBackColor = true;
            // 
            // lichSuBt
            // 
            this.lichSuBt.Location = new System.Drawing.Point(12, 128);
            this.lichSuBt.Name = "lichSuBt";
            this.lichSuBt.Size = new System.Drawing.Size(107, 23);
            this.lichSuBt.TabIndex = 5;
            this.lichSuBt.Text = "Lịch sử";
            this.lichSuBt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phần mềm quản lý khách sạn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lichSuBt);
            this.Controls.Add(this.datTruocBt);
            this.Controls.Add(this.checkOutBt);
            this.Controls.Add(this.checkInBt);
            this.Controls.Add(this.addKHBt);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addKHBt;
        private System.Windows.Forms.Button checkInBt;
        private System.Windows.Forms.Button checkOutBt;
        private System.Windows.Forms.Button datTruocBt;
        private System.Windows.Forms.Button lichSuBt;
        private System.Windows.Forms.Label label1;
    }
}

namespace RedBlackTreeUygulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Txt_Value = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Tbp_RedBlack = new System.Windows.Forms.TabPage();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tbp_RedBlack.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.BackColor = System.Drawing.Color.Orange;
            this.Btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Insert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Insert.Location = new System.Drawing.Point(202, 37);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(126, 30);
            this.Btn_Insert.TabIndex = 2;
            this.Btn_Insert.Text = "Ekle";
            this.Btn_Insert.UseVisualStyleBackColor = false;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Orange;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Delete.Location = new System.Drawing.Point(362, 37);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(126, 30);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "Sil";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Txt_Value
            // 
            this.Txt_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Value.Location = new System.Drawing.Point(12, 37);
            this.Txt_Value.Name = "Txt_Value";
            this.Txt_Value.Size = new System.Drawing.Size(160, 30);
            this.Txt_Value.TabIndex = 4;
            this.Txt_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Insert_KeyDown);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.Orange;
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Search.Location = new System.Drawing.Point(504, 37);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(126, 30);
            this.Btn_Search.TabIndex = 5;
            this.Btn_Search.Text = "Ara";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPreOrder.Location = new System.Drawing.Point(693, 12);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(126, 30);
            this.btnPreOrder.TabIndex = 6;
            this.btnPreOrder.Text = "PreOrder";
            this.btnPreOrder.UseVisualStyleBackColor = false;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.BackColor = System.Drawing.Color.YellowGreen;
            this.btnInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInOrder.Location = new System.Drawing.Point(693, 46);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(126, 30);
            this.btnInOrder.TabIndex = 7;
            this.btnInOrder.Text = "InOrder";
            this.btnInOrder.UseVisualStyleBackColor = false;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPostOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPostOrder.Location = new System.Drawing.Point(693, 82);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(126, 30);
            this.btnPostOrder.TabIndex = 8;
            this.btnPostOrder.Text = "PostOrder";
            this.btnPostOrder.UseVisualStyleBackColor = false;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(834, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(450, 100);
            this.listBox1.TabIndex = 9;
            // 
            // Tbp_RedBlack
            // 
            this.Tbp_RedBlack.BackColor = System.Drawing.Color.LemonChiffon;
            this.Tbp_RedBlack.Controls.Add(this.printPreviewControl1);
            this.Tbp_RedBlack.Location = new System.Drawing.Point(4, 25);
            this.Tbp_RedBlack.Name = "Tbp_RedBlack";
            this.Tbp_RedBlack.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_RedBlack.Size = new System.Drawing.Size(1731, 721);
            this.Tbp_RedBlack.TabIndex = 0;
            this.Tbp_RedBlack.Text = "Red Black Tree";
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(828, 270);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(10, 8);
            this.printPreviewControl1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tbp_RedBlack);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(2, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1739, 750);
            this.tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1753, 703);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPostOrder);
            this.Controls.Add(this.btnInOrder);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Txt_Value);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Red Black Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tbp_RedBlack.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox Txt_Value;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage Tbp_RedBlack;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}


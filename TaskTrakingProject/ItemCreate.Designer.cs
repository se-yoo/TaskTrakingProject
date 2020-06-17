namespace TaskTrakingProject
{
    partial class ItemCreate
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
            this.contentBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(108, 138);
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(465, 265);
            this.contentBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "내용";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "제목";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(123, 46);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(67, 23);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "등록";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(50, 46);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(67, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "뒤로";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(108, 94);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(465, 25);
            this.titleBox.TabIndex = 1;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(123, 46);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(67, 23);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "수정";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // ItemCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 459);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "ItemCreate";
            this.Text = "ItemCreate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemCreate_FormClosed);
            this.Load += new System.EventHandler(this.ItemCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox contentBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button updateBtn;
    }
}
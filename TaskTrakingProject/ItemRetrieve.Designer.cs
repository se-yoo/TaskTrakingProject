namespace TaskTrakingProject
{
    partial class ItemRetrieve
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
            this.backBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chargerBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.historyList = new System.Windows.Forms.ListView();
            this.내용 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.처리날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addHistoryBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.endBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(50, 46);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(67, 23);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "뒤로";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(123, 46);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(67, 23);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "수정";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(196, 46);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(67, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "삭제";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "제목";
            // 
            // titleBox
            // 
            this.titleBox.AutoSize = true;
            this.titleBox.Location = new System.Drawing.Point(105, 97);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(82, 15);
            this.titleBox.TabIndex = 4;
            this.titleBox.Text = "제목입니다";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "내용";
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(108, 138);
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.ReadOnly = true;
            this.contentBox.Size = new System.Drawing.Size(465, 137);
            this.contentBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "담당자";
            // 
            // chargerBox
            // 
            this.chargerBox.AutoSize = true;
            this.chargerBox.Location = new System.Drawing.Point(521, 50);
            this.chargerBox.Name = "chargerBox";
            this.chargerBox.Size = new System.Drawing.Size(52, 15);
            this.chargerBox.TabIndex = 8;
            this.chargerBox.Text = "미배정";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "이력";
            // 
            // historyList
            // 
            this.historyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.내용,
            this.처리날짜});
            this.historyList.HideSelection = false;
            this.historyList.Location = new System.Drawing.Point(108, 290);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(465, 126);
            this.historyList.TabIndex = 10;
            this.historyList.TileSize = new System.Drawing.Size(150, 50);
            this.historyList.UseCompatibleStateImageBehavior = false;
            this.historyList.View = System.Windows.Forms.View.Details;
            // 
            // 내용
            // 
            this.내용.Text = "내용";
            this.내용.Width = 242;
            // 
            // 처리날짜
            // 
            this.처리날짜.Text = "처리날짜";
            this.처리날짜.Width = 190;
            // 
            // addHistoryBtn
            // 
            this.addHistoryBtn.Location = new System.Drawing.Point(27, 313);
            this.addHistoryBtn.Name = "addHistoryBtn";
            this.addHistoryBtn.Size = new System.Drawing.Size(75, 23);
            this.addHistoryBtn.TabIndex = 11;
            this.addHistoryBtn.Text = "이력추가";
            this.addHistoryBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(123, 46);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(67, 23);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "시작";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(123, 46);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(67, 23);
            this.endBtn.TabIndex = 13;
            this.endBtn.Text = "종료";
            this.endBtn.UseVisualStyleBackColor = true;
            // 
            // ItemRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 459);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.addHistoryBtn);
            this.Controls.Add(this.historyList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chargerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "ItemRetrieve";
            this.Text = "ItemRetrieve";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemRetrieve_FormClosed);
            this.Load += new System.EventHandler(this.ItemRetrieve_Load);
            this.VisibleChanged += new System.EventHandler(this.ItemRetrieve_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contentBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label chargerBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView historyList;
        private System.Windows.Forms.ColumnHeader 내용;
        private System.Windows.Forms.ColumnHeader 처리날짜;
        private System.Windows.Forms.Button addHistoryBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button endBtn;
    }
}
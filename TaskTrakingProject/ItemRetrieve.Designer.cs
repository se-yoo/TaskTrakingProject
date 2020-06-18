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
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(44, 37);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(65, 25);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "뒤로";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(115, 37);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(60, 25);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "수정";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(181, 37);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(65, 25);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "삭제";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(44, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "제목";
            // 
            // titleBox
            // 
            this.titleBox.AutoSize = true;
            this.titleBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleBox.Location = new System.Drawing.Point(92, 78);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(67, 15);
            this.titleBox.TabIndex = 4;
            this.titleBox.Text = "제목입니다";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(44, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "내용";
            // 
            // contentBox
            // 
            this.contentBox.BackColor = System.Drawing.Color.White;
            this.contentBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.contentBox.Location = new System.Drawing.Point(94, 110);
            this.contentBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.ReadOnly = true;
            this.contentBox.Size = new System.Drawing.Size(407, 110);
            this.contentBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(405, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "담당자";
            // 
            // chargerBox
            // 
            this.chargerBox.AutoSize = true;
            this.chargerBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chargerBox.Location = new System.Drawing.Point(456, 40);
            this.chargerBox.Name = "chargerBox";
            this.chargerBox.Size = new System.Drawing.Size(43, 15);
            this.chargerBox.TabIndex = 8;
            this.chargerBox.Text = "미배정";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(41, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "이력";
            // 
            // historyList
            // 
            this.historyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.내용,
            this.처리날짜});
            this.historyList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.historyList.HideSelection = false;
            this.historyList.Location = new System.Drawing.Point(94, 232);
            this.historyList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(407, 102);
            this.historyList.TabIndex = 10;
            this.historyList.TileSize = new System.Drawing.Size(150, 50);
            this.historyList.UseCompatibleStateImageBehavior = false;
            this.historyList.View = System.Windows.Forms.View.Details;
            // 
            // 내용
            // 
            this.내용.Text = "내용";
            this.내용.Width = 207;
            // 
            // 처리날짜
            // 
            this.처리날짜.Text = "처리날짜";
            this.처리날짜.Width = 190;
            // 
            // addHistoryBtn
            // 
            this.addHistoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addHistoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addHistoryBtn.FlatAppearance.BorderSize = 0;
            this.addHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addHistoryBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addHistoryBtn.ForeColor = System.Drawing.Color.White;
            this.addHistoryBtn.Location = new System.Drawing.Point(24, 256);
            this.addHistoryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addHistoryBtn.Name = "addHistoryBtn";
            this.addHistoryBtn.Size = new System.Drawing.Size(65, 25);
            this.addHistoryBtn.TabIndex = 11;
            this.addHistoryBtn.Text = "이력추가";
            this.addHistoryBtn.UseVisualStyleBackColor = false;
            this.addHistoryBtn.Click += new System.EventHandler(this.addHistoryBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(115, 37);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(60, 25);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "시작";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.endBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endBtn.FlatAppearance.BorderSize = 0;
            this.endBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.endBtn.ForeColor = System.Drawing.Color.White;
            this.endBtn.Location = new System.Drawing.Point(115, 37);
            this.endBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(65, 25);
            this.endBtn.TabIndex = 13;
            this.endBtn.Text = "처리완료";
            this.endBtn.UseVisualStyleBackColor = false;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // ItemRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 367);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemRetrieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "문의 조회";
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
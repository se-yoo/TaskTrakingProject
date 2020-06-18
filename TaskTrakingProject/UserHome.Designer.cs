namespace TaskTrakingProject
{
    partial class UserHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.nameBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.resultList = new System.Windows.Forms.ListView();
            this.itemTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusList = new System.Windows.Forms.ImageList(this.components);
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameBox.Location = new System.Drawing.Point(44, 33);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(72, 28);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "홍길동";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(117, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "님";
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItemBtn.FlatAppearance.BorderSize = 0;
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addItemBtn.ForeColor = System.Drawing.Color.White;
            this.addItemBtn.Location = new System.Drawing.Point(362, 38);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(74, 25);
            this.addItemBtn.TabIndex = 3;
            this.addItemBtn.Text = "문의 등록";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // resultList
            // 
            this.resultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemTitle,
            this.itemDate});
            this.resultList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultList.HideSelection = false;
            this.resultList.LargeImageList = this.statusList;
            this.resultList.Location = new System.Drawing.Point(46, 89);
            this.resultList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(469, 238);
            this.resultList.TabIndex = 4;
            this.resultList.TileSize = new System.Drawing.Size(250, 34);
            this.resultList.UseCompatibleStateImageBehavior = false;
            this.resultList.View = System.Windows.Forms.View.Tile;
            this.resultList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resultList_MouseClick);
            // 
            // itemTitle
            // 
            this.itemTitle.Width = 128;
            // 
            // itemDate
            // 
            this.itemDate.Width = 117;
            // 
            // statusList
            // 
            this.statusList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("statusList.ImageStream")));
            this.statusList.TransparentColor = System.Drawing.Color.Transparent;
            this.statusList.Images.SetKeyName(0, "status_0.PNG");
            this.statusList.Images.SetKeyName(1, "status_1.PNG");
            this.statusList.Images.SetKeyName(2, "status_2.PNG");
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(441, 38);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(74, 25);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "로그아웃";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 367);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "사용자홈";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserHome_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.UserHome_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.ListView resultList;
        private System.Windows.Forms.ImageList statusList;
        private System.Windows.Forms.ColumnHeader itemTitle;
        private System.Windows.Forms.ColumnHeader itemDate;
        private System.Windows.Forms.Button logoutBtn;
    }
}
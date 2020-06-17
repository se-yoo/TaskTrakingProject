namespace TaskTrakingProject
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.Label();
            this.standList = new System.Windows.Forms.ListView();
            this.itemTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusList = new System.Windows.Forms.ImageList(this.components);
            this.startList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "님";
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameBox.Location = new System.Drawing.Point(50, 46);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(87, 25);
            this.nameBox.TabIndex = 3;
            this.nameBox.Text = "홍길동";
            // 
            // standList
            // 
            this.standList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemTitle,
            this.itemDate});
            this.standList.HideSelection = false;
            this.standList.LargeImageList = this.statusList;
            this.standList.Location = new System.Drawing.Point(51, 111);
            this.standList.Name = "standList";
            this.standList.Size = new System.Drawing.Size(180, 296);
            this.standList.TabIndex = 5;
            this.standList.TileSize = new System.Drawing.Size(150, 34);
            this.standList.UseCompatibleStateImageBehavior = false;
            this.standList.View = System.Windows.Forms.View.Tile;
            this.standList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.standList_MouseClick);
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
            // startList
            // 
            this.startList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.startList.HideSelection = false;
            this.startList.LargeImageList = this.statusList;
            this.startList.Location = new System.Drawing.Point(230, 111);
            this.startList.Name = "startList";
            this.startList.Size = new System.Drawing.Size(180, 296);
            this.startList.TabIndex = 6;
            this.startList.TileSize = new System.Drawing.Size(150, 34);
            this.startList.UseCompatibleStateImageBehavior = false;
            this.startList.View = System.Windows.Forms.View.Tile;
            this.startList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 117;
            // 
            // endList
            // 
            this.endList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.endList.HideSelection = false;
            this.endList.LargeImageList = this.statusList;
            this.endList.Location = new System.Drawing.Point(409, 111);
            this.endList.Name = "endList";
            this.endList.Size = new System.Drawing.Size(180, 296);
            this.endList.TabIndex = 7;
            this.endList.TileSize = new System.Drawing.Size(150, 34);
            this.endList.UseCompatibleStateImageBehavior = false;
            this.endList.View = System.Windows.Forms.View.Tile;
            this.endList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.endList_MouseClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 117;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(504, 46);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(85, 25);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "로그아웃";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 459);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.endList);
            this.Controls.Add(this.startList);
            this.Controls.Add(this.standList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.VisibleChanged += new System.EventHandler(this.AdminHome_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.ListView standList;
        private System.Windows.Forms.ColumnHeader itemTitle;
        private System.Windows.Forms.ColumnHeader itemDate;
        private System.Windows.Forms.ListView startList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView endList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList statusList;
        private System.Windows.Forms.Button logoutBtn;
    }
}
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "건의 드립니다",
            "2020-06-14"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "건의 드립니다",
            "2020-06-14"}, 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "건의 드립니다",
            "2020-06-14"}, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.Label();
            this.resultList = new System.Windows.Forms.ListView();
            this.itemTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusList = new System.Windows.Forms.ImageList(this.components);
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
            // resultList
            // 
            this.resultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemTitle,
            this.itemDate});
            this.resultList.HideSelection = false;
            this.resultList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.resultList.LargeImageList = this.statusList;
            this.resultList.Location = new System.Drawing.Point(51, 111);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(180, 296);
            this.resultList.TabIndex = 5;
            this.resultList.TileSize = new System.Drawing.Size(160, 34);
            this.resultList.UseCompatibleStateImageBehavior = false;
            this.resultList.View = System.Windows.Forms.View.Tile;
            // 
            // itemTitle
            // 
            this.itemTitle.Width = 128;
            // 
            // itemDate
            // 
            this.itemDate.Width = 117;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.LargeImageList = this.statusList;
            this.listView1.Location = new System.Drawing.Point(237, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(180, 296);
            this.listView1.TabIndex = 6;
            this.listView1.TileSize = new System.Drawing.Size(160, 34);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 117;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView2.LargeImageList = this.statusList;
            this.listView2.Location = new System.Drawing.Point(423, 111);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(180, 296);
            this.listView2.TabIndex = 7;
            this.listView2.TileSize = new System.Drawing.Size(160, 34);
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 117;
            // 
            // statusList
            // 
            this.statusList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("statusList.ImageStream")));
            this.statusList.TransparentColor = System.Drawing.Color.Transparent;
            this.statusList.Images.SetKeyName(0, "status_0.PNG");
            this.statusList.Images.SetKeyName(1, "status_1.PNG");
            this.statusList.Images.SetKeyName(2, "status_2.PNG");
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 459);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.ListView resultList;
        private System.Windows.Forms.ColumnHeader itemTitle;
        private System.Windows.Forms.ColumnHeader itemDate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList statusList;
    }
}
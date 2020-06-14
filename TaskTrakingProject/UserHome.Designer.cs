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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "건의 드립니다",
            "2020-06-14"}, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.nameBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.resultList = new System.Windows.Forms.ListView();
            this.statusList = new System.Windows.Forms.ImageList(this.components);
            this.itemTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameBox.Location = new System.Drawing.Point(50, 46);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(87, 25);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "홍길동";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "님";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(493, 46);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(85, 25);
            this.addItemBtn.TabIndex = 3;
            this.addItemBtn.Text = "문의 등록";
            this.addItemBtn.UseVisualStyleBackColor = true;
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
            this.resultList.Location = new System.Drawing.Point(55, 111);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(523, 296);
            this.resultList.TabIndex = 4;
            this.resultList.TileSize = new System.Drawing.Size(250, 34);
            this.resultList.UseCompatibleStateImageBehavior = false;
            this.resultList.View = System.Windows.Forms.View.Tile;
            // 
            // statusList
            // 
            this.statusList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("statusList.ImageStream")));
            this.statusList.TransparentColor = System.Drawing.Color.Transparent;
            this.statusList.Images.SetKeyName(0, "status_0.PNG");
            this.statusList.Images.SetKeyName(1, "status_1.PNG");
            this.statusList.Images.SetKeyName(2, "status_2.PNG");
            // 
            // itemTitle
            // 
            this.itemTitle.Width = 128;
            // 
            // itemDate
            // 
            this.itemDate.Width = 117;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 459);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "UserHome";
            this.Text = "UserHome";
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
    }
}
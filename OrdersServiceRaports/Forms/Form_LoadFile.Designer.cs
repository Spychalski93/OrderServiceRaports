namespace OrdersServiceRaports.Formularze
{
    partial class Form_LoadFile
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
            this.listView_ReadOrdered = new System.Windows.Forms.ListView();
            this.columnHeaderClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRequestId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_ReadOrdered = new System.Windows.Forms.Label();
            this.panel_AllOrders = new System.Windows.Forms.Panel();
            this.button_ = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.label_FilePath = new System.Windows.Forms.Label();
            this.label_Announcements = new System.Windows.Forms.Label();
            this.label_EditAnnouncements = new System.Windows.Forms.Label();
            this.label_EditAnnouncementsBadLoad = new System.Windows.Forms.Label();
            this.panel_AllOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_ReadOrdered
            // 
            this.listView_ReadOrdered.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderClientId,
            this.columnHeaderRequestId,
            this.columnHeaderName,
            this.columnHeaderQuantity,
            this.columnHeaderPrice});
            this.listView_ReadOrdered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_ReadOrdered.Location = new System.Drawing.Point(0, 0);
            this.listView_ReadOrdered.Name = "listView_ReadOrdered";
            this.listView_ReadOrdered.Size = new System.Drawing.Size(535, 215);
            this.listView_ReadOrdered.TabIndex = 13;
            this.listView_ReadOrdered.UseCompatibleStateImageBehavior = false;
            this.listView_ReadOrdered.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderClientId
            // 
            this.columnHeaderClientId.Text = "ID klienta";
            this.columnHeaderClientId.Width = 71;
            // 
            // columnHeaderRequestId
            // 
            this.columnHeaderRequestId.Text = "ID zamówienia dla klienta";
            this.columnHeaderRequestId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderRequestId.Width = 135;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Nazwa";
            this.columnHeaderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderName.Width = 128;
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Ilość";
            this.columnHeaderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderQuantity.Width = 80;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Cena jednostkowa";
            this.columnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPrice.Width = 121;
            // 
            // label_ReadOrdered
            // 
            this.label_ReadOrdered.AutoSize = true;
            this.label_ReadOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ReadOrdered.Location = new System.Drawing.Point(12, 143);
            this.label_ReadOrdered.Name = "label_ReadOrdered";
            this.label_ReadOrdered.Size = new System.Drawing.Size(158, 15);
            this.label_ReadOrdered.TabIndex = 14;
            this.label_ReadOrdered.Text = "Odczytane zamówienia:";
            // 
            // panel_AllOrders
            // 
            this.panel_AllOrders.AutoScroll = true;
            this.panel_AllOrders.Controls.Add(this.listView_ReadOrdered);
            this.panel_AllOrders.Location = new System.Drawing.Point(15, 161);
            this.panel_AllOrders.Name = "panel_AllOrders";
            this.panel_AllOrders.Size = new System.Drawing.Size(535, 215);
            this.panel_AllOrders.TabIndex = 15;
            // 
            // button_
            // 
            this.button_.Location = new System.Drawing.Point(15, 117);
            this.button_.Name = "button_";
            this.button_.Size = new System.Drawing.Size(75, 23);
            this.button_.TabIndex = 16;
            this.button_.Text = "Wyświetl";
            this.toolTip.SetToolTip(this.button_, "Wyświetl wczytane zamówienia");
            this.button_.UseVisualStyleBackColor = true;
            this.button_.Click += new System.EventHandler(this.button__Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(472, 13);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 19;
            this.buttonLoad.Text = "Wczytaj";
            this.toolTip.SetToolTip(this.buttonLoad, "Wczytaj zamówienia z pliku");
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(103, 16);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(363, 20);
            this.textBox_FilePath.TabIndex = 1;
            // 
            // label_FilePath
            // 
            this.label_FilePath.AutoSize = true;
            this.label_FilePath.Location = new System.Drawing.Point(12, 19);
            this.label_FilePath.Name = "label_FilePath";
            this.label_FilePath.Size = new System.Drawing.Size(88, 13);
            this.label_FilePath.TabIndex = 18;
            this.label_FilePath.Text = "Ścieżka do pliku:";
            // 
            // label_Announcements
            // 
            this.label_Announcements.AutoSize = true;
            this.label_Announcements.Location = new System.Drawing.Point(30, 66);
            this.label_Announcements.Name = "label_Announcements";
            this.label_Announcements.Size = new System.Drawing.Size(65, 13);
            this.label_Announcements.TabIndex = 20;
            this.label_Announcements.Text = "Komunikaty:";
            // 
            // label_EditAnnouncements
            // 
            this.label_EditAnnouncements.AutoSize = true;
            this.label_EditAnnouncements.Location = new System.Drawing.Point(103, 66);
            this.label_EditAnnouncements.MaximumSize = new System.Drawing.Size(32767, 0);
            this.label_EditAnnouncements.Name = "label_EditAnnouncements";
            this.label_EditAnnouncements.Size = new System.Drawing.Size(0, 13);
            this.label_EditAnnouncements.TabIndex = 21;
            // 
            // label_EditAnnouncementsBadLoad
            // 
            this.label_EditAnnouncementsBadLoad.AutoSize = true;
            this.label_EditAnnouncementsBadLoad.Location = new System.Drawing.Point(103, 83);
            this.label_EditAnnouncementsBadLoad.Name = "label_EditAnnouncementsBadLoad";
            this.label_EditAnnouncementsBadLoad.Size = new System.Drawing.Size(0, 13);
            this.label_EditAnnouncementsBadLoad.TabIndex = 22;
            // 
            // Form_LoadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 388);
            this.Controls.Add(this.label_EditAnnouncementsBadLoad);
            this.Controls.Add(this.label_EditAnnouncements);
            this.Controls.Add(this.textBox_FilePath);
            this.Controls.Add(this.label_Announcements);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label_FilePath);
            this.Controls.Add(this.button_);
            this.Controls.Add(this.panel_AllOrders);
            this.Controls.Add(this.label_ReadOrdered);
            this.Name = "Form_LoadFile";
            this.Text = "Odczyt zamówień z pliku";
            this.panel_AllOrders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_ReadOrdered;
        private System.Windows.Forms.ColumnHeader columnHeaderClientId;
        private System.Windows.Forms.ColumnHeader columnHeaderRequestId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.Label label_ReadOrdered;
        private System.Windows.Forms.Panel panel_AllOrders;
        private System.Windows.Forms.Button button_;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Label label_FilePath;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label_Announcements;
        private System.Windows.Forms.Label label_EditAnnouncements;
        private System.Windows.Forms.Label label_EditAnnouncementsBadLoad;
    }
}
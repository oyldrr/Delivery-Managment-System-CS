namespace DMS.UserControls
{
    partial class customersUC
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customersUC));
            this.CustomerLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addCustomerButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cardViewPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.Location = new System.Drawing.Point(650, 30);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(268, 52);
            this.CustomerLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerLabel.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.CustomerLabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.CustomerLabel.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.CustomerLabel.TabIndex = 1;
            this.CustomerLabel.Values.Text = "CUSTOMERS";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomerButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addCustomerButton.Location = new System.Drawing.Point(0, 689);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.addCustomerButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.addCustomerButton.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.addCustomerButton.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.addCustomerButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addCustomerButton.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.addCustomerButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.addCustomerButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.addCustomerButton.OverrideFocus.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.addCustomerButton.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.addCustomerButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addCustomerButton.OverrideFocus.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.addCustomerButton.Size = new System.Drawing.Size(1582, 82);
            this.addCustomerButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.addCustomerButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.addCustomerButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.addCustomerButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.addCustomerButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addCustomerButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addCustomerButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addCustomerButton.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.addCustomerButton.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.addCustomerButton.TabIndex = 3;
            this.addCustomerButton.Values.Text = "+ ADD NEW RECORD +";
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(613, 94);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(320, 46);
            this.searchBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.searchBox.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.searchBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchBox.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.searchBox.StateCommon.Border.Rounding = 15;
            this.searchBox.StateCommon.Border.Width = 1;
            this.searchBox.StateCommon.Content.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.searchBox.TabIndex = 4;
            this.searchBox.Text = "Search...";
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(900, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // customerCheckBox
            // 
            this.customerCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerCheckBox.Location = new System.Drawing.Point(971, 107);
            this.customerCheckBox.Name = "customerCheckBox";
            this.customerCheckBox.Size = new System.Drawing.Size(228, 27);
            this.customerCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerCheckBox.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.customerCheckBox.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.customerCheckBox.TabIndex = 6;
            this.customerCheckBox.Values.Text = "Show disactive cargos";
            this.customerCheckBox.CheckStateChanged += new System.EventHandler(this.customerCheckBox_CheckStateChanged);
            // 
            // cardViewPanel
            // 
            this.cardViewPanel.AutoScroll = true;
            this.cardViewPanel.Location = new System.Drawing.Point(22, 155);
            this.cardViewPanel.Name = "cardViewPanel";
            this.cardViewPanel.Size = new System.Drawing.Size(1540, 514);
            this.cardViewPanel.TabIndex = 9;
            // 
            // customersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardViewPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customerCheckBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.CustomerLabel);
            this.Name = "customersUC";
            this.Size = new System.Drawing.Size(1582, 771);
            this.Load += new System.EventHandler(this.customersUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel CustomerLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addCustomerButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox customerCheckBox;
        private System.Windows.Forms.Panel cardViewPanel;
    }
}

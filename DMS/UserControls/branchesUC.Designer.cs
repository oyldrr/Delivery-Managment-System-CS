namespace DMS.UserControls
{
    partial class branchesUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(branchesUC));
            this.BranchesLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addBranchButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.branchCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cardViewPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BranchesLabel
            // 
            this.BranchesLabel.Location = new System.Drawing.Point(650, 30);
            this.BranchesLabel.Name = "BranchesLabel";
            this.BranchesLabel.Size = new System.Drawing.Size(242, 52);
            this.BranchesLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BranchesLabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.BranchesLabel.TabIndex = 1;
            this.BranchesLabel.Values.Text = "BRANCHES";
            // 
            // addBranchButton
            // 
            this.addBranchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBranchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addBranchButton.Location = new System.Drawing.Point(0, 689);
            this.addBranchButton.Name = "addBranchButton";
            this.addBranchButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.addBranchButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.addBranchButton.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.addBranchButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addBranchButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.addBranchButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.addBranchButton.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.addBranchButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addBranchButton.Size = new System.Drawing.Size(1582, 82);
            this.addBranchButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.addBranchButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.addBranchButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.addBranchButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.addBranchButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addBranchButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addBranchButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBranchButton.TabIndex = 3;
            this.addBranchButton.Values.Text = "+ ADD NEW RECORD +";
            this.addBranchButton.Click += new System.EventHandler(this.addBranchButton_Click);
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
            // branchCheckBox
            // 
            this.branchCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.branchCheckBox.Location = new System.Drawing.Point(971, 107);
            this.branchCheckBox.Name = "branchCheckBox";
            this.branchCheckBox.Size = new System.Drawing.Size(228, 27);
            this.branchCheckBox.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.branchCheckBox.TabIndex = 6;
            this.branchCheckBox.Values.Text = "Show disactive cargos";
            this.branchCheckBox.CheckStateChanged += new System.EventHandler(this.branchCheckBox_CheckStateChanged);
            // 
            // cardViewPanel
            // 
            this.cardViewPanel.AutoScroll = true;
            this.cardViewPanel.Location = new System.Drawing.Point(22, 155);
            this.cardViewPanel.Name = "cardViewPanel";
            this.cardViewPanel.Size = new System.Drawing.Size(1540, 446);
            this.cardViewPanel.TabIndex = 8;
            // 
            // branchesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addBranchButton);
            this.Controls.Add(this.cardViewPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.branchCheckBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.BranchesLabel);
            this.Name = "branchesUC";
            this.Size = new System.Drawing.Size(1582, 771);
            this.Load += new System.EventHandler(this.branchesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel BranchesLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addBranchButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox branchCheckBox;
        private System.Windows.Forms.Panel cardViewPanel;
    }
}

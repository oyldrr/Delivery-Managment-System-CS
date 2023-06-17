namespace DMS.UserControls
{
    partial class cargosUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cargosUC));
            this.CargoLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.addCargoButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardViewPanel = new System.Windows.Forms.Panel();
            this.cargoCheckbox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CargoLabel
            // 
            this.CargoLabel.Location = new System.Drawing.Point(675, 30);
            this.CargoLabel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.CargoLabel.Name = "CargoLabel";
            this.CargoLabel.Size = new System.Drawing.Size(187, 52);
            this.CargoLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CargoLabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.CargoLabel.TabIndex = 0;
            this.CargoLabel.Values.Text = "CARGOS";
            // 
            // addCargoButton
            // 
            this.addCargoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCargoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addCargoButton.Location = new System.Drawing.Point(0, 689);
            this.addCargoButton.Name = "addCargoButton";
            this.addCargoButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.addCargoButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.addCargoButton.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.addCargoButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addCargoButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.addCargoButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.addCargoButton.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.addCargoButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addCargoButton.Size = new System.Drawing.Size(1582, 82);
            this.addCargoButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.addCargoButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.addCargoButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.addCargoButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.addCargoButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addCargoButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addCargoButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addCargoButton.TabIndex = 2;
            this.addCargoButton.Values.Text = "+ ADD NEW RECORD +";
            this.addCargoButton.Click += new System.EventHandler(this.addCargoButton_Click);
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
            this.searchBox.TabIndex = 3;
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
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cardViewPanel
            // 
            this.cardViewPanel.AutoScroll = true;
            this.cardViewPanel.Location = new System.Drawing.Point(22, 155);
            this.cardViewPanel.Name = "cardViewPanel";
            this.cardViewPanel.Size = new System.Drawing.Size(1540, 446);
            this.cardViewPanel.TabIndex = 6;
            // 
            // cargoCheckbox
            // 
            this.cargoCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cargoCheckbox.Location = new System.Drawing.Point(971, 107);
            this.cargoCheckbox.Name = "cargoCheckbox";
            this.cargoCheckbox.Size = new System.Drawing.Size(228, 27);
            this.cargoCheckbox.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cargoCheckbox.TabIndex = 4;
            this.cargoCheckbox.Values.Text = "Show disactive cargos";
            this.cargoCheckbox.CheckStateChanged += new System.EventHandler(this.cargoCheckbox_CheckStateChanged);
            // 
            // cargosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardViewPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cargoCheckbox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.addCargoButton);
            this.Controls.Add(this.CargoLabel);
            this.Name = "cargosUC";
            this.Size = new System.Drawing.Size(1582, 771);
            this.Load += new System.EventHandler(this.cargosUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel CargoLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addCargoButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel cardViewPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cargoCheckbox;
    }
}

namespace DMS
{
    partial class main
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.anrLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.branchesButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.customersButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cargosButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.anrLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.branchesButton);
            this.panel1.Controls.Add(this.customersButton);
            this.panel1.Controls.Add(this.cargosButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 142);
            this.panel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kryptonLabel1.Location = new System.Drawing.Point(163, 70);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(354, 27);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.kryptonLabel1.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Copyrights reserved by oyldrr @2023";
            // 
            // anrLabel
            // 
            this.anrLabel.Location = new System.Drawing.Point(163, 26);
            this.anrLabel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.anrLabel.Name = "anrLabel";
            this.anrLabel.Size = new System.Drawing.Size(420, 38);
            this.anrLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.anrLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold);
            this.anrLabel.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.anrLabel.TabIndex = 5;
            this.anrLabel.Values.Text = "Delivery Managment System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // branchesButton
            // 
            this.branchesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.branchesButton.Location = new System.Drawing.Point(1045, 6);
            this.branchesButton.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.branchesButton.Name = "branchesButton";
            this.branchesButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.branchesButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.branchesButton.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.branchesButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.branchesButton.OverrideDefault.Border.Rounding = 15;
            this.branchesButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.branchesButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.branchesButton.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.branchesButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.branchesButton.Size = new System.Drawing.Size(190, 130);
            this.branchesButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.branchesButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.branchesButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.branchesButton.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("branchesButton.StateCommon.Back.Image")));
            this.branchesButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.branchesButton.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.branchesButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.branchesButton.StateCommon.Border.Rounding = 15;
            this.branchesButton.StateCommon.Border.Width = 1;
            this.branchesButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.branchesButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.branchesButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold);
            this.branchesButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.branchesButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.branchesButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.branchesButton.TabIndex = 3;
            this.branchesButton.Values.Text = "Branches";
            this.branchesButton.Click += new System.EventHandler(this.branchesButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customersButton.Location = new System.Drawing.Point(1252, 8);
            this.customersButton.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.customersButton.Name = "customersButton";
            this.customersButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.customersButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.customersButton.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.customersButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.customersButton.OverrideDefault.Border.Rounding = 15;
            this.customersButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.customersButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.customersButton.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.customersButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.customersButton.Size = new System.Drawing.Size(190, 130);
            this.customersButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.customersButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.customersButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.customersButton.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("customersButton.StateCommon.Back.Image")));
            this.customersButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.customersButton.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.customersButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.customersButton.StateCommon.Border.Rounding = 15;
            this.customersButton.StateCommon.Border.Width = 1;
            this.customersButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.customersButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.customersButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold);
            this.customersButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.customersButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.customersButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.customersButton.TabIndex = 2;
            this.customersButton.Values.Text = "Customers";
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // cargosButton
            // 
            this.cargosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cargosButton.Location = new System.Drawing.Point(822, 6);
            this.cargosButton.Name = "cargosButton";
            this.cargosButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.cargosButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.cargosButton.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.cargosButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cargosButton.OverrideDefault.Border.Rounding = 15;
            this.cargosButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.cargosButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.cargosButton.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.cargosButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cargosButton.Size = new System.Drawing.Size(190, 130);
            this.cargosButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.cargosButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.cargosButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.cargosButton.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("cargosButton.StateCommon.Back.Image")));
            this.cargosButton.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.cargosButton.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.cargosButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cargosButton.StateCommon.Border.Rounding = 15;
            this.cargosButton.StateCommon.Border.Width = 1;
            this.cargosButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.cargosButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.cargosButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold);
            this.cargosButton.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.cargosButton.TabIndex = 1;
            this.cargosButton.Values.Text = "Cargos";
            this.cargosButton.Click += new System.EventHandler(this.cargosButton_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContainer.BackgroundImage")));
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 142);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1582, 711);
            this.panelContainer.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Managment System";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cargosButton;
        private System.Windows.Forms.Panel panelContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton branchesButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton customersButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel anrLabel;
    }
}


namespace Arac_Takip_v1._00
{
    partial class AracEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracEkle));
            this.arac_Plaka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.arac_Km = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.arac_Model = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.Arac_Bilgileri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colArac_PlakaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArac_Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArac_Km = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aracTakipDBDataSet1 = new Arac_Takip_v1._00.AracTakipDBDataSet1();
            this.aracBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arac_BilgileriTableAdapter = new Arac_Takip_v1._00.AracTakipDBDataSet1TableAdapters.Arac_BilgileriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.arac_Plaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_Km.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_Model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arac_Bilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBilgileriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // arac_Plaka
            // 
            this.arac_Plaka.Location = new System.Drawing.Point(87, 50);
            this.arac_Plaka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arac_Plaka.Name = "arac_Plaka";
            this.arac_Plaka.Size = new System.Drawing.Size(117, 20);
            this.arac_Plaka.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 53);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Plaka No:";
            // 
            // arac_Km
            // 
            this.arac_Km.Location = new System.Drawing.Point(87, 123);
            this.arac_Km.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arac_Km.Name = "arac_Km";
            this.arac_Km.Properties.Mask.EditMask = "d";
            this.arac_Km.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.arac_Km.Size = new System.Drawing.Size(117, 20);
            this.arac_Km.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(50, 89);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Model:";
            // 
            // arac_Model
            // 
            this.arac_Model.Location = new System.Drawing.Point(87, 86);
            this.arac_Model.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arac_Model.Name = "arac_Model";
            this.arac_Model.Size = new System.Drawing.Size(117, 20);
            this.arac_Model.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 124);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Arac Km:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.arac_Model);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.arac_Plaka);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.arac_Km);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(21, 32);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(319, 348);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Arac Girişi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(8, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MinimumSize = new System.Drawing.Size(154, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 138);
            this.label1.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(165, 206);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(67, 35);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "SİL";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(237, 206);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(67, 35);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "EKLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.aracBilgileriBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(345, 32);
            this.gridControl1.MainView = this.Arac_Bilgileri;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(444, 348);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Arac_Bilgileri});
            // 
            // Arac_Bilgileri
            // 
            this.Arac_Bilgileri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArac_PlakaNo,
            this.colArac_Model,
            this.colArac_Km});
            this.Arac_Bilgileri.GridControl = this.gridControl1;
            this.Arac_Bilgileri.Name = "Arac_Bilgileri";
            this.Arac_Bilgileri.OptionsBehavior.Editable = false;
            // 
            // colArac_PlakaNo
            // 
            this.colArac_PlakaNo.FieldName = "Arac_PlakaNo";
            this.colArac_PlakaNo.Name = "colArac_PlakaNo";
            this.colArac_PlakaNo.Visible = true;
            this.colArac_PlakaNo.VisibleIndex = 0;
            // 
            // colArac_Model
            // 
            this.colArac_Model.FieldName = "Arac_Model";
            this.colArac_Model.Name = "colArac_Model";
            this.colArac_Model.Visible = true;
            this.colArac_Model.VisibleIndex = 1;
            // 
            // colArac_Km
            // 
            this.colArac_Km.FieldName = "Arac_Km";
            this.colArac_Km.Name = "colArac_Km";
            this.colArac_Km.Visible = true;
            this.colArac_Km.VisibleIndex = 2;
            // 
            // aracTakipDBDataSet1
            // 
            this.aracTakipDBDataSet1.DataSetName = "AracTakipDBDataSet1";
            this.aracTakipDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aracBilgileriBindingSource
            // 
            this.aracBilgileriBindingSource.DataMember = "Arac_Bilgileri";
            this.aracBilgileriBindingSource.DataSource = this.aracTakipDBDataSet1;
            // 
            // arac_BilgileriTableAdapter
            // 
            this.arac_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 388);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AracEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracEkle";
            this.Load += new System.EventHandler(this.AracEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arac_Plaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_Km.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_Model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arac_Bilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBilgileriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit arac_Plaka;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit arac_Km;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit arac_Model;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView Arac_Bilgileri;
        private DevExpress.XtraGrid.Columns.GridColumn colArac_PlakaNo;
        private DevExpress.XtraGrid.Columns.GridColumn colArac_Model;
        private DevExpress.XtraGrid.Columns.GridColumn colArac_Km;
        private System.Windows.Forms.Label label1;
        private AracTakipDBDataSet1 aracTakipDBDataSet1;
        private System.Windows.Forms.BindingSource aracBilgileriBindingSource;
        private AracTakipDBDataSet1TableAdapters.Arac_BilgileriTableAdapter arac_BilgileriTableAdapter;
    }
}
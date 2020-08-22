namespace Arac_Takip_v1._00
{
    partial class SoforEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoforEkle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tel = new DevExpress.XtraEditors.TextEdit();
            this.soyad = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.ad = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tc = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSurucu_TC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurucu_Adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurucu_Soyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurucu_Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aracTakipDBDataSet1 = new Arac_Takip_v1._00.AracTakipDBDataSet1();
            this.surucuBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surucu_BilgileriTableAdapter = new Arac_Takip_v1._00.AracTakipDBDataSet1TableAdapters.Surucu_BilgileriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surucuBilgileriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.tel);
            this.groupControl1.Controls.Add(this.soyad);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.ad);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.tc);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(19, 20);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(279, 348);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Şöför Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(9, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.MinimumSize = new System.Drawing.Size(112, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 146);
            this.label5.TabIndex = 5;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(140, 260);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(58, 35);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "SİL";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(202, 260);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(68, 35);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "EKLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(93, 164);
            this.tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(118, 20);
            this.tel.TabIndex = 2;
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(93, 125);
            this.soyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(118, 20);
            this.soyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon:";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(93, 86);
            this.ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(118, 20);
            this.ad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyadı:";
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(93, 47);
            this.tc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(118, 20);
            this.tc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc No:";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.surucuBilgileriBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(303, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(387, 340);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSurucu_TC,
            this.colSurucu_Adi,
            this.colSurucu_Soyadi,
            this.colSurucu_Telefon});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            // 
            // colSurucu_TC
            // 
            this.colSurucu_TC.FieldName = "Surucu_TC";
            this.colSurucu_TC.Name = "colSurucu_TC";
            this.colSurucu_TC.Visible = true;
            this.colSurucu_TC.VisibleIndex = 0;
            // 
            // colSurucu_Adi
            // 
            this.colSurucu_Adi.FieldName = "Surucu_Adi";
            this.colSurucu_Adi.Name = "colSurucu_Adi";
            this.colSurucu_Adi.Visible = true;
            this.colSurucu_Adi.VisibleIndex = 1;
            // 
            // colSurucu_Soyadi
            // 
            this.colSurucu_Soyadi.FieldName = "Surucu_Soyadi";
            this.colSurucu_Soyadi.Name = "colSurucu_Soyadi";
            this.colSurucu_Soyadi.Visible = true;
            this.colSurucu_Soyadi.VisibleIndex = 2;
            // 
            // colSurucu_Telefon
            // 
            this.colSurucu_Telefon.FieldName = "Surucu_Telefon";
            this.colSurucu_Telefon.Name = "colSurucu_Telefon";
            this.colSurucu_Telefon.Visible = true;
            this.colSurucu_Telefon.VisibleIndex = 3;
            // 
            // aracTakipDBDataSet1
            // 
            this.aracTakipDBDataSet1.DataSetName = "AracTakipDBDataSet1";
            this.aracTakipDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // surucuBilgileriBindingSource
            // 
            this.surucuBilgileriBindingSource.DataMember = "Surucu_Bilgileri";
            this.surucuBilgileriBindingSource.DataSource = this.aracTakipDBDataSet1;
            // 
            // surucu_BilgileriTableAdapter
            // 
            this.surucu_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // SoforEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 388);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SoforEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şöför Girişi";
            this.Load += new System.EventHandler(this.SoforEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surucuBilgileriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tel;
        private DevExpress.XtraEditors.TextEdit soyad;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit ad;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSurucu_TC;
        private DevExpress.XtraGrid.Columns.GridColumn colSurucu_Adi;
        private DevExpress.XtraGrid.Columns.GridColumn colSurucu_Soyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colSurucu_Telefon;
        private AracTakipDBDataSet1 aracTakipDBDataSet1;
        private System.Windows.Forms.BindingSource surucuBilgileriBindingSource;
        private AracTakipDBDataSet1TableAdapters.Surucu_BilgileriTableAdapter surucu_BilgileriTableAdapter;
    }
}
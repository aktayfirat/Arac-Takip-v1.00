namespace Arac_Takip_v1._00
{
    partial class Yakit_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yakit_Giris));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.yakit_Alinan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.total_Yakit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.group_plaka = new DevExpress.XtraEditors.GroupControl();
            this.plakaNo_yakit = new System.Windows.Forms.ComboBox();
            this.surucuAdi_yakit = new System.Windows.Forms.ComboBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Yakit_tarih = new DevExpress.XtraEditors.DateEdit();
            this.belgeNo_Yakit = new DevExpress.XtraEditors.TextEdit();
            this.Yakit_Bilgileri = new DevExpress.XtraGrid.GridControl();
            this.yakitGiris = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBelge_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaka_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlinan_Litre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplam_Tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurucu_TC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aracTakipDBDataSet1 = new Arac_Takip_v1._00.AracTakipDBDataSet1();
            this.vYakitBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_YakitBilgileriTableAdapter = new Arac_Takip_v1._00.AracTakipDBDataSet1TableAdapters.v_YakitBilgileriTableAdapter();
            this.vSurucuBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_SurucuBilgileriTableAdapter = new Arac_Takip_v1._00.AracTakipDBDataSet1TableAdapters.v_SurucuBilgileriTableAdapter();
            this.aracBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arac_BilgileriTableAdapter = new Arac_Takip_v1._00.AracTakipDBDataSet1TableAdapters.Arac_BilgileriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yakit_Alinan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_Yakit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_plaka)).BeginInit();
            this.group_plaka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yakit_tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yakit_tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belgeNo_Yakit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yakit_Bilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vYakitBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSurucuBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBilgileriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(44, 41);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Tarih:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(194, 67);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Plaka No:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(188, 41);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Sürücü Adı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 67);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Belge No:";
            // 
            // yakit_Alinan
            // 
            this.yakit_Alinan.Location = new System.Drawing.Point(454, 41);
            this.yakit_Alinan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yakit_Alinan.Name = "yakit_Alinan";
            this.yakit_Alinan.Properties.Mask.EditMask = "f";
            this.yakit_Alinan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.yakit_Alinan.Size = new System.Drawing.Size(95, 20);
            this.yakit_Alinan.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(396, 43);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Alınan Litre:";
            // 
            // total_Yakit
            // 
            this.total_Yakit.Location = new System.Drawing.Point(454, 64);
            this.total_Yakit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.total_Yakit.Name = "total_Yakit";
            this.total_Yakit.Properties.Mask.EditMask = "c";
            this.total_Yakit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.total_Yakit.Size = new System.Drawing.Size(95, 20);
            this.total_Yakit.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(386, 66);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Toplam Tutar:";
            // 
            // group_plaka
            // 
            this.group_plaka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_plaka.Controls.Add(this.plakaNo_yakit);
            this.group_plaka.Controls.Add(this.surucuAdi_yakit);
            this.group_plaka.Controls.Add(this.simpleButton2);
            this.group_plaka.Controls.Add(this.simpleButton1);
            this.group_plaka.Controls.Add(this.Yakit_tarih);
            this.group_plaka.Controls.Add(this.belgeNo_Yakit);
            this.group_plaka.Controls.Add(this.yakit_Alinan);
            this.group_plaka.Controls.Add(this.total_Yakit);
            this.group_plaka.Controls.Add(this.labelControl4);
            this.group_plaka.Controls.Add(this.labelControl1);
            this.group_plaka.Controls.Add(this.labelControl2);
            this.group_plaka.Controls.Add(this.labelControl5);
            this.group_plaka.Controls.Add(this.labelControl3);
            this.group_plaka.Controls.Add(this.labelControl6);
            this.group_plaka.Location = new System.Drawing.Point(9, 10);
            this.group_plaka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.group_plaka.Name = "group_plaka";
            this.group_plaka.Size = new System.Drawing.Size(746, 113);
            this.group_plaka.TabIndex = 12;
            // 
            // plakaNo_yakit
            // 
            this.plakaNo_yakit.DataSource = this.aracBilgileriBindingSource;
            this.plakaNo_yakit.DisplayMember = "Arac_PlakaNo";
            this.plakaNo_yakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plakaNo_yakit.FormattingEnabled = true;
            this.plakaNo_yakit.Location = new System.Drawing.Point(244, 65);
            this.plakaNo_yakit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plakaNo_yakit.Name = "plakaNo_yakit";
            this.plakaNo_yakit.Size = new System.Drawing.Size(108, 21);
            this.plakaNo_yakit.TabIndex = 13;
            this.plakaNo_yakit.ValueMember = "Arac_PlakaNo";
            // 
            // surucuAdi_yakit
            // 
            this.surucuAdi_yakit.DataSource = this.vSurucuBilgileriBindingSource;
            this.surucuAdi_yakit.DisplayMember = "Ad_Soyad";
            this.surucuAdi_yakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surucuAdi_yakit.FormattingEnabled = true;
            this.surucuAdi_yakit.Location = new System.Drawing.Point(244, 37);
            this.surucuAdi_yakit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.surucuAdi_yakit.Name = "surucuAdi_yakit";
            this.surucuAdi_yakit.Size = new System.Drawing.Size(108, 21);
            this.surucuAdi_yakit.TabIndex = 13;
            this.surucuAdi_yakit.ValueMember = "Surucu_TC";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(573, 67);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(76, 32);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Text = "SİL";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(655, 67);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(76, 32);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "EKLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Yakit_tarih
            // 
            this.Yakit_tarih.EditValue = null;
            this.Yakit_tarih.Location = new System.Drawing.Point(77, 41);
            this.Yakit_tarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Yakit_tarih.Name = "Yakit_tarih";
            this.Yakit_tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Yakit_tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Yakit_tarih.Size = new System.Drawing.Size(94, 20);
            this.Yakit_tarih.TabIndex = 11;
            // 
            // belgeNo_Yakit
            // 
            this.belgeNo_Yakit.Location = new System.Drawing.Point(77, 64);
            this.belgeNo_Yakit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.belgeNo_Yakit.Name = "belgeNo_Yakit";
            this.belgeNo_Yakit.Properties.Mask.EditMask = "d";
            this.belgeNo_Yakit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.belgeNo_Yakit.Size = new System.Drawing.Size(95, 20);
            this.belgeNo_Yakit.TabIndex = 4;
            // 
            // Yakit_Bilgileri
            // 
            this.Yakit_Bilgileri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Yakit_Bilgileri.DataSource = this.vYakitBilgileriBindingSource;
            this.Yakit_Bilgileri.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Yakit_Bilgileri.Location = new System.Drawing.Point(10, 128);
            this.Yakit_Bilgileri.MainView = this.yakitGiris;
            this.Yakit_Bilgileri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Yakit_Bilgileri.Name = "Yakit_Bilgileri";
            this.Yakit_Bilgileri.Size = new System.Drawing.Size(746, 228);
            this.Yakit_Bilgileri.TabIndex = 13;
            this.Yakit_Bilgileri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.yakitGiris});
            // 
            // yakitGiris
            // 
            this.yakitGiris.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBelge_No,
            this.colPlaka_No,
            this.colAlinan_Litre,
            this.colToplam_Tutar,
            this.colSurucu_TC,
            this.colTarih});
            this.yakitGiris.GridControl = this.Yakit_Bilgileri;
            this.yakitGiris.Name = "yakitGiris";
            this.yakitGiris.OptionsBehavior.Editable = false;
            // 
            // colBelge_No
            // 
            this.colBelge_No.FieldName = "Belge_No";
            this.colBelge_No.Name = "colBelge_No";
            this.colBelge_No.Visible = true;
            this.colBelge_No.VisibleIndex = 0;
            // 
            // colPlaka_No
            // 
            this.colPlaka_No.FieldName = "Plaka_No";
            this.colPlaka_No.Name = "colPlaka_No";
            this.colPlaka_No.Visible = true;
            this.colPlaka_No.VisibleIndex = 1;
            // 
            // colAlinan_Litre
            // 
            this.colAlinan_Litre.FieldName = "Alinan_Litre";
            this.colAlinan_Litre.Name = "colAlinan_Litre";
            this.colAlinan_Litre.Visible = true;
            this.colAlinan_Litre.VisibleIndex = 2;
            // 
            // colToplam_Tutar
            // 
            this.colToplam_Tutar.FieldName = "Toplam_Tutar";
            this.colToplam_Tutar.Name = "colToplam_Tutar";
            this.colToplam_Tutar.Visible = true;
            this.colToplam_Tutar.VisibleIndex = 3;
            // 
            // colSurucu_TC
            // 
            this.colSurucu_TC.FieldName = "Ad_Soyad";
            this.colSurucu_TC.Name = "colSurucu_TC";
            this.colSurucu_TC.Visible = true;
            this.colSurucu_TC.VisibleIndex = 4;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 5;
            // 
            // aracTakipDBDataSet1
            // 
            this.aracTakipDBDataSet1.DataSetName = "AracTakipDBDataSet1";
            this.aracTakipDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vYakitBilgileriBindingSource
            // 
            this.vYakitBilgileriBindingSource.DataMember = "v_YakitBilgileri";
            this.vYakitBilgileriBindingSource.DataSource = this.aracTakipDBDataSet1;
            // 
            // v_YakitBilgileriTableAdapter
            // 
            this.v_YakitBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // vSurucuBilgileriBindingSource
            // 
            this.vSurucuBilgileriBindingSource.DataMember = "v_SurucuBilgileri";
            this.vSurucuBilgileriBindingSource.DataSource = this.aracTakipDBDataSet1;
            // 
            // v_SurucuBilgileriTableAdapter
            // 
            this.v_SurucuBilgileriTableAdapter.ClearBeforeFill = true;
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
            // Yakit_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 366);
            this.Controls.Add(this.Yakit_Bilgileri);
            this.Controls.Add(this.group_plaka);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Yakit_Giris";
            this.Text = "YakitGiris";
            this.Load += new System.EventHandler(this.YakitGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yakit_Alinan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_Yakit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_plaka)).EndInit();
            this.group_plaka.ResumeLayout(false);
            this.group_plaka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yakit_tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yakit_tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belgeNo_Yakit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yakit_Bilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vYakitBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSurucuBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBilgileriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit yakit_Alinan;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit total_Yakit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl group_plaka;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit Yakit_tarih;
        private DevExpress.XtraEditors.TextEdit belgeNo_Yakit;
        private DevExpress.XtraGrid.GridControl Yakit_Bilgileri;
        private DevExpress.XtraGrid.Views.Grid.GridView yakitGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colBelge_No;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaka_No;
        private DevExpress.XtraGrid.Columns.GridColumn colAlinan_Litre;
        private DevExpress.XtraGrid.Columns.GridColumn colToplam_Tutar;
        private DevExpress.XtraGrid.Columns.GridColumn colSurucu_TC;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private System.Windows.Forms.ComboBox plakaNo_yakit;
        private System.Windows.Forms.ComboBox surucuAdi_yakit;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private AracTakipDBDataSet1 aracTakipDBDataSet1;
        private System.Windows.Forms.BindingSource vYakitBilgileriBindingSource;
        private AracTakipDBDataSet1TableAdapters.v_YakitBilgileriTableAdapter v_YakitBilgileriTableAdapter;
        private System.Windows.Forms.BindingSource vSurucuBilgileriBindingSource;
        private AracTakipDBDataSet1TableAdapters.v_SurucuBilgileriTableAdapter v_SurucuBilgileriTableAdapter;
        private System.Windows.Forms.BindingSource aracBilgileriBindingSource;
        private AracTakipDBDataSet1TableAdapters.Arac_BilgileriTableAdapter arac_BilgileriTableAdapter;
    }
}
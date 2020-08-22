namespace Arac_Takip_v1._00
{
    partial class Rapor
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIs_Ortagı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGidilen_Sehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonus_Km = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.aracTakipDBDataSet1 = new Arac_Takip_v1._00.AracTakipDBDataSet1();
            this.vSurucuBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_SurucuBilgileriTableAdapter = new Arac_Takip_v1._00.AracTakipDBDataSet1TableAdapters.v_SurucuBilgileriTableAdapter();
            this.aracBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arac_BilgileriTableAdapter = new Arac_Takip_v1._00.AracTakipDBDataSet1TableAdapters.Arac_BilgileriTableAdapter();
            this.vFaturaBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_FaturaBilgisiTableAdapter = new Arac_Takip_v1._00.AracTakipDBDataSet1TableAdapters.v_FaturaBilgisiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSurucuBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFaturaBilgisiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vSurucuBilgileriBindingSource;
            this.comboBox1.DisplayMember = "Ad_Soyad";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Surucu_TC";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.dateEdit2);
            this.groupControl1.Controls.Add(this.dateEdit1);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.comboBox2);
            this.groupControl1.Controls.Add(this.comboBox1);
            this.groupControl1.Location = new System.Drawing.Point(9, 19);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(273, 282);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(146, 158);
            this.dateEdit2.Margin = new System.Windows.Forms.Padding(2);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(85, 20);
            this.dateEdit2.TabIndex = 2;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(17, 158);
            this.dateEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(85, 20);
            this.dateEdit1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tarih Aralığı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plaka  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surucu Adı :";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.aracBilgileriBindingSource;
            this.comboBox2.DisplayMember = "Arac_PlakaNo";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(103, 72);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.ValueMember = "Arac_PlakaNo";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vFaturaBilgisiBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(311, 19);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(750, 282);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIs_Ortagı,
            this.colGidilen_Sehir,
            this.colDonus_Km,
            this.colTarih});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIs_Ortagı
            // 
            this.colIs_Ortagı.FieldName = "Is_Ortagı";
            this.colIs_Ortagı.Name = "colIs_Ortagı";
            this.colIs_Ortagı.Visible = true;
            this.colIs_Ortagı.VisibleIndex = 0;
            // 
            // colGidilen_Sehir
            // 
            this.colGidilen_Sehir.FieldName = "Gidilen_Sehir";
            this.colGidilen_Sehir.Name = "colGidilen_Sehir";
            this.colGidilen_Sehir.Visible = true;
            this.colGidilen_Sehir.VisibleIndex = 1;
            // 
            // colDonus_Km
            // 
            this.colDonus_Km.FieldName = "Donus_Km";
            this.colDonus_Km.Name = "colDonus_Km";
            this.colDonus_Km.Visible = true;
            this.colDonus_Km.VisibleIndex = 2;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(502, 308);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 22);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Toplam Mesafe :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(437, 349);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(213, 22);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Toplam Yakıt Tüketimi :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(542, 390);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 22);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Yapılam İş :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(499, 429);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(150, 22);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Gidilen Şehirler :";
            // 
            // aracTakipDBDataSet1
            // 
            this.aracTakipDBDataSet1.DataSetName = "AracTakipDBDataSet1";
            this.aracTakipDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // vFaturaBilgisiBindingSource
            // 
            this.vFaturaBilgisiBindingSource.DataMember = "v_FaturaBilgisi";
            this.vFaturaBilgisiBindingSource.DataSource = this.aracTakipDBDataSet1;
            // 
            // v_FaturaBilgisiTableAdapter
            // 
            this.v_FaturaBilgisiTableAdapter.ClearBeforeFill = true;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 471);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Rapor";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSurucuBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFaturaBilgisiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Ortagı;
        private DevExpress.XtraGrid.Columns.GridColumn colGidilen_Sehir;
        private DevExpress.XtraGrid.Columns.GridColumn colDonus_Km;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private AracTakipDBDataSet1 aracTakipDBDataSet1;
        private System.Windows.Forms.BindingSource vSurucuBilgileriBindingSource;
        private AracTakipDBDataSet1TableAdapters.v_SurucuBilgileriTableAdapter v_SurucuBilgileriTableAdapter;
        private System.Windows.Forms.BindingSource aracBilgileriBindingSource;
        private AracTakipDBDataSet1TableAdapters.Arac_BilgileriTableAdapter arac_BilgileriTableAdapter;
        private System.Windows.Forms.BindingSource vFaturaBilgisiBindingSource;
        private AracTakipDBDataSet1TableAdapters.v_FaturaBilgisiTableAdapter v_FaturaBilgisiTableAdapter;
    }
}
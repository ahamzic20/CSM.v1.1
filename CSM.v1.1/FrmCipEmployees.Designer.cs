namespace CSM.v1._1
{
    partial class FrmCipEmployees
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
            this.dgvCipEmployees = new System.Windows.Forms.DataGridView();
            this.foiEmployeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CSM.v1._1.DataSet1();
            this.sourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sourceTableAdapter = new CSM.v1._1.DataSet1TableAdapters.SourceTableAdapter();
            this.foiEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foiEmployeesTableAdapter = new CSM.v1._1.DataSet1TableAdapters.FoiEmployeesTableAdapter();
            this.cipEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cipEmployeesTableAdapter = new CSM.v1._1.DataSet1TableAdapters.CipEmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCipEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foiEmployeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foiEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cipEmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCipEmployees
            // 
            this.dgvCipEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCipEmployees.Location = new System.Drawing.Point(12, 12);
            this.dgvCipEmployees.Name = "dgvCipEmployees";
            this.dgvCipEmployees.RowHeadersWidth = 51;
            this.dgvCipEmployees.Size = new System.Drawing.Size(1094, 384);
            this.dgvCipEmployees.TabIndex = 0;
            // 
            // foiEmployeesBindingSource1
            // 
            this.foiEmployeesBindingSource1.DataMember = "FoiEmployees";
            this.foiEmployeesBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sourceBindingSource
            // 
            this.sourceBindingSource.DataMember = "Source";
            this.sourceBindingSource.DataSource = this.dataSet1;
            // 
            // sourceTableAdapter
            // 
            this.sourceTableAdapter.ClearBeforeFill = true;
            // 
            // foiEmployeesBindingSource
            // 
            this.foiEmployeesBindingSource.DataMember = "FoiEmployees";
            this.foiEmployeesBindingSource.DataSource = this.dataSet1;
            // 
            // foiEmployeesTableAdapter
            // 
            this.foiEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // cipEmployeesBindingSource
            // 
            this.cipEmployeesBindingSource.DataMember = "CipEmployees";
            this.cipEmployeesBindingSource.DataSource = this.dataSet1;
            // 
            // cipEmployeesTableAdapter
            // 
            this.cipEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCipEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 465);
            this.Controls.Add(this.dgvCipEmployees);
            this.Name = "FrmCipEmployees";
            this.Text = "FrmCipEmployees";
            this.Load += new System.EventHandler(this.FrmCipEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCipEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foiEmployeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foiEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cipEmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCipEmployees;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sourceBindingSource;
        private DataSet1TableAdapters.SourceTableAdapter sourceTableAdapter;
        private System.Windows.Forms.BindingSource foiEmployeesBindingSource;
        private DataSet1TableAdapters.FoiEmployeesTableAdapter foiEmployeesTableAdapter;
        private System.Windows.Forms.BindingSource foiEmployeesBindingSource1;
        private System.Windows.Forms.BindingSource cipEmployeesBindingSource;
        private DataSet1TableAdapters.CipEmployeesTableAdapter cipEmployeesTableAdapter;
    }
}
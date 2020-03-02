namespace Calidad.Vuelos
{
    partial class Consultar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoEstebanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoEstebanDataSet = new Calidad.proyectoEstebanDataSet();
            this.vueloTableAdapter = new Calidad.proyectoEstebanDataSetTableAdapters.VueloTableAdapter();
            this.botonRegresar = new System.Windows.Forms.Button();
            this.vueloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compañiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasemanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadmaximaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoEstebanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoEstebanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.compañiaDataGridViewTextBoxColumn,
            this.diasemanaDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.capacidadmaximaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vueloBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 640);
            this.dataGridView1.TabIndex = 0;
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataMember = "Vuelo";
            this.vueloBindingSource.DataSource = this.proyectoEstebanDataSetBindingSource;
            // 
            // proyectoEstebanDataSetBindingSource
            // 
            this.proyectoEstebanDataSetBindingSource.DataSource = this.proyectoEstebanDataSet;
            this.proyectoEstebanDataSetBindingSource.Position = 0;
            // 
            // proyectoEstebanDataSet
            // 
            this.proyectoEstebanDataSet.DataSetName = "proyectoEstebanDataSet";
            this.proyectoEstebanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueloTableAdapter
            // 
            this.vueloTableAdapter.ClearBeforeFill = true;
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(262, 658);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(75, 23);
            this.botonRegresar.TabIndex = 1;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // vueloBindingSource1
            // 
            this.vueloBindingSource1.DataMember = "Vuelo";
            this.vueloBindingSource1.DataSource = this.proyectoEstebanDataSetBindingSource;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compañiaDataGridViewTextBoxColumn
            // 
            this.compañiaDataGridViewTextBoxColumn.DataPropertyName = "compañia";
            this.compañiaDataGridViewTextBoxColumn.HeaderText = "compañia";
            this.compañiaDataGridViewTextBoxColumn.Name = "compañiaDataGridViewTextBoxColumn";
            this.compañiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasemanaDataGridViewTextBoxColumn
            // 
            this.diasemanaDataGridViewTextBoxColumn.DataPropertyName = "dia_semana";
            this.diasemanaDataGridViewTextBoxColumn.HeaderText = "dia_semana";
            this.diasemanaDataGridViewTextBoxColumn.Name = "diasemanaDataGridViewTextBoxColumn";
            this.diasemanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacidadmaximaDataGridViewTextBoxColumn
            // 
            this.capacidadmaximaDataGridViewTextBoxColumn.DataPropertyName = "capacidad_maxima";
            this.capacidadmaximaDataGridViewTextBoxColumn.HeaderText = "capacidad_maxima";
            this.capacidadmaximaDataGridViewTextBoxColumn.Name = "capacidadmaximaDataGridViewTextBoxColumn";
            this.capacidadmaximaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 684);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoEstebanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoEstebanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource proyectoEstebanDataSetBindingSource;
        private proyectoEstebanDataSet proyectoEstebanDataSet;
        private System.Windows.Forms.BindingSource vueloBindingSource;
        private proyectoEstebanDataSetTableAdapters.VueloTableAdapter vueloTableAdapter;
        private System.Windows.Forms.Button botonRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compañiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasemanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadmaximaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vueloBindingSource1;
    }
}
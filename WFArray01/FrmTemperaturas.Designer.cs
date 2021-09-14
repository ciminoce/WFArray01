
namespace WFArray01
{
    partial class FrmTemperaturas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.TemperaturaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EstadisticasPanel = new System.Windows.Forms.Panel();
            this.MayorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MenorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PromedioLabel = new System.Windows.Forms.Label();
            this.MostrarEstadisticasButton = new System.Windows.Forms.Button();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colCelsius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFahrenheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReaumur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GuardarDatosButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.EstadisticasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CancelarButton);
            this.splitContainer1.Panel1.Controls.Add(this.OKButton);
            this.splitContainer1.Panel1.Controls.Add(this.TemperaturaTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.EstadisticasPanel);
            this.splitContainer1.Panel2.Controls.Add(this.GuardarDatosButton);
            this.splitContainer1.Panel2.Controls.Add(this.MostrarEstadisticasButton);
            this.splitContainer1.Panel2.Controls.Add(this.DatosDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(603, 613);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(207, 96);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(90, 64);
            this.CancelarButton.TabIndex = 2;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(46, 96);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 64);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TemperaturaTextBox
            // 
            this.TemperaturaTextBox.Location = new System.Drawing.Point(113, 47);
            this.TemperaturaTextBox.Name = "TemperaturaTextBox";
            this.TemperaturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.TemperaturaTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temeratura:";
            // 
            // EstadisticasPanel
            // 
            this.EstadisticasPanel.Controls.Add(this.MayorLabel);
            this.EstadisticasPanel.Controls.Add(this.label4);
            this.EstadisticasPanel.Controls.Add(this.label3);
            this.EstadisticasPanel.Controls.Add(this.MenorLabel);
            this.EstadisticasPanel.Controls.Add(this.label5);
            this.EstadisticasPanel.Controls.Add(this.label2);
            this.EstadisticasPanel.Controls.Add(this.PromedioLabel);
            this.EstadisticasPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EstadisticasPanel.Location = new System.Drawing.Point(0, 328);
            this.EstadisticasPanel.Name = "EstadisticasPanel";
            this.EstadisticasPanel.Size = new System.Drawing.Size(603, 100);
            this.EstadisticasPanel.TabIndex = 4;
            // 
            // MayorLabel
            // 
            this.MayorLabel.AutoSize = true;
            this.MayorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayorLabel.Location = new System.Drawing.Point(70, 56);
            this.MayorLabel.Name = "MayorLabel";
            this.MayorLabel.Size = new System.Drawing.Size(0, 13);
            this.MayorLabel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mayor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // MenorLabel
            // 
            this.MenorLabel.AutoSize = true;
            this.MenorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenorLabel.Location = new System.Drawing.Point(300, 13);
            this.MenorLabel.Name = "MenorLabel";
            this.MenorLabel.Size = new System.Drawing.Size(0, 13);
            this.MenorLabel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Menor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Promedio:";
            // 
            // PromedioLabel
            // 
            this.PromedioLabel.AutoSize = true;
            this.PromedioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromedioLabel.Location = new System.Drawing.Point(85, 13);
            this.PromedioLabel.Name = "PromedioLabel";
            this.PromedioLabel.Size = new System.Drawing.Size(0, 13);
            this.PromedioLabel.TabIndex = 3;
            // 
            // MostrarEstadisticasButton
            // 
            this.MostrarEstadisticasButton.Location = new System.Drawing.Point(504, 33);
            this.MostrarEstadisticasButton.Name = "MostrarEstadisticasButton";
            this.MostrarEstadisticasButton.Size = new System.Drawing.Size(87, 56);
            this.MostrarEstadisticasButton.TabIndex = 1;
            this.MostrarEstadisticasButton.Text = "Estadísticas";
            this.MostrarEstadisticasButton.UseVisualStyleBackColor = true;
            this.MostrarEstadisticasButton.Click += new System.EventHandler(this.MostrarEstadisticasButton_Click);
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCelsius,
            this.colFahrenheit,
            this.colReaumur,
            this.colEditar,
            this.colBorrar});
            this.DatosDataGridView.Location = new System.Drawing.Point(12, 33);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(464, 257);
            this.DatosDataGridView.TabIndex = 0;
            this.DatosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosDataGridView_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // colCelsius
            // 
            this.colCelsius.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCelsius.HeaderText = "Celsius";
            this.colCelsius.Name = "colCelsius";
            this.colCelsius.ReadOnly = true;
            // 
            // colFahrenheit
            // 
            this.colFahrenheit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFahrenheit.HeaderText = "Fahrenheit";
            this.colFahrenheit.Name = "colFahrenheit";
            this.colFahrenheit.ReadOnly = true;
            // 
            // colReaumur
            // 
            this.colReaumur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReaumur.HeaderText = "Reaumur";
            this.colReaumur.Name = "colReaumur";
            this.colReaumur.ReadOnly = true;
            // 
            // colEditar
            // 
            this.colEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEditar.HeaderText = "";
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Text = "Editar";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Width = 5;
            // 
            // colBorrar
            // 
            this.colBorrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBorrar.HeaderText = "";
            this.colBorrar.Name = "colBorrar";
            this.colBorrar.ReadOnly = true;
            this.colBorrar.Text = "Borrar";
            this.colBorrar.UseColumnTextForButtonValue = true;
            this.colBorrar.Width = 5;
            // 
            // GuardarDatosButton
            // 
            this.GuardarDatosButton.Location = new System.Drawing.Point(504, 95);
            this.GuardarDatosButton.Name = "GuardarDatosButton";
            this.GuardarDatosButton.Size = new System.Drawing.Size(87, 56);
            this.GuardarDatosButton.TabIndex = 1;
            this.GuardarDatosButton.Text = "Guardar Datos";
            this.GuardarDatosButton.UseVisualStyleBackColor = true;
            this.GuardarDatosButton.Click += new System.EventHandler(this.GuardarDatosButton_Click);
            // 
            // FrmTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 613);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmTemperaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTemperaturas";
            this.Load += new System.EventHandler(this.FrmTemperaturas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.EstadisticasPanel.ResumeLayout(false);
            this.EstadisticasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox TemperaturaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label PromedioLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MostrarEstadisticasButton;
        private System.Windows.Forms.Panel EstadisticasPanel;
        private System.Windows.Forms.Label MayorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MenorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelsius;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFahrenheit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReaumur;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colBorrar;
        private System.Windows.Forms.Button GuardarDatosButton;
    }
}
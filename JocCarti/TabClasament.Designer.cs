namespace JocCarti
{
    partial class TabClasament
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabClasament));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelaClasamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasamentBazaDeDateDataSet = new JocCarti.ClasamentBazaDeDateDataSet();
            this.tabelaClasamentTableAdapter = new JocCarti.ClasamentBazaDeDateDataSetTableAdapters.TabelaClasamentTableAdapter();
            this.BackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClasamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBazaDeDateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.tabelaClasamentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(684, 564);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_4);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NUME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NUME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SCOR";
            this.dataGridViewTextBoxColumn3.HeaderText = "SCOR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tabelaClasamentBindingSource
            // 
            this.tabelaClasamentBindingSource.DataMember = "TabelaClasament";
            this.tabelaClasamentBindingSource.DataSource = this.clasamentBazaDeDateDataSet;
            // 
            // clasamentBazaDeDateDataSet
            // 
            this.clasamentBazaDeDateDataSet.DataSetName = "ClasamentBazaDeDateDataSet";
            this.clasamentBazaDeDateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelaClasamentTableAdapter
            // 
            this.tabelaClasamentTableAdapter.ClearBeforeFill = true;
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.Color.Silver;
            this.BackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMenu.ForeColor = System.Drawing.Color.Black;
            this.BackToMenu.Location = new System.Drawing.Point(0, 561);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(684, 100);
            this.BackToMenu.TabIndex = 18;
            this.BackToMenu.Text = "Back To Menu";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // TabClasament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TabClasament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabClasament";
            this.Load += new System.EventHandler(this.TabClasament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClasamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBazaDeDateDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private ClasamentBazaDeDateDataSet clasamentBazaDeDateDataSet;
        private System.Windows.Forms.BindingSource tabelaClasamentBindingSource;
        private ClasamentBazaDeDateDataSetTableAdapters.TabelaClasamentTableAdapter tabelaClasamentTableAdapter;
        private System.Windows.Forms.Button BackToMenu;

    }
}
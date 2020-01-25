namespace Stock
{
    partial class UpOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpOut));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.itemsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.newDataSet12 = new Stock.NewDataSet12();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtqu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.newDataSet15 = new Stock.NewDataSet15();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newDataSet6 = new Stock.NewDataSet6();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Stock.NewDataSet6TableAdapters.ItemsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.newDataSet8 = new Stock.NewDataSet8();
            this.outgoingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outgoingTableAdapter = new Stock.NewDataSet8TableAdapters.OutgoingTableAdapter();
            this.newDataSet9 = new Stock.NewDataSet9();
            this.itemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter1 = new Stock.NewDataSet9TableAdapters.ItemsTableAdapter();
            this.itemsTableAdapter2 = new Stock.NewDataSet12TableAdapters.ItemsTableAdapter();
            this.itemsTableAdapter3 = new Stock.NewDataSet15TableAdapters.ItemsTableAdapter();
            this.cmb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1220, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 90);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1220, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 90);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // itemsBindingSource3
            // 
            this.itemsBindingSource3.DataMember = "Items";
            this.itemsBindingSource3.DataSource = this.newDataSet12;
            // 
            // newDataSet12
            // 
            this.newDataSet12.DataSetName = "NewDataSet12";
            this.newDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtqu
            // 
            this.txtqu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtqu.Location = new System.Drawing.Point(856, 110);
            this.txtqu.Name = "txtqu";
            this.txtqu.Size = new System.Drawing.Size(124, 22);
            this.txtqu.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.itemsBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(36, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1100, 550);
            this.dataGridView1.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // itemsBindingSource4
            // 
            this.itemsBindingSource4.DataMember = "Items";
            this.itemsBindingSource4.DataSource = this.newDataSet15;
            // 
            // newDataSet15
            // 
            this.newDataSet15.DataSetName = "NewDataSet15";
            this.newDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(418, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 75);
            this.label3.TabIndex = 8;
            this.label3.Text = "SAGARA TRADERS";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(749, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(393, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item ID";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(1204, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Update Outgoing";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(1225, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Main Menu";
            // 
            // newDataSet6
            // 
            this.newDataSet6.DataSetName = "NewDataSet6";
            this.newDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.newDataSet6;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1208, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // newDataSet8
            // 
            this.newDataSet8.DataSetName = "NewDataSet8";
            this.newDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outgoingBindingSource
            // 
            this.outgoingBindingSource.DataMember = "Outgoing";
            this.outgoingBindingSource.DataSource = this.newDataSet8;
            // 
            // outgoingTableAdapter
            // 
            this.outgoingTableAdapter.ClearBeforeFill = true;
            // 
            // newDataSet9
            // 
            this.newDataSet9.DataSetName = "NewDataSet9";
            this.newDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource2
            // 
            this.itemsBindingSource2.DataMember = "Items";
            this.itemsBindingSource2.DataSource = this.newDataSet9;
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // itemsTableAdapter2
            // 
            this.itemsTableAdapter2.ClearBeforeFill = true;
            // 
            // itemsTableAdapter3
            // 
            this.itemsTableAdapter3.ClearBeforeFill = true;
            // 
            // cmb
            // 
            this.cmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb.Location = new System.Drawing.Point(489, 110);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(179, 22);
            this.cmb.TabIndex = 28;
            // 
            // UpOut
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtqu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Outgoing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outgoingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        //private Stock_DBDataSet5 stock_DBDataSet5;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        //private Stock_DBDataSet5TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.TextBox txtqu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private NewDataSet6 newDataSet6;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private NewDataSet6TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Button button3;
        private NewDataSet8 newDataSet8;
        private System.Windows.Forms.BindingSource outgoingBindingSource;
        private NewDataSet8TableAdapters.OutgoingTableAdapter outgoingTableAdapter;
        private NewDataSet9 newDataSet9;
        private System.Windows.Forms.BindingSource itemsBindingSource2;
        private NewDataSet9TableAdapters.ItemsTableAdapter itemsTableAdapter1;
        private NewDataSet12 newDataSet12;
        private System.Windows.Forms.BindingSource itemsBindingSource3;
        private NewDataSet12TableAdapters.ItemsTableAdapter itemsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private NewDataSet15 newDataSet15;
        private System.Windows.Forms.BindingSource itemsBindingSource4;
        private NewDataSet15TableAdapters.ItemsTableAdapter itemsTableAdapter3;
        private System.Windows.Forms.TextBox cmb;
    }
}
namespace Zadatak1_2.Forme
{
    partial class PorudzbinaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.order_list = new System.Windows.Forms.ListBox();
            this.btn_kreiraj = new System.Windows.Forms.Button();
            this.btn_uloni = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.knjigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Zadatak1_2.DataSet1();
            this.knjigaTableAdapter = new Zadatak1_2.DataSet1TableAdapters.KnjigaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // order_list
            // 
            this.order_list.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_list.FormattingEnabled = true;
            this.order_list.ItemHeight = 18;
            this.order_list.Location = new System.Drawing.Point(483, 11);
            this.order_list.Margin = new System.Windows.Forms.Padding(2);
            this.order_list.Name = "order_list";
            this.order_list.Size = new System.Drawing.Size(259, 202);
            this.order_list.TabIndex = 21;
            // 
            // btn_kreiraj
            // 
            this.btn_kreiraj.Location = new System.Drawing.Point(262, 422);
            this.btn_kreiraj.Name = "btn_kreiraj";
            this.btn_kreiraj.Size = new System.Drawing.Size(262, 76);
            this.btn_kreiraj.TabIndex = 20;
            this.btn_kreiraj.Text = "Kreiraj narudzbenicu";
            this.btn_kreiraj.UseVisualStyleBackColor = true;
            this.btn_kreiraj.Click += new System.EventHandler(this.btn_kreiraj_Click);
            // 
            // btn_uloni
            // 
            this.btn_uloni.Location = new System.Drawing.Point(667, 269);
            this.btn_uloni.Name = "btn_uloni";
            this.btn_uloni.Size = new System.Drawing.Size(75, 23);
            this.btn_uloni.TabIndex = 19;
            this.btn_uloni.Text = "ukloni";
            this.btn_uloni.UseVisualStyleBackColor = true;
            this.btn_uloni.Click += new System.EventHandler(this.btn_uloni_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(332, 110);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "dodaj";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.knjigaBindingSource;
            this.listBox1.DisplayMember = "naziv";
            this.listBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(21, 11);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 328);
            this.listBox1.TabIndex = 23;
            this.listBox1.ValueMember = "Id";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // knjigaBindingSource
            // 
            this.knjigaBindingSource.DataMember = "Knjiga";
            this.knjigaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knjigaTableAdapter
            // 
            this.knjigaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 25;
            // 
            // PorudzbinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order_list);
            this.Controls.Add(this.btn_kreiraj);
            this.Controls.Add(this.btn_uloni);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listBox1);
            this.Name = "PorudzbinaForm";
            this.Text = "PorudzbinaForm";
            this.Load += new System.EventHandler(this.PorudzbinaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knjigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox order_list;
        private System.Windows.Forms.Button btn_kreiraj;
        private System.Windows.Forms.Button btn_uloni;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox listBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource knjigaBindingSource;
        private DataSet1TableAdapters.KnjigaTableAdapter knjigaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace Coba_Module
{
    partial class FrmPromotion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDepature = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjoblvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Location = new System.Drawing.Point(11, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(381, 127);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avalible Job Mutation";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDepartment,
            this.cPosition,
            this.cjoblvl,
            this.cAction});
            this.DGV.Location = new System.Drawing.Point(16, 16);
            this.DGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(345, 98);
            this.DGV.TabIndex = 10;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtjob
            // 
            this.txtjob.Location = new System.Drawing.Point(119, 195);
            this.txtjob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtjob.Name = "txtjob";
            this.txtjob.ReadOnly = true;
            this.txtjob.Size = new System.Drawing.Size(254, 20);
            this.txtjob.TabIndex = 21;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(119, 151);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(254, 20);
            this.txtPosition.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 79);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(254, 20);
            this.txtName.TabIndex = 19;
            // 
            // txtDepature
            // 
            this.txtDepature.Location = new System.Drawing.Point(119, 113);
            this.txtDepature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDepature.Name = "txtDepature";
            this.txtDepature.ReadOnly = true;
            this.txtDepature.Size = new System.Drawing.Size(254, 20);
            this.txtDepature.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Current Depature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Current Job Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Current Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Promotion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cDepartment
            // 
            this.cDepartment.DataPropertyName = "Department";
            this.cDepartment.HeaderText = "Department";
            this.cDepartment.MinimumWidth = 8;
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.ReadOnly = true;
            this.cDepartment.Width = 150;
            // 
            // cPosition
            // 
            this.cPosition.DataPropertyName = "Position";
            this.cPosition.HeaderText = "Position";
            this.cPosition.MinimumWidth = 8;
            this.cPosition.Name = "cPosition";
            this.cPosition.ReadOnly = true;
            this.cPosition.Width = 150;
            // 
            // cjoblvl
            // 
            this.cjoblvl.DataPropertyName = "joblvl";
            this.cjoblvl.HeaderText = "";
            this.cjoblvl.MinimumWidth = 8;
            this.cjoblvl.Name = "cjoblvl";
            this.cjoblvl.ReadOnly = true;
            this.cjoblvl.Visible = false;
            this.cjoblvl.Width = 150;
            // 
            // cAction
            // 
            this.cAction.HeaderText = "Action";
            this.cAction.MinimumWidth = 8;
            this.cAction.Name = "cAction";
            this.cAction.ReadOnly = true;
            this.cAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cAction.Text = "Apply";
            this.cAction.UseColumnTextForButtonValue = true;
            this.cAction.Width = 150;
            // 
            // FrmPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtjob);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDepature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPromotion";
            this.Text = "FrmPromotion";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtjob;
        public System.Windows.Forms.TextBox txtPosition;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtDepature;
        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjoblvl;
        private System.Windows.Forms.DataGridViewButtonColumn cAction;
    }
}
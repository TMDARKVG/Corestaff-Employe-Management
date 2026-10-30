namespace Coba_Module
{
    partial class FrmMutation
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.cDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mutation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Job Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Current Depature";
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(115, 118);
            this.txtDep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDep.Name = "txtDep";
            this.txtDep.ReadOnly = true;
            this.txtDep.Size = new System.Drawing.Size(254, 20);
            this.txtDep.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(254, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(115, 157);
            this.txtPos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPos.Name = "txtPos";
            this.txtPos.ReadOnly = true;
            this.txtPos.Size = new System.Drawing.Size(254, 20);
            this.txtPos.TabIndex = 8;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(115, 200);
            this.txtJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJob.Name = "txtJob";
            this.txtJob.ReadOnly = true;
            this.txtJob.Size = new System.Drawing.Size(254, 20);
            this.txtJob.TabIndex = 9;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDepartment,
            this.cPosition,
            this.cid,
            this.cAction});
            this.DGV.Location = new System.Drawing.Point(17, 16);
            this.DGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(343, 98);
            this.DGV.TabIndex = 10;
            // 
            // cDepartment
            // 
            this.cDepartment.DataPropertyName = "name";
            this.cDepartment.HeaderText = "Department";
            this.cDepartment.MinimumWidth = 8;
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.ReadOnly = true;
            this.cDepartment.Width = 150;
            // 
            // cPosition
            // 
            this.cPosition.DataPropertyName = "tes";
            this.cPosition.HeaderText = "Position";
            this.cPosition.MinimumWidth = 8;
            this.cPosition.Name = "cPosition";
            this.cPosition.ReadOnly = true;
            this.cPosition.Width = 150;
            // 
            // cid
            // 
            this.cid.DataPropertyName = "job_level_id";
            this.cid.HeaderText = "";
            this.cid.MinimumWidth = 8;
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            this.cid.Visible = false;
            this.cid.Width = 150;
            // 
            // cAction
            // 
            this.cAction.HeaderText = "Action";
            this.cAction.MinimumWidth = 8;
            this.cAction.Name = "cAction";
            this.cAction.ReadOnly = true;
            this.cAction.Text = "Apply";
            this.cAction.UseColumnTextForButtonValue = true;
            this.cAction.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Location = new System.Drawing.Point(8, 221);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(381, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avalible Job Mutation";
            // 
            // FrmMutation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMutation";
            this.Text = "FrmMutation";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtDep;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtPos;
        public System.Windows.Forms.TextBox txtJob;
        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewButtonColumn cAction;
    }
}
namespace DataStructures_Lab1
{
    partial class CensusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblProvVals = new System.Windows.Forms.Label();
            this.lblRegVals = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkIncludeNoPop = new System.Windows.Forms.CheckBox();
            this.grpExport = new System.Windows.Forms.GroupBox();
            this.lblPopVals = new System.Windows.Forms.Label();
            this.grpExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Census Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Province ID";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(120, 88);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(145, 22);
            this.txtProvince.TabIndex = 2;
            // 
            // lblProvVals
            // 
            this.lblProvVals.AutoSize = true;
            this.lblProvVals.Location = new System.Drawing.Point(281, 91);
            this.lblProvVals.Name = "lblProvVals";
            this.lblProvVals.Size = new System.Drawing.Size(55, 17);
            this.lblProvVals.TabIndex = 3;
            this.lblProvVals.Text = "(0 - 12)";
            // 
            // lblRegVals
            // 
            this.lblRegVals.AutoSize = true;
            this.lblRegVals.Location = new System.Drawing.Point(281, 139);
            this.lblRegVals.Name = "lblRegVals";
            this.lblRegVals.Size = new System.Drawing.Size(55, 17);
            this.lblRegVals.TabIndex = 6;
            this.lblRegVals.Text = "(0 - 47)";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(120, 136);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(145, 22);
            this.txtRegion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Region ID";
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(120, 187);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(145, 22);
            this.txtPopulation.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Population";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(203, 248);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 30);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(15, 248);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(168, 30);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(16, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.Location = new System.Drawing.Point(204, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 30);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // chkIncludeNoPop
            // 
            this.chkIncludeNoPop.AutoSize = true;
            this.chkIncludeNoPop.Checked = true;
            this.chkIncludeNoPop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeNoPop.Location = new System.Drawing.Point(16, 79);
            this.chkIncludeNoPop.Name = "chkIncludeNoPop";
            this.chkIncludeNoPop.Size = new System.Drawing.Size(321, 21);
            this.chkIncludeNoPop.TabIndex = 14;
            this.chkIncludeNoPop.Text = "Include rows with no population data on export";
            this.chkIncludeNoPop.UseVisualStyleBackColor = true;
            // 
            // grpExport
            // 
            this.grpExport.BackColor = System.Drawing.SystemColors.Control;
            this.grpExport.Controls.Add(this.btnSave);
            this.grpExport.Controls.Add(this.chkIncludeNoPop);
            this.grpExport.Controls.Add(this.btnClear);
            this.grpExport.Location = new System.Drawing.Point(-1, 306);
            this.grpExport.Name = "grpExport";
            this.grpExport.Size = new System.Drawing.Size(378, 130);
            this.grpExport.TabIndex = 15;
            this.grpExport.TabStop = false;
            // 
            // lblPopVals
            // 
            this.lblPopVals.AutoSize = true;
            this.lblPopVals.Location = new System.Drawing.Point(281, 187);
            this.lblPopVals.Name = "lblPopVals";
            this.lblPopVals.Size = new System.Drawing.Size(38, 17);
            this.lblPopVals.TabIndex = 16;
            this.lblPopVals.Text = "(< 0)";
            // 
            // CensusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(371, 431);
            this.Controls.Add(this.lblPopVals);
            this.Controls.Add(this.grpExport);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtPopulation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRegVals);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProvVals);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CensusForm";
            this.ShowIcon = false;
            this.Text = "Census";
            this.grpExport.ResumeLayout(false);
            this.grpExport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblProvVals;
        private System.Windows.Forms.Label lblRegVals;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkIncludeNoPop;
        private System.Windows.Forms.GroupBox grpExport;
        private System.Windows.Forms.Label lblPopVals;
    }
}


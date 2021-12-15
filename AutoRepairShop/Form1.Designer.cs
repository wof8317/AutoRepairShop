
namespace AutoRepairShop
{
    partial class Form1
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
            this.grpOilAndLube = new System.Windows.Forms.GroupBox();
            this.chkBxLube = new System.Windows.Forms.CheckBox();
            this.chkBxOil = new System.Windows.Forms.CheckBox();
            this.grpFlushes = new System.Windows.Forms.GroupBox();
            this.chkBxTransmission = new System.Windows.Forms.CheckBox();
            this.chkBxRadiator = new System.Windows.Forms.CheckBox();
            this.grpMisc = new System.Windows.Forms.GroupBox();
            this.chkBxTireRotation = new System.Windows.Forms.CheckBox();
            this.chkBxMuffler = new System.Windows.Forms.CheckBox();
            this.chkBxInspection = new System.Windows.Forms.CheckBox();
            this.grpPartsAndLabor = new System.Windows.Forms.GroupBox();
            this.lblLaborPerHour = new System.Windows.Forms.Label();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.lblLabor = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.txtTotalFees = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSumParts = new System.Windows.Forms.TextBox();
            this.txtServicesAndLabor = new System.Windows.Forms.TextBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSumParts = new System.Windows.Forms.Label();
            this.lblServicesAndLabor = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOilAndLube.SuspendLayout();
            this.grpFlushes.SuspendLayout();
            this.grpMisc.SuspendLayout();
            this.grpPartsAndLabor.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOilAndLube
            // 
            this.grpOilAndLube.Controls.Add(this.chkBxLube);
            this.grpOilAndLube.Controls.Add(this.chkBxOil);
            this.grpOilAndLube.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOilAndLube.Location = new System.Drawing.Point(27, 59);
            this.grpOilAndLube.Name = "grpOilAndLube";
            this.grpOilAndLube.Size = new System.Drawing.Size(335, 80);
            this.grpOilAndLube.TabIndex = 0;
            this.grpOilAndLube.TabStop = false;
            this.grpOilAndLube.Text = "Oil And Lube";
            // 
            // chkBxLube
            // 
            this.chkBxLube.AutoSize = true;
            this.chkBxLube.Location = new System.Drawing.Point(16, 43);
            this.chkBxLube.Name = "chkBxLube";
            this.chkBxLube.Size = new System.Drawing.Size(146, 22);
            this.chkBxLube.TabIndex = 1;
            this.chkBxLube.Text = "Lube Job ($18.00)";
            this.chkBxLube.UseVisualStyleBackColor = true;
            // 
            // chkBxOil
            // 
            this.chkBxOil.AutoSize = true;
            this.chkBxOil.Location = new System.Drawing.Point(16, 20);
            this.chkBxOil.Name = "chkBxOil";
            this.chkBxOil.Size = new System.Drawing.Size(158, 22);
            this.chkBxOil.TabIndex = 0;
            this.chkBxOil.Text = "Oil Change ($26.00)";
            this.chkBxOil.UseVisualStyleBackColor = true;
            // 
            // grpFlushes
            // 
            this.grpFlushes.Controls.Add(this.chkBxTransmission);
            this.grpFlushes.Controls.Add(this.chkBxRadiator);
            this.grpFlushes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFlushes.Location = new System.Drawing.Point(445, 59);
            this.grpFlushes.Name = "grpFlushes";
            this.grpFlushes.Size = new System.Drawing.Size(329, 80);
            this.grpFlushes.TabIndex = 1;
            this.grpFlushes.TabStop = false;
            this.grpFlushes.Text = "Flushes";
            // 
            // chkBxTransmission
            // 
            this.chkBxTransmission.AutoSize = true;
            this.chkBxTransmission.Location = new System.Drawing.Point(15, 47);
            this.chkBxTransmission.Name = "chkBxTransmission";
            this.chkBxTransmission.Size = new System.Drawing.Size(215, 22);
            this.chkBxTransmission.TabIndex = 1;
            this.chkBxTransmission.Text = "Transmission Flush ($80.00)";
            this.chkBxTransmission.UseVisualStyleBackColor = true;
            // 
            // chkBxRadiator
            // 
            this.chkBxRadiator.AutoSize = true;
            this.chkBxRadiator.Location = new System.Drawing.Point(15, 25);
            this.chkBxRadiator.Name = "chkBxRadiator";
            this.chkBxRadiator.Size = new System.Drawing.Size(181, 22);
            this.chkBxRadiator.TabIndex = 0;
            this.chkBxRadiator.Text = "Radiator Flush ($30.00)";
            this.chkBxRadiator.UseVisualStyleBackColor = true;
            // 
            // grpMisc
            // 
            this.grpMisc.Controls.Add(this.chkBxTireRotation);
            this.grpMisc.Controls.Add(this.chkBxMuffler);
            this.grpMisc.Controls.Add(this.chkBxInspection);
            this.grpMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMisc.Location = new System.Drawing.Point(27, 145);
            this.grpMisc.Name = "grpMisc";
            this.grpMisc.Size = new System.Drawing.Size(335, 96);
            this.grpMisc.TabIndex = 2;
            this.grpMisc.TabStop = false;
            this.grpMisc.Text = "Misc";
            // 
            // chkBxTireRotation
            // 
            this.chkBxTireRotation.AutoSize = true;
            this.chkBxTireRotation.Location = new System.Drawing.Point(16, 65);
            this.chkBxTireRotation.Name = "chkBxTireRotation";
            this.chkBxTireRotation.Size = new System.Drawing.Size(170, 22);
            this.chkBxTireRotation.TabIndex = 3;
            this.chkBxTireRotation.Text = "Tire Rotation ($20.00)";
            this.chkBxTireRotation.UseVisualStyleBackColor = true;
            // 
            // chkBxMuffler
            // 
            this.chkBxMuffler.AutoSize = true;
            this.chkBxMuffler.Location = new System.Drawing.Point(16, 42);
            this.chkBxMuffler.Name = "chkBxMuffler";
            this.chkBxMuffler.Size = new System.Drawing.Size(196, 22);
            this.chkBxMuffler.TabIndex = 3;
            this.chkBxMuffler.Text = "Replace Muffler ($100.00)";
            this.chkBxMuffler.UseVisualStyleBackColor = true;
            // 
            // chkBxInspection
            // 
            this.chkBxInspection.AutoSize = true;
            this.chkBxInspection.Location = new System.Drawing.Point(16, 19);
            this.chkBxInspection.Name = "chkBxInspection";
            this.chkBxInspection.Size = new System.Drawing.Size(152, 22);
            this.chkBxInspection.TabIndex = 3;
            this.chkBxInspection.Text = "Inspection ($15.00)";
            this.chkBxInspection.UseVisualStyleBackColor = true;
            // 
            // grpPartsAndLabor
            // 
            this.grpPartsAndLabor.Controls.Add(this.lblLaborPerHour);
            this.grpPartsAndLabor.Controls.Add(this.txtLabor);
            this.grpPartsAndLabor.Controls.Add(this.txtParts);
            this.grpPartsAndLabor.Controls.Add(this.lblLabor);
            this.grpPartsAndLabor.Controls.Add(this.lblParts);
            this.grpPartsAndLabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPartsAndLabor.Location = new System.Drawing.Point(445, 145);
            this.grpPartsAndLabor.Name = "grpPartsAndLabor";
            this.grpPartsAndLabor.Size = new System.Drawing.Size(329, 100);
            this.grpPartsAndLabor.TabIndex = 3;
            this.grpPartsAndLabor.TabStop = false;
            this.grpPartsAndLabor.Text = "Parts and Labor";
            // 
            // lblLaborPerHour
            // 
            this.lblLaborPerHour.AutoSize = true;
            this.lblLaborPerHour.Location = new System.Drawing.Point(184, 53);
            this.lblLaborPerHour.Name = "lblLaborPerHour";
            this.lblLaborPerHour.Size = new System.Drawing.Size(124, 18);
            this.lblLaborPerHour.TabIndex = 4;
            this.lblLaborPerHour.Text = "($29.00 per Hour)";
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(61, 47);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(100, 24);
            this.txtLabor.TabIndex = 3;
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(61, 21);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(100, 24);
            this.txtParts.TabIndex = 2;
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(12, 47);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(46, 18);
            this.lblLabor.TabIndex = 1;
            this.lblLabor.Text = "Labor";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(12, 24);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(43, 18);
            this.lblParts.TabIndex = 0;
            this.lblParts.Text = "Parts";
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.txtTotalFees);
            this.grpSummary.Controls.Add(this.txtTax);
            this.grpSummary.Controls.Add(this.txtSumParts);
            this.grpSummary.Controls.Add(this.txtServicesAndLabor);
            this.grpSummary.Controls.Add(this.lblTotalFees);
            this.grpSummary.Controls.Add(this.lblTax);
            this.grpSummary.Controls.Add(this.lblSumParts);
            this.grpSummary.Controls.Add(this.lblServicesAndLabor);
            this.grpSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSummary.Location = new System.Drawing.Point(27, 261);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(747, 137);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // txtTotalFees
            // 
            this.txtTotalFees.Enabled = false;
            this.txtTotalFees.Location = new System.Drawing.Point(376, 107);
            this.txtTotalFees.Name = "txtTotalFees";
            this.txtTotalFees.Size = new System.Drawing.Size(100, 24);
            this.txtTotalFees.TabIndex = 7;
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Location = new System.Drawing.Point(376, 77);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 24);
            this.txtTax.TabIndex = 6;
            // 
            // txtSumParts
            // 
            this.txtSumParts.Enabled = false;
            this.txtSumParts.Location = new System.Drawing.Point(376, 47);
            this.txtSumParts.Name = "txtSumParts";
            this.txtSumParts.Size = new System.Drawing.Size(100, 24);
            this.txtSumParts.TabIndex = 5;
            // 
            // txtServicesAndLabor
            // 
            this.txtServicesAndLabor.Enabled = false;
            this.txtServicesAndLabor.Location = new System.Drawing.Point(376, 17);
            this.txtServicesAndLabor.Name = "txtServicesAndLabor";
            this.txtServicesAndLabor.Size = new System.Drawing.Size(100, 24);
            this.txtServicesAndLabor.TabIndex = 4;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(292, 110);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(78, 18);
            this.lblTotalFees.TabIndex = 3;
            this.lblTotalFees.Text = "Total Fees";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(270, 80);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(100, 18);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax (on parts)";
            // 
            // lblSumParts
            // 
            this.lblSumParts.AutoSize = true;
            this.lblSumParts.Location = new System.Drawing.Point(327, 50);
            this.lblSumParts.Name = "lblSumParts";
            this.lblSumParts.Size = new System.Drawing.Size(43, 18);
            this.lblSumParts.TabIndex = 1;
            this.lblSumParts.Text = "Parts";
            // 
            // lblServicesAndLabor
            // 
            this.lblServicesAndLabor.AutoSize = true;
            this.lblServicesAndLabor.Location = new System.Drawing.Point(234, 20);
            this.lblServicesAndLabor.Name = "lblServicesAndLabor";
            this.lblServicesAndLabor.Size = new System.Drawing.Size(136, 18);
            this.lblServicesAndLabor.TabIndex = 0;
            this.lblServicesAndLabor.Text = "Services And Labor";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(189, 404);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 34);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(331, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(473, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Joes Automotive";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpPartsAndLabor);
            this.Controls.Add(this.grpMisc);
            this.Controls.Add(this.grpFlushes);
            this.Controls.Add(this.grpOilAndLube);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Repair Shop";
            this.grpOilAndLube.ResumeLayout(false);
            this.grpOilAndLube.PerformLayout();
            this.grpFlushes.ResumeLayout(false);
            this.grpFlushes.PerformLayout();
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            this.grpPartsAndLabor.ResumeLayout(false);
            this.grpPartsAndLabor.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOilAndLube;
        private System.Windows.Forms.CheckBox chkBxLube;
        private System.Windows.Forms.CheckBox chkBxOil;
        private System.Windows.Forms.GroupBox grpFlushes;
        private System.Windows.Forms.CheckBox chkBxTransmission;
        private System.Windows.Forms.CheckBox chkBxRadiator;
        private System.Windows.Forms.GroupBox grpMisc;
        private System.Windows.Forms.CheckBox chkBxTireRotation;
        private System.Windows.Forms.CheckBox chkBxMuffler;
        private System.Windows.Forms.CheckBox chkBxInspection;
        private System.Windows.Forms.GroupBox grpPartsAndLabor;
        private System.Windows.Forms.Label lblLaborPerHour;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.TextBox txtTotalFees;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSumParts;
        private System.Windows.Forms.TextBox txtServicesAndLabor;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSumParts;
        private System.Windows.Forms.Label lblServicesAndLabor;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}


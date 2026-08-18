namespace FuelTripEstimator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnCalculate;
            lblTitle = new Label();
            lblDistance = new Label();
            lblConsumption = new Label();
            lblFuelPrice = new Label();
            label1 = new Label();
            numPassengers = new NumericUpDown();
            btnClear = new Button();
            grpResults = new GroupBox();
            lblCostPerPersonResult = new Label();
            label4 = new Label();
            lblTotalCostResult = new Label();
            label2 = new Label();
            lblFuelRequiredResult = new Label();
            label3 = new Label();
            lblStatus = new Label();
            txtDistance = new TextBox();
            txtConsumption = new TextBox();
            txtFuelPrice = new TextBox();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)numPassengers).BeginInit();
            grpResults.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(270, 265);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate Trip Cost";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(208, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(354, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Fuel Trip Cost Estimator";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDistance.Location = new Point(88, 70);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(156, 25);
            lblDistance.TabIndex = 1;
            lblDistance.Text = "Trip Distance (km):";
            // 
            // lblConsumption
            // 
            lblConsumption.AutoSize = true;
            lblConsumption.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsumption.Location = new Point(6, 112);
            lblConsumption.Name = "lblConsumption";
            lblConsumption.Size = new Size(238, 23);
            lblConsumption.TabIndex = 2;
            lblConsumption.Text = "Fuel Consumption (L/100 km):";
            // 
            // lblFuelPrice
            // 
            lblFuelPrice.AutoSize = true;
            lblFuelPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuelPrice.Location = new Point(118, 156);
            lblFuelPrice.Name = "lblFuelPrice";
            lblFuelPrice.Size = new Size(126, 23);
            lblFuelPrice.TabIndex = 3;
            lblFuelPrice.Text = "Fuel Price ($/L):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 202);
            label1.Name = "label1";
            label1.Size = new Size(185, 23);
            label1.TabIndex = 4;
            label1.Text = "Number of Passengers:";
            // 
            // numPassengers
            // 
            numPassengers.Location = new Point(250, 202);
            numPassengers.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numPassengers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPassengers.Name = "numPassengers";
            numPassengers.Size = new Size(150, 27);
            numPassengers.TabIndex = 5;
            numPassengers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnClear
            // 
            btnClear.Location = new Point(409, 265);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // grpResults
            // 
            grpResults.Controls.Add(lblCostPerPersonResult);
            grpResults.Controls.Add(label4);
            grpResults.Controls.Add(lblTotalCostResult);
            grpResults.Controls.Add(label2);
            grpResults.Controls.Add(lblFuelRequiredResult);
            grpResults.Controls.Add(label3);
            grpResults.Location = new Point(126, 300);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(523, 146);
            grpResults.TabIndex = 8;
            grpResults.TabStop = false;
            grpResults.Text = "Trip Cost Results";
            // 
            // lblCostPerPersonResult
            // 
            lblCostPerPersonResult.AutoSize = true;
            lblCostPerPersonResult.Location = new Point(124, 111);
            lblCostPerPersonResult.Name = "lblCostPerPersonResult";
            lblCostPerPersonResult.Size = new Size(15, 20);
            lblCostPerPersonResult.TabIndex = 6;
            lblCostPerPersonResult.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 111);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 5;
            label4.Text = "Cost Per Person:";
            // 
            // lblTotalCostResult
            // 
            lblTotalCostResult.AutoSize = true;
            lblTotalCostResult.Location = new Point(115, 74);
            lblTotalCostResult.Name = "lblTotalCostResult";
            lblTotalCostResult.Size = new Size(15, 20);
            lblTotalCostResult.TabIndex = 4;
            lblTotalCostResult.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Total Fuel Cost:";
            // 
            // lblFuelRequiredResult
            // 
            lblFuelRequiredResult.AutoSize = true;
            lblFuelRequiredResult.Location = new Point(115, 36);
            lblFuelRequiredResult.Name = "lblFuelRequiredResult";
            lblFuelRequiredResult.Size = new Size(15, 20);
            lblFuelRequiredResult.TabIndex = 2;
            lblFuelRequiredResult.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 36);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 1;
            label3.Text = "Fuel Required:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(185, 471);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 9;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(250, 71);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(125, 27);
            txtDistance.TabIndex = 10;
            // 
            // txtConsumption
            // 
            txtConsumption.Location = new Point(250, 111);
            txtConsumption.Name = "txtConsumption";
            txtConsumption.Size = new Size(125, 27);
            txtConsumption.TabIndex = 11;
            // 
            // txtFuelPrice
            // 
            txtFuelPrice.Location = new Point(250, 156);
            txtFuelPrice.Name = "txtFuelPrice";
            txtFuelPrice.Size = new Size(125, 27);
            txtFuelPrice.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 583);
            Controls.Add(txtFuelPrice);
            Controls.Add(txtConsumption);
            Controls.Add(txtDistance);
            Controls.Add(lblStatus);
            Controls.Add(grpResults);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(numPassengers);
            Controls.Add(label1);
            Controls.Add(lblFuelPrice);
            Controls.Add(lblConsumption);
            Controls.Add(lblDistance);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Fuel Trip Cost Estimator";
            ((System.ComponentModel.ISupportInitialize)numPassengers).EndInit();
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDistance;
        private Label lblConsumption;
        private Label lblFuelPrice;
        private Label label1;
        private NumericUpDown numPassengers;
        private Button btnCalculate;
        private Button btnClear;
        private GroupBox grpResults;
        private Label label3;
        private Label lblTotalCostResult;
        private Label label2;
        private Label label4;
        private Label lblCostPerPersonResult;
        private Label lblStatus;
        private Label lblFuelRequiredResult;
        private TextBox txtDistance;
        private TextBox txtConsumption;
        private TextBox txtFuelPrice;
    }
}

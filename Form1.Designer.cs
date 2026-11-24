namespace NonlinearEquationSolver
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            lblTitle = new Label();
            grbInput = new GroupBox();
            btnCalculate = new Button();
            txtTolerance = new TextBox();
            txtInitialGuess = new TextBox();
            txtFunction = new TextBox();
            lblTolerance = new Label();
            lblIntial = new Label();
            lblFunction = new Label();
            dgvResults = new DataGridView();
            colIteration = new DataGridViewTextBoxColumn();
            colX = new DataGridViewTextBoxColumn();
            colNextX = new DataGridViewTextBoxColumn();
            colError = new DataGridViewTextBoxColumn();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            grbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(292, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(441, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Nonlinear Equation Solver";
            // 
            // grbInput
            // 
            grbInput.Controls.Add(btnCalculate);
            grbInput.Controls.Add(txtTolerance);
            grbInput.Controls.Add(txtInitialGuess);
            grbInput.Controls.Add(txtFunction);
            grbInput.Controls.Add(lblTolerance);
            grbInput.Controls.Add(lblIntial);
            grbInput.Controls.Add(lblFunction);
            grbInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grbInput.ForeColor = Color.Navy;
            grbInput.Location = new Point(33, 105);
            grbInput.Name = "grbInput";
            grbInput.Size = new Size(387, 226);
            grbInput.TabIndex = 1;
            grbInput.TabStop = false;
            grbInput.Text = "Function Parameters";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Navy;
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            btnCalculate.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(78, 172);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(173, 40);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate Root";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtTolerance
            // 
            txtTolerance.BackColor = Color.White;
            txtTolerance.Font = new Font("Segoe UI", 10F);
            txtTolerance.Location = new Point(141, 116);
            txtTolerance.Name = "txtTolerance";
            txtTolerance.Size = new Size(125, 30);
            txtTolerance.TabIndex = 4;
            txtTolerance.Text = "0.0001";
            // 
            // txtInitialGuess
            // 
            txtInitialGuess.BackColor = Color.White;
            txtInitialGuess.Font = new Font("Segoe UI", 10F);
            txtInitialGuess.Location = new Point(141, 71);
            txtInitialGuess.Name = "txtInitialGuess";
            txtInitialGuess.Size = new Size(125, 30);
            txtInitialGuess.TabIndex = 3;
            txtInitialGuess.Text = "0";
            txtInitialGuess.TextChanged += txtIntialGuess_TextChanged;
            // 
            // txtFunction
            // 
            txtFunction.BackColor = Color.White;
            txtFunction.Font = new Font("Segoe UI", 10F);
            txtFunction.Location = new Point(141, 27);
            txtFunction.Name = "txtFunction";
            txtFunction.Size = new Size(125, 30);
            txtFunction.TabIndex = 2;
            txtFunction.Text = "x^3-8*x+5";
            // 
            // lblTolerance
            // 
            lblTolerance.AutoSize = true;
            lblTolerance.Location = new Point(0, 123);
            lblTolerance.Name = "lblTolerance";
            lblTolerance.Size = new Size(85, 23);
            lblTolerance.TabIndex = 2;
            lblTolerance.Text = "Tolerance";
            // 
            // lblIntial
            // 
            lblIntial.AutoSize = true;
            lblIntial.Location = new Point(0, 78);
            lblIntial.Name = "lblIntial";
            lblIntial.Size = new Size(144, 23);
            lblIntial.TabIndex = 1;
            lblIntial.Text = "Initial Guess (X0)";
            // 
            // lblFunction
            // 
            lblFunction.AutoSize = true;
            lblFunction.Location = new Point(0, 34);
            lblFunction.Name = "lblFunction";
            lblFunction.Size = new Size(112, 23);
            lblFunction.TabIndex = 0;
            lblFunction.Text = "Function f(x)";
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { colIteration, colX, colNextX, colError });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            dgvResults.GridColor = Color.LightGray;
            dgvResults.Location = new Point(33, 353);
            dgvResults.MultiSelect = false;
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersVisible = false;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new Size(397, 226);
            dgvResults.TabIndex = 2;
            // 
            // colIteration
            // 
            colIteration.HeaderText = "Iteration";
            colIteration.MinimumWidth = 6;
            colIteration.Name = "colIteration";
            colIteration.ReadOnly = true;
            // 
            // colX
            // 
            colX.HeaderText = "Xi";
            colX.MinimumWidth = 6;
            colX.Name = "colX";
            colX.ReadOnly = true;
            // 
            // colNextX
            // 
            colNextX.HeaderText = "Xi+1";
            colNextX.MinimumWidth = 6;
            colNextX.Name = "colNextX";
            colNextX.ReadOnly = true;
            // 
            // colError
            // 
            colError.HeaderText = "Error";
            colError.MinimumWidth = 6;
            colError.Name = "colError";
            colError.ReadOnly = true;
            // 
            // chartFunction
            // 
            chartFunction.BorderlineColor = Color.LightGray;
            chartFunction.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.LabelStyle.Format = "0.00";
            chartArea1.AxisX.Title = "X Value";
            chartArea1.AxisY.Title = "F(X) Value";
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(532, 114);
            chartFunction.Name = "chartFunction";
            chartFunction.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(500, 320);
            chartFunction.TabIndex = 3;
            chartFunction.Text = "chart1";
            title1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.ForeColor = Color.Navy;
            title1.Name = "Title1";
            title1.Text = "Newtow Raphson Function Graph";
            chartFunction.Titles.Add(title1);
            chartFunction.Click += chartFunction_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1082, 653);
            Controls.Add(chartFunction);
            Controls.Add(dgvResults);
            Controls.Add(grbInput);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1000, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NonLinear Equation Solver";
            grbInput.ResumeLayout(false);
            grbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbInput;
        private Label lblTolerance;
        private Label lblIntial;
        private Label lblFunction;
        private Button btnCalculate;
        private TextBox txtTolerance;
        private TextBox txtInitialGuess;
        private TextBox txtFunction;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn colIteration;
        private DataGridViewTextBoxColumn colX;
        private DataGridViewTextBoxColumn colNextX;
        private DataGridViewTextBoxColumn colError;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}

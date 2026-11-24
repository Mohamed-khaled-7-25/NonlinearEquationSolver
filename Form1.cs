namespace NonlinearEquationSolver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtFunction.Text;
                if (string.IsNullOrWhiteSpace(txtFunction.Text) ||
                  string.IsNullOrWhiteSpace(txtInitialGuess.Text) ||
                  string.IsNullOrWhiteSpace(txtTolerance.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                double x0 = double.Parse(txtInitialGuess.Text);
                double tolerance = double.Parse(txtTolerance.Text);
                if (!double.TryParse(txtInitialGuess.Text, out double X0) ||
                  !double.TryParse(txtTolerance.Text, out double Tolerance))
                {
                    MessageBox.Show("Please enter valid numbers.");
                    return;
                }

                if (tolerance <= 0)
                {
                    MessageBox.Show("Tolerance must be greater than zero.");
                    return;
                }

                FunctionEvaluator evaluator = new FunctionEvaluator();

                var results = NewtonRaphson.Solve(
                    x => evaluator.Evaluate(expression, x),
                    x => evaluator.Derivative(expression, x),
                    x0,
                    tolerance
                );

                dgvResults.DataSource = null;
                dgvResults.Columns.Clear();
                dgvResults.AutoGenerateColumns = true;
                dgvResults.DataSource = results;
                dgvResults.Columns["Xi"].DefaultCellStyle.Format = "F6";
                dgvResults.Columns["NextXi"].DefaultCellStyle.Format = "F6";
                dgvResults.Columns["Error"].DefaultCellStyle.Format = "F6";
                dgvResults.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
                chartFunction.Series.Clear();
                var area = chartFunction.ChartAreas[0];

                area.AxisX.Title = "X";
                area.AxisY.Title = "f(X)";

                var functionSeries = chartFunction.Series.Add("Function");
                functionSeries.ChartType =
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                var pointsSeries = chartFunction.Series.Add("Iterations");
                pointsSeries.ChartType =
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                pointsSeries.MarkerSize = 8;

                double start = x0 - 2;
                double end = x0 + 2;

                for (double x = start; x <= end; x += 0.05)
                {
                    double roundedX = Math.Round(x, 2);

                    functionSeries.Points.AddXY(
                        roundedX, evaluator.Evaluate(expression, roundedX));
                }
                foreach (var result in results)
                {
                    pointsSeries.Points.AddXY(
                        result.Xi, evaluator.Evaluate(expression, result.Xi));
                }
                var finalResult = results[results.Count - 1];

                MessageBox.Show(
                    $"Approximate Root = {finalResult.NextXi:F6}\n" +
                    $"Number of Iterations = {results.Count}",
                    "Calculation Result"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calculation Error");
            }
        }

        private void txtIntialGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartFunction_Click(object sender, EventArgs e)
        {

        }
    }
}

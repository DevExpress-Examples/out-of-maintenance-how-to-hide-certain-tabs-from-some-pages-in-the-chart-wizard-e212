using System;
using System.Windows.Forms;
using DevExpress.XtraCharts.Wizard;
// ...


namespace docChartWizardHideTabs {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a new Wizard.
            ChartWizard wizard = new ChartWizard(this.chartControl1);

            // Obtain a Data page.
            WizardDataPage page = wizard.DataPage;

            // Hide datasource-related tabs on the Data page.
            page.HiddenPageTabs.Add(DataPageTab.AutoCreatedSeries);
            page.HiddenPageTabs.Add(DataPageTab.SeriesBinding);

            // Invoke the Wizard window.
            wizard.ShowDialog();
        }
    }
}
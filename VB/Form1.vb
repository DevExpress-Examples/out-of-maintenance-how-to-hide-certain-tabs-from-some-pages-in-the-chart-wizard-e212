Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts.Wizard
' ...


Namespace docChartWizardHideTabs
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
		Handles button1.Click
			' Create a new Wizard.
			Dim wizard As ChartWizard = New ChartWizard(Me.chartControl1)

			' Obtain a Data page.
			Dim page As WizardDataPage = wizard.DataPage

			' Hide datasource-related tabs on the Data page.
			page.HiddenPageTabs.Add(DataPageTab.AutoCreatedSeries)
			page.HiddenPageTabs.Add(DataPageTab.SeriesBinding)

			' Invoke the Wizard window.
			wizard.ShowDialog()
		End Sub
	End Class
End Namespace
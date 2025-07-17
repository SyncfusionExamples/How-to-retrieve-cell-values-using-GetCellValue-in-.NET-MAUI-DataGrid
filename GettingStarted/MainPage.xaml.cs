using Syncfusion.Maui.DataGrid.Helper;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ShowCellValue_Clicked(object sender, EventArgs e)
        {
            if (dataGrid != null && dataGrid.View != null && dataGrid.View.Records.Count > 0)
            {
                // Get the first column's MappingName (you can change this to target a specific column).
                var column = dataGrid.Columns.FirstOrDefault();

                if (column != null)
                {
                    // Get the record at row index 1.
                    var rowData = dataGrid.GetRecordAtRowIndex(1);

                    // Get the cell value as string.
                    string cellValue = dataGrid.GetCellValue(rowData, column.MappingName) as string;

                    // Display the cell value in an alert.
                    DisplayAlert("Cell Value", $"Cell Value: {cellValue ?? "null"}", "OK");
                }
            }
        }
    }

}

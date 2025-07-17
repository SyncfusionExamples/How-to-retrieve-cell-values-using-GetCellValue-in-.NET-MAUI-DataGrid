# How to retrieve cell values using GetCellValue in .NET MAUI DataGrid?

This article demonstrates how to retrieve cell values using GetCellValue in [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid)

In SfDataGrid, you can retrieve a cell's value using dataGrid.GetCellValue(), passing the row and column as parameters.

## C#

```C#
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
```

## Xaml

```xml
<Grid RowDefinitions="Auto, *">
    <Button Grid.Row="0" 
            Text="Show Cell Value" 
            Clicked="ShowCellValue_Clicked"
            Margin="10"/>

    <syncfusion:SfDataGrid x:Name="dataGrid"
                            Grid.Row="1"
                            ItemsSource="{Binding OrderInfoCollection}" />
</Grid>
```

You can download this example on [GitHub](https://github.com/SyncfusionExamples/How-to-retrieve-cell-values-using-GetCellValue-in-.NET-MAUI-DataGrid).
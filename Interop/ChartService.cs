namespace DemoBlazorInterop.Interop;

public class ChartService
{
    public ChartData GetChartData()
    {
        var chartData = new ChartData();
        chartData.Labels.AddRange(new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" });
        chartData.Series.Add(new SeriesData { Data = new List<double> { 65, 59, 80, 81, 56, 55, 40 } });
        chartData.Series.Add(new SeriesData { Data = new List<double> { 28, 48, 40, 19, 86, 27, 90 } });
        return chartData;
    }
}

public class ChartService : IChartService
{
    public async Task<ChartData> GetSalesDataAsync()
    {
        // 模拟数据
        return new ChartData
        {
            Categories = new[] { "Q1", "Q2", "Q3", "Q4" },
            Series = new[]
            {
                new { Name = "销售额", Data = new[] { 2500, 4800, 3600, 1800 } }
            }
        };
    }
}
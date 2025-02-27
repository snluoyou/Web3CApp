// ECharts配置示例
$(document).ready(function () {
    var chartDom = document.getElementById('mainChart');
    var myChart = echarts.init(chartDom);
    
    var option = {
        title: {
            text: '销售数据统计'
        },
        tooltip: {},
        legend: {
            data:['销售额']
        },
        xAxis: {
            data: @Html.Raw(Json.Serialize(Model.Categories))
        },
        yAxis: {},
        series: [{
            name: '销售额',
            type: 'bar',
            data: @Html.Raw(Json.Serialize(Model.Series[0].Data))
        }]
    };
    
    myChart.setOption(option);
});
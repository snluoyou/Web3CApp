// 百度地图初始化脚本
$(document).ready(function () {
    var map = new BMapGL.Map("mapContainer");
    map.centerAndZoom(new BMapGL.Point(116.404, 39.915), 12); // 北京坐标
    
    // 添加标记点
    var marker = new BMapGL.Marker(new BMapGL.Point(116.404, 39.915));
    map.addOverlay(marker);
    
    // 地图点击事件
    map.addEventListener("click", function (e) {
        console.log("点击坐标：" + e.point.lng + "," + e.point.lat);
    });
});
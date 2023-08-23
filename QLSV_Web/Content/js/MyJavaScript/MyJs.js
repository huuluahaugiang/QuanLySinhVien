var table = document.getElementsByTagName("table")[1];
var tbody = table.getElementsByTagName("tbody")[1];
tbody.onclick = function (e) {
    e = e || window.event;
    var data = [];
    var target = e.srcElement || e.target;
    while (target && target.nodeName !== "TR") {
        target = target.parentNode;
    }
    if (target) {
        var cells = target.getElementsByTagName("td");
        for (var i = 0; i < cells.length; i++) {
            data.push(cells[i].innerHTML);
        }
    }
    alert(data);
};
function Cong(p1, p2) {
    return p1 + p2;
}
function DanhGia(tuoi){
    var s;
    if(tuoi<18){
        s="bạn là thiếu nhi";
    }else if (tuoi<=25){
        s="bạn đã trưởng thành";
    }else{
        s="bạn đã già rồi";
    }
    return s;
}
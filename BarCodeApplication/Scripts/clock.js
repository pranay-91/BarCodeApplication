Date.prototype.getMonthName = function () {
    var monthNames = ["January", "February", "March", "April", "May", "June",
                  "July", "August", "September", "October", "November", "December"];
    return monthNames[this.getMonth()];
}

function startTime() {
    var today = new Date();
    var h = today.getHours();
    var m = today.getMinutes();
    var s = today.getSeconds();
    var dd = today.getDate();
    var mm = new Date().getMonthName();
    var yy = today.getFullYear();

    m = checkTime(m);
    s = checkTime(s);

    document.getElementById('clock').innerHTML = "<b>" + h + "</b>" + ":" + m + ":" + s;
    document.getElementById('date').innerHTML = dd + " " + mm + " " + yy;
    var t = setTimeout(function () { startTime() }, 500);
}

function checkTime(i) {
    if (i < 10) { i = "0" + i };  // add zero in front of numbers < 10
    return i;
}
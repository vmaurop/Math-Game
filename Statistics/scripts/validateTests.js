
function validateTest() {
    var count = 0;
    for(var i =1;i<6;i++){
        if (document.getElementById(i+"-A").checked) { count++; }
    }
    alert(count);
 //   document.location.href = '../Tests/Main';
}
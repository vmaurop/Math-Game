function Statistics() {

    var x = $("#data").val().split(',').map(Number); 

    var avg;
    var med;
    var st_d;
    var v;

    //invalid input...
    for (var i in x) {
        if (Number.isNaN(x[i]) || (x[i] == "")) {
            alert("Incorrect input data");
            exit();
        }
    }

    //average
    var sum = 0
    for (var i in x) 
    {
        sum = sum + x[i];
    }
    avg = sum / x.length;


    //median
    x = x.sort();
    if (x.length % 2 == 0) {
        med = (x[(x.length) / 2 - 1] + x[(x.length) / 2]) / 2.0;
    }
    else {

        med = x[parseInt(x.length / 2)]; 

    }



    //variance
    var sumS = 0;
    for (var j in x) {
        sumS = sumS + Math.pow(x[j] - avg, 2);
    }

    v = sumS / (x.length);

    //standard_deviation
    st_d = Math.sqrt(v);

    //modes
    var modes = [], count = [], i, number, maxIndex = 0;

    for (i = 0; i < x.length; i += 1) {
        number = x[i];
        count[number] = (count[number] || 0) + 1;
        if (count[number] > maxIndex) {
            maxIndex = count[number];
        }
    }

    for (i in count)
        if (count.hasOwnProperty(i) && count[i] === maxIndex) {
            modes.push(Number(i));
        }




    $("#max").html("<b>Maximum:</b> " + Math.max.apply(Math, x));   
    $("#min").html("<b>Minimum:</b> " + Math.min.apply(Math, x));
    $("#count").html("<b>Count:</b> " + x.length);
    $("#sum").html("<b>Sum:</b> " + sum);
    $("#average").html("<b>Average:</b> " + Math.round(avg * 100) / 100);
    $("#median").html("<b>Median:</b> " + Math.round(med * 100) / 100);
    $("#mode").html("<b>Modes:</b>" + modes);
    $("#variance").html("<b>Variance:</b> " + Math.round(v * 100) / 100);
    $("#standard_deviation").html("<b>Standard Deviation:</b> " + Math.round(st_d * 100) / 100);





}

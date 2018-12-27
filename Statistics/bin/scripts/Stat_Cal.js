function Statistics() {

    var x = $("#data").val().split(',').map(Number); //pare th metavliti me id data kai vgale ta koma kai casting se arithmous!

    var avg;
    var med;
    var st_d;
    var v;

    //exceptions...
    for (var i in x) {
        if (Number.isNaN(x[i]) || (x[i] == "" && x[i] != 0)) {

            alert("Incorrect input data");
            exit();

        }
    }
    
    //average
    var sum = 0
    for (var i in x)    //for(var i=0;i<k.length;i++)
    {

        sum = sum + x[i];
    }
    avg = sum / x.length;


    //median
    x = x.sort();  //taksinomisi kata auksoysa seira
    if (x.length % 2 == 0) {
        med = (x[(x.length) / 2 - 1] + x[(x.length) / 2]) / 2.0;
    }
    else {

        med = x[parseInt(x.length / 2)];  //metatroph se akeeraio

    }



    //variance
    var sumS = 0;
    for (var j in x) {
        sumS = sumS + Math.pow(x[j] - avg, 2);
    }

    v = sumS / (x.length);

    //standard_deviation
    st_d = Math.sqrt(v);

    $("#max").html("<b>Max:</b> " + Math.max.apply(Math, x));      //To get min/max value in array
    $("#min").html("<b>Min:</b> " + Math.min.apply(Math, x));
    $("#count").html("<b>Count:</b> " + x.length);
    $("#sum").html("<b>Sum:</b> " + sum);
    $("#average").html("<b>Average:</b> " + Math.round(avg * 100) / 100); //strogilopoiisi
    $("#median").html("<b>Median:</b> " + Math.round(med * 100) / 100);
    $("#variance").html("<b>Variance:</b> " + Math.round(v * 100) / 100);
    $("#standard_deviation").html("<b>Standard_deviation:</b> " + Math.round(st_d * 100) / 100);





}
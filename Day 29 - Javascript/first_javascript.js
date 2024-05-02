


function Greet() {
    alert('Hello and Welcome to Javascript');
}


// Add 2 numbers
//Numbers will be entered by users, in text format, we need to conver it to int
function calculate(num1,num2) {
  
    // n1 = num1; ///but this is a string
    // n2 = num2; //this is a string

        //now if user enters 10 and 30
        //result = n1 + n2
        //result will be 1030 //which is not accepted

    var n1 = parseInt(num1);
    var n2 = parseInt(num2);
    var result = n1 + n2;
   // alert(result);
    console.log(result);
}
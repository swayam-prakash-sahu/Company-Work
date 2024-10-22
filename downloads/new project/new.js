// call by value 

let a = 5;
let b;
b = a;
a = 3;
console.log(a);
console.log(b);

// call by reference in objects

let c = { greeting: 'Hello World' };
let d;
d = c;

c.greeting = 'Welcome to gyansys';
console.log(c);
console.log(d);


// call by reference in arrays

let orgArr = ["Microsoft", "Team","is", "the"];
let tmpArr = orgArr;

orgArr.push('best')

console.log(tmpArr);  
console.log(orgArr);    
      
// map
    function triple(n){ 
        return n*3; 
    }	 
    arr = new Array(1, 2, 3, 6, 5, 4); 

    var new_arr = arr.map(triple) 
    console.log(new_arr);     

// filter
    arr = new Array(1, 2, 3, 6, 5, 4); 
    var new_arr = arr.filter(function (x){ 
        return x % 2==0; 
    }); 
    
    console.log(new_arr)     
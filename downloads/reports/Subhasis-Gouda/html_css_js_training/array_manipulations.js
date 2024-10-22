var list=[11,22,33,44,55,66,77,88,99];
console.log(list);
list.push(100);
console.log(list);
list.shift();
console.log(list);
delete list[5];
list[5]=56;
console.log(list);
list.unshift(67);
console.log(list);

let p=[111,222,333,444];

var array = list.concat(p);
console.log(array);

//slicing

let slice_ar= array.slice(2,9);
console.log(slice_ar);

var st= [
    { name: "Mark", age: 18, dept: "Computer Science" },
    { name: "John", age: 20, dept: "Electrical Engineering" },
    { name: "Alice", age: 19, dept: "Mathematics" }
  ];

var index = st.findIndex(student => student.name === "Mark");
console.log(index);

console.log(list.indexOf(55));
list[6]=2;
let i=6;
var value=0;
console.log(list);
function get_value(value,i,list){return value>=44};
var ret=list.find(get_value)
console.log(ret);
ret=list.findIndex(get_value)
console.log(ret);
 ret=list.findLastIndex(get_value)
console.log(ret);
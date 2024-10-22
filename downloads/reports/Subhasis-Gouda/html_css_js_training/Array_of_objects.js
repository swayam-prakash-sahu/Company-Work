let strr="Engineering Students";
strr=strr.replace("Students"," ");
console.log(strr)

console.log("Engineering students of ${1+3} year")//Engineering students of ${1+3} year

console.log(`Engineering students of ${1+3} year`)//Engineering students of 4 year

let arr=[1,2,3,4,5];

for(var i=0;i<10;i++)
{
    arr[i]=i+1;
}
console.log(arr)

let brr=arr;
brr[6]=arr[6]+5;
console.log(brr);
console.log(arr);
var e1=["mark", 18, 12, "newyork"];
var e2=["billgates" , 17, 11, "london"];
var e3=["elon musk", 16, 10, "paris"];
var students = [ e1,e2,e3 ];
console.log("First student's name:", students[0][0]);
console.log("Second student's age:", students[1][1]);
console.log("Third student's address:", students[2][3]);

var st= [
    { name: "Mark", age: 18, dept: "Computer Science" },
    { name: "John", age: 20, dept: "Electrical Engineering" },
    { name: "Alice", age: 19, dept: "Mathematics" }
  ];

  var eligible=st.filter(x=>x.age>=19);
  console.log(eligible);

  var scholarship=eligible.map(y=>y.amount=10000);
  console.log(` the variable having map `);
  console.log(scholarship);
  console.log(`filter variable ${eligible}`);
  console.log(eligible);
  console.log(`original data ${st}`);
  console.log(st);



var n1:number= 100;
var n2:number = 200;
var n3:number = n1+n2;
console.log("Value of n3 = "+n3);

var hername:string = "Meena";
var obj:any = {
                 k1:100,
                 k2:"ABC",
                 K3:[10,20,30]
              };

var isTrue:boolean = true;
var arrNames:string[] = ["Eena", "Meena", "Deeka"];

function Greet(pName:string) : void{
    console.log("Namaste "+pName);
}

  //Call the Greet()
  Greet("Meena");
  console.log(hername);
  console.log(obj);
  console.log("Value of k3 is:"+obj.k3[1]);
  console.log(isTrue);
  console.log(arrNames);

 
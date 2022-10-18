class Employee{
   public empId: number;
   public empName: string;
   public empDesignation: string;
   public empEmail: string;
   protected empIncome: number;

   public Work(...tasks:string[]){
    console.log(this.empName + " working on the following project:");
    for(var i=0; i<tasks.length; i++){
        console.log(tasks[i]);
    }
   }
   
   public TakesOff(days:number){
    console.log(this.empName + "takesoff", days, "days in a month");
   }

   public AssignempIncome(income:number){
    this.empIncome = income;
   }

   public AssignempIncome(work:string[]){
    console.log(this.empName + "likes to assign the following work: ");
    for(var i=0; i<work.length; i++){
        console.log(work[i]);
    }
   }

}

class admin extends Employee{

    public
}






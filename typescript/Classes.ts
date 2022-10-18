class Person{
    public Name:string;
    public Age:number;
    public Email:string;
    private Secrets:string[];
    protected Income:number;

    public Eat(...food:string[]){
        console.log(this.Name + "  likes to eat the following: ");
        for(var i=0; i<food.length; i++){
            console.log(food[i]);
        }
    }

    public AssignIncome(income:number){
        this.Income = income;
    }
}

 class ITOfficer extends Person{

    public PrintTotalRefund(){
        console.log(this.Name + " has received a total refund of: ");
        if(this.Income > 300000)
        {
            console.log("INR 10000");
        }
        else{
            console.log("INR 3000");
        }
    }
 }

var auditor = new ITOfficer();
auditor.Name = "Prakash";
auditor.Eat("Chapathi", "2 sabjis", "dessert");
auditor.AssignIncome(1000000);
auditor.PrintTotalRefund();


var Jon = new Person();
Jon.Name = "Jon";
Jon.Email = "jon@abc.com";
Jon.Eat("Junk food", "Pizza");


var Bob = new Person();
Bob.Name = "Bob";
Bob.Email = "bob@gmail.com";
Bob.Eat("Baby food", "Fruits");
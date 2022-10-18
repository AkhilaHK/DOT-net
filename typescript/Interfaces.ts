interface IEmpContract{
    WorkHoursClause();
    CheckInTimeClause();
}

class KpmgEmp implements IEmpContract{
    public EmpId:number;
    public EmpName:string;
    public Designation:string;
    public ShiftStartTime:string;
    //////
    WorkHoursClause() {
        console.log(`${this.EmpName} should work for 8hrs a day a week`);

    }
    CheckInTimeClause() {
        console.log(`${this.EmpName} should check-in to the office by ${this.ShiftStartTime}`);
    }
}

var Akhila = new KpmgEmp();
Akhila.EmpId = 125024;
Akhila.EmpName = "Akhila";
Akhila.Designation = "Analyst";
Akhila.ShiftStartTime = "9am";
Akhila.WorkHoursClause();
Akhila.CheckInTimeClause();
var KpmgEmp = /** @class */ (function () {
    function KpmgEmp() {
    }
    //////
    KpmgEmp.prototype.WorkHoursClause = function () {
        console.log("".concat(this.EmpName, " should work for 8hrs a day a week"));
    };
    KpmgEmp.prototype.CheckInTimeClause = function () {
        console.log("".concat(this.EmpName, " should check-in to the office by ").concat(this.ShiftStartTime));
    };
    return KpmgEmp;
}());
var Akhila = new KpmgEmp();
Akhila.EmpId = 125024;
Akhila.EmpName = "Akhila";
Akhila.Designation = "Analyst";
Akhila.ShiftStartTime = "9am";
Akhila.WorkHoursClause();
Akhila.CheckInTimeClause();

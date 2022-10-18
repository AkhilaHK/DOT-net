var Employee = /** @class */ (function () {
    function Employee() {
    }
    Employee.prototype.Work = function () {
        var tasks = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            tasks[_i] = arguments[_i];
        }
        console.log(this.Name + " working on the following project:");
    };
    return Employee;
}());
var Bob = new Employee();
Bob.empId = "6467788";
Bob.empName = "Bob";
Bob.empDesignation = "analyst";
Bob.empEmail = "bob@gmail.com";
Bob.Work("web developer");

var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Person = /** @class */ (function () {
    function Person() {
    }
    Person.prototype.Eat = function () {
        var food = [];
        for (var _i = 0; _i < arguments.length; _i++) {
            food[_i] = arguments[_i];
        }
        console.log(this.Name + "  likes to eat the following: ");
        for (var i = 0; i < food.length; i++) {
            console.log(food[i]);
        }
    };
    Person.prototype.AssignIncome = function (income) {
        this.Income = income;
    };
    return Person;
}());
var ITOfficer = /** @class */ (function (_super) {
    __extends(ITOfficer, _super);
    function ITOfficer() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    ITOfficer.prototype.PrintTotalRefund = function () {
        console.log(this.Name + " has received a total refund of: ");
        if (this.Income > 300000) {
            console.log("INR 10000");
        }
        else {
            console.log("INR 3000");
        }
    };
    return ITOfficer;
}(Person));
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

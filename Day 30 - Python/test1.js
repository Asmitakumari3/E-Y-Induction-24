var Employee = /** @class */ (function () {
    function Employee() {
    }
    Employee.prototype.greetings = function (name) {
        throw new Error("Method not implemented.");
    };
    Employee.prototype.calcualteBonus = function (sal, percentage) {
        return this.empSalary * percentage / 100;
    };
    Employee.prototype.add = function (number1, number2) {
        return number1 + number2;
    };
    return Employee;
}());
var em = new Employee();
console.log(em.add(20, 30));
console.log(em.calcualteBonus(4000, 10));
try {
    console.log(em.greetings("Nikhil"));
}
catch (error) {
    console.log(error.message);
}

interface IEmployee
{
    empNo:number;
    empName:string;
    empSalary:number;

    calcualteBonus(sal:number, percentage:number);
    add(number1:number, number2:number);
    greetings(name:string):string;

}

class Employee implements IEmployee
{
    greetings(name: string): string {
        throw new Error("Method not implemented.");
    }
    
    empNo: number;
    empName: string;
    empSalary: number;
    calcualteBonus(sal: number, percentage: number ) {
        return this.empSalary * percentage /100;
    }
    add(number1: number, number2: number) {
       return number1 + number2;
    }

   
    
}

var em = new Employee();
console.log(em.add(20,30));
console.log(em.calcualteBonus(4000,10));
try
{
    console.log(em.greetings("Nikhil"));
} catch (error:any) 
{
    console.log(error.message);
}


class Emp2 extends Employee
{
    sayHello(name:string){
        return "Hello " +  name;
    }
}

var emp2 = new Emp2();










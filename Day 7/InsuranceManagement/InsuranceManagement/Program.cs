// See https://aka.ms/new-console-template for more information
using InsuranceManagement;

Console.WriteLine("Hello, World!");


HealthInsurance hObj = new HealthInsurance();
LifeInsurance Lobj = new LifeInsurance();
CarInsurance Cobj = new CarInsurance();

Console.WriteLine(Cobj.CalculateRenewalPremieum(2,800000));
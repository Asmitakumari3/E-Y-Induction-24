using LINQ_SP_Demo.db;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;


#region SP 1 - select *
//InsuranceDbSpLinqContext db = new InsuranceDbSpLinqContext();

////var data = db.Database.ExecuteSqlRaw("proc_allPolicies");
//var data = db.PolicyDetails.FromSql($"execute proc_allPolicies");

//foreach (var item in data)
//{
//    Console.WriteLine(item.PolicyNo);
//    Console.WriteLine(item.PolicyName);
//    Console.WriteLine(item.PolicyPremieum);
//}

#endregion

#region SP 2 - select by policy No

//InsuranceDbSpLinqContext db  = new InsuranceDbSpLinqContext();

//Console.WriteLine("Enter Policy No");
//int policyNo = Convert.ToInt32(Console.ReadLine());
//var data = db.PolicyDetails.FromSql($"execute proc_policyByNo {policyNo}");


//int count = 0;
//foreach ( var item in data )
//{
//    count++;
//    Console.WriteLine(item.PolicyNo);
//    Console.WriteLine(item.PolicyName);
//    Console.WriteLine(item.PolicyPremieum);
//}
//if (count ==0)
//{
//    Console.WriteLine("Policy Not found");

//}


#endregion


#region SP - insert new record
InsuranceDbSpLinqContext db = new InsuranceDbSpLinqContext();
var data = db.PolicyDetails.FromSqlInterpolated($"execute proc_NewPolicy {140},{"Medical Ins"},{18000}");

db.SaveChanges();
Console.WriteLine("Policy Added");



#endregion





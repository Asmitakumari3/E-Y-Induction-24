using bankingAPP_EF;
using bankingAPP_EF.DatabaseFiles;

BankingDbEfContext db = new BankingDbEfContext();

//select and display all the records from accountsInfo table
//write LINQ query for the same

#region select * from accountsInfo
//var acc = from a in db.AccountsInfos
//          select a;

//foreach (var accInfo in acc)
//{
//    Console.WriteLine(accInfo.AccNo);
//    Console.WriteLine(accInfo.AccName);
//    Console.WriteLine(accInfo.AccType);
//    Console.WriteLine(accInfo.AccBalance);
//    Console.WriteLine("---------------------------------");
//}
#endregion

#region Joins
//var accDetails = from a in db.AccountsInfos
//                 join b in db.BranchInfos
//                 on a.AccBranch equals b.BranchNo
//                 select new
//                 {
//                    a,b
//                 };

//foreach (var acc in accDetails)
//{
//    Console.WriteLine(acc.a.AccNo);
//    Console.WriteLine(acc.b.BranchNo);
//}
#endregion

//we want to insert  new record in table in database
//1. create a new accountObject and fill the details

#region Insert new accounts
//AccountsInfo newAcc = new AccountsInfo()
//{
//    AccNo = 105,
//    AccName = "Mohsin",
//    AccType = "Savings",
//    AccBalance = 5000,
//    AccBranch = 10,
//    AccIsActive = true,
//};

////2. add the new object to accounts in dbcontext
//db.AccountsInfos.Add(newAcc);

////3. push the changes to database
//db.SaveChanges();
#endregion

#region Delete an account 

//1. select the account that you want to delete


//Console.WriteLine("Enter Account Number to delete");
//int v_accNo = Convert.ToInt32(Console.ReadLine());   

//var accNo_toDelete = (from a in db.AccountsInfos
//                  where a.AccNo == v_accNo
//                  select a).Single();

////2 delete from dbcontext - we use remove method
//db.AccountsInfos.Remove(accNo_toDelete);

////3. save changes to database
//db.SaveChanges();



#endregion


#region delete multiple accounts
//var savingsAcc = from a in db.AccountsInfos
//                 where a.AccType == "Savings"
//                 select a;


//foreach (var item in savingsAcc)
//{
//    db.AccountsInfos.Remove(item);
//}

//db.SaveChanges();
#endregion


#region update Account

    //1. select the account u want to upadate, lets say we want to update balance and acctype of a user

    var accToEdit = (from a in db.AccountsInfos
                    where a.AccNo == 4
                    select a).Single();

//2. make changes to the account
accToEdit.AccType = "Salary";
accToEdit.AccBalance = 80000;

//3. save changes
    db.SaveChanges();

#endregion









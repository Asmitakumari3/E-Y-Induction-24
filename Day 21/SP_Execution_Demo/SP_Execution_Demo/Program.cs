using Microsoft.Data.SqlClient;
using System.Data;
using System.Threading.Channels;

#region SP 1 - select * from deptInfo
//SqlConnection con = new SqlConnection("server=86B46DA2A2A958B;database=empDB_SP;integrated security=true;TrustServerCertificate=true");

////SQL Query -- Inline Query - we had learned this before
////SqlCommand cmd = new SqlCommand("insert into deptinfo values(@dNo,@dName,@dCity", con);
//SqlCommand cmd = new SqlCommand("proc_AllDept", con);

////by default, when you execute cmd.Execute() == it will expect a sql statement, but we are passing SP, and we have to inform that 
//cmd.CommandType = System.Data.CommandType.StoredProcedure;

////cmd.Parameters.Add(new SqlParameter()); //pass the paramters for sp, if you have, but our first proc does not have it
//con.Open();
//    //execute the cmd

//SqlDataReader read = cmd.ExecuteReader(); //this will read multiple records

//while (read.Read())
//{
//    Console.WriteLine(read[0]);
//    Console.WriteLine(read[1]);
//    Console.WriteLine(read[2]);
//    Console.WriteLine("--------------------------");
//}
//read.Close();
//con.Close();
#endregion


#region SP 2 - select * from deptInfo where deptNo = @dNo
//SqlConnection con = new SqlConnection("server=86B46DA2A2A958B;database=empDB_SP;integrated security=true;TrustServerCertificate=true");
//SqlCommand cmd = new SqlCommand("proc_deptInfo", con);
//cmd.CommandType = System.Data.CommandType.StoredProcedure;
//Console.WriteLine("Please Enter Dept No to view details");
//int deptNo = Convert.ToInt32(Console.ReadLine());
//cmd.Parameters.AddWithValue("@dNo", deptNo);
//con.Open();

//SqlDataReader rd = cmd.ExecuteReader(); 

//if(rd.Read())
//{
//    Console.WriteLine(rd[0]);
//    Console.WriteLine(rd[1]);
//    Console.WriteLine(rd[2]);
//    //Console.WriteLine(rd[3]); --this will give an error as no column is coming in output
//}
//else
//{
//    Console.WriteLine("Dept Not found");
//}

//rd.Close();
//con.Close();
#endregion


#region SP 3 - Select by city

//SqlConnection con = new SqlConnection("server=86B46DA2A2A958B;database=empDB_SP;integrated security=true;TrustServerCertificate=true");
//SqlCommand cmd = new SqlCommand("proc_depByCity", con);
//cmd.CommandType = System.Data.CommandType.StoredProcedure;


//Console.WriteLine("Enter City Name to view departments");
//string city = Console.ReadLine();

//cmd.Parameters.AddWithValue("@city", city);

//con.Open();

//SqlDataReader nikhil = cmd.ExecuteReader();

//int count = 0;

//while (nikhil.Read())
//{
//    count = count + 1;
//    Console.WriteLine(nikhil[0]);
//    Console.WriteLine(nikhil[1]);
//    Console.WriteLine(nikhil[2]);
//    Console.WriteLine("--------------");
//}

//if (count == 0)
//{
//    Console.WriteLine("No records Found for " + city);
//}


//nikhil.Close();
//con.Close();

#endregion


#region - SP 4 Add New Department
//SqlConnection con = new SqlConnection("server=86B46DA2A2A958B;database=empDb_SP;integrated security=true;TrustServerCertificate=true");
//SqlCommand cmd = new SqlCommand("proc_NewDept", con);
//cmd.CommandType = System.Data.CommandType.StoredProcedure;

//Console.WriteLine("Enter New department No");
//int newDeptNo = Convert.ToInt32(Console.ReadLine());
//cmd.Parameters.AddWithValue("@deptNo", newDeptNo);

//Console.WriteLine("Enter New department Name");
//string newDeptName = Console.ReadLine();
//cmd.Parameters.AddWithValue("@deptName",newDeptName);

//Console.WriteLine("Enter New department City");
//string newDeptCity = Console.ReadLine();
//cmd.Parameters.AddWithValue("@deptCity", newDeptCity);


//con.Open();
//   int result = cmd.ExecuteNonQuery();

//con.Close();

//if(result > 0)
//{
//    Console.WriteLine("Department Created");
//}
//else
//{
//    Console.WriteLine("Operation Failed");
//}
#endregion

#region - SP 5 Delete Department

//SqlConnection con = new SqlConnection("server=86B46DA2A2A958B;database=empDB_SP;integrated security=true;TrustServerCertificate=true");
//SqlCommand cmd = new SqlCommand("proc_deleteDept", con);
//cmd.CommandType = System.Data.CommandType.StoredProcedure;

//Console.WriteLine("Enter Dept No");
//int deptNoToDeleteDepartment = Convert.ToInt32(Console.ReadLine());
//cmd.Parameters.AddWithValue("@deptNo",deptNoToDeleteDepartment);
//con.Open();
//int result = cmd.ExecuteNonQuery();
//con.Close();

//if (result == 0)
//{
//    Console.WriteLine("Dept Not found, and thus not deleted");
//}
//else
//{
//    Console.WriteLine("Dept No deleted successfully");
//}

#endregion

#region SP 6 - Update Department

//SqlConnection con = new SqlConnection("server=86B46DA2A2A958B;database=empDB_SP;integrated security=true;TrustServerCertificate=true");
//SqlCommand cmd = new SqlCommand("proc_EditDeptName", con);
//cmd.CommandType = System.Data.CommandType.StoredProcedure;

//Console.WriteLine("Enter the department number ");
//int deptNo = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the new name of department");
//string newName = Console.ReadLine();

//cmd.Parameters.AddWithValue("@deptNo",deptNo);
//cmd.Parameters.AddWithValue("@newDeptName",newName);


//con.Open();
//int result  = cmd.ExecuteNonQuery();
//con.Close();

//if (result > 0)
//{
//    Console.WriteLine(" Dept No " + deptNo + " renamed to " + newName);
//}
//else
//{
//    Console.WriteLine("Invalid dept no");
//}


#endregion

#region SP 7 - Out parameter

SqlConnection con = new SqlConnection("server=86B46DA2A2A958B;database=empDB_SP;integrated security=true;TrustServerCertificate=true");
SqlCommand cmd = new SqlCommand("proc_newDept_2", con);
cmd.CommandType = System.Data.CommandType.StoredProcedure;

//by default parameter directions are input
Console.WriteLine("Enter New Dept Name");
string dName = Console.ReadLine();
cmd.Parameters.AddWithValue("@deptName",dName);



Console.WriteLine("Enter New Dept City");
string dCity = Console.ReadLine();
cmd.Parameters.AddWithValue("@deptCity",dCity);

cmd.Parameters.Add("@deptNo", SqlDbType.Int);
cmd.Parameters["@deptNo"].Direction = ParameterDirection.Output;

con.Open();

int result = cmd.ExecuteNonQuery();

Console.WriteLine("Department Added, new Dept No : " + cmd.Parameters["@deptNo"].Value);

con.Close();

#endregion







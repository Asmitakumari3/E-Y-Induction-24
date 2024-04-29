

using HttpCclient_Calls;

PostDataAPI postData = new PostDataAPI();

#region Display all data
//var data = postData.ConsumePostData();

//foreach (var item in data)
//{
//    Console.WriteLine(item.userId);
//    Console.WriteLine(item.id);
//    Console.WriteLine(item.title);
//    Console.WriteLine(item.body);
//    Console.WriteLine("---------------------------");
//}
#endregion

#region Display Post by id

Console.WriteLine("Enter Post Id");
int id =Convert.ToInt32(Console.ReadLine());
try
{
	PostDataAPI post = postData.GetPostById(id);
    Console.WriteLine(post.id);
    Console.WriteLine(post.userId);
    Console.WriteLine(post.title);
    Console.WriteLine(post.body);
}
catch (Exception es)
{

    Console.WriteLine(es.Message);
}

#endregion


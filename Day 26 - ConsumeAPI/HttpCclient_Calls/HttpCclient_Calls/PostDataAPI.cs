using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpCclient_Calls
{
    internal class PostDataAPI
    {
        #region Properties
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        #endregion

        #region Get All Post Data
        public List<PostDataAPI> ConsumePostData()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Clear(); //clear the default calling environment data format
                                            //lets say, if call is been made from browser, they have different formats bydefault
                                            //chrome has XML as default format, EDGE has JSON as default, Safari has binary, IE has text

                                    //now we will set JSON as callling format
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //which call u want to make, GET, PUT, POST, Delete

            //1. Make a call
            var call = client.GetAsync(url);
            
            //2. store the result in a variable, when you make a call, lots of information comes 
                //like StatusCode, data, dataformat, size of data, some server info, certificate info etc.....
            var response = call.Result;

            //3. let us check the call is a success of not, we can do it useing StatusCode which came in above step
            //we will check of the status code is OK , we will read the data, else throw an error

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var data = response.Content;
                //start reading the data
                List<PostDataAPI> postdata = data.ReadAsAsync<List<PostDataAPI>>().Result;
                //we will wait till all the data comes, data comes in chunk, small pieces at the speed of internet on user end
                call.Wait();
                return postdata;
               
            }
            else
            {
                throw new Exception("Could not get the data, please contact Admin");
            }
        }
        #endregion

        public PostDataAPI GetPostById(int id)
        {
            string url = "https://jsonplaceholder.typicode.com/posts/" + id;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue ("application/json"));


            var call = client.GetAsync(url);
            var response = call.Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var data = response.Content;
                PostDataAPI  result= data.ReadAsAsync<PostDataAPI>().Result;
                call.Wait();
                return result;
            }
            else if(response.StatusCode == System.Net.HttpStatusCode.NotFound) {
                throw new Exception("Post Not Found, may be deleted or achived");
            }
            throw new Exception("PLease contact Admin");
            
            
        }
    }
}

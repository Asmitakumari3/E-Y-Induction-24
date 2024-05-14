var MongoClient = require('mongodb').MongoClient;
var url = "mongodb://nikhils-mongodbserver:1Z0t0VyDg8HwrL6V723PPF5yGYeXWTsxvSqt5gjTcOHmgZFMw3wA9vtQYuXGtOOkIexYtiTWHVXtACDblYBKEQ==@nikhils-mongodbserver.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&retrywrites=false&maxIdleTimeMS=120000&appName=@nikhils-mongodbserver@";

MongoClient.connect(url, function(err, db) {
  if (err) throw err;
  var dbo = db.db("shoppingDB");
  var myobj = {   
    "id" : "6",
    "productId" : "106",
    "pName" : "Royal Enfield",
    "pCategory" : "Noise-Machine",
    "pPrice" : 400
}
  dbo.collection("customers").insertOne(myobj, function(err, res) {
    if (err) throw err;
    console.log("1 document inserted");
    db.close();
  });
});
var MongoClient = require('mongodb').MongoClient;
var url = "mongodb://nikhils-mongodbserver:1Z0t0VyDg8HwrL6V723PPF5yGYeXWTsxvSqt5gjTcOHmgZFMw3wA9vtQYuXGtOOkIexYtiTWHVXtACDblYBKEQ==@nikhils-mongodbserver.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&retrywrites=false&maxIdleTimeMS=120000&appName=@nikhils-mongodbserver@";


MongoClient.connect(url, function(err, db) {
    console.log('here');
  if (err) throw err;
  var dbo = db.db("shoppingDB");
  
  dbo.collection("productList").find({}).toArray(function(err, result) {
    if (err) throw err;
    console.log(result);
    db.close();
  });
});
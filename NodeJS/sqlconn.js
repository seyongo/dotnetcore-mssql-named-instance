const sql = require("mssql");

var config = {
    server: "SY-BC\\SQL2014",
    database: "SampleDatabase",
    user: "sa",
    password: "Password1"    
};

sql.connect(config, function(err) {
    console.dir("Connected");
})
 
sql.on('error', function(err) {
    // ... error handler 
    console.dir(err);
})

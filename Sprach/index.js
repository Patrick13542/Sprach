//Package Declarations

var app = require('express')();
var http = require('http').Server(app);
var io = require('socket.io')(http);

//Retreive Index.html

app.get('/', function(req, res){
  res.sendFile(__dirname + '/index.html');
});

//Print message to console when user connects

io.on('connection', function(socket){
  console.log('a user connected');
});

//Set port to 3000 and log to console

http.listen(3000, function(){
  console.log('listening on *:3000');
});

//Log to console when user connects or disconnects

io.on('connection', function(socket){
  console.log('a user connected');
  socket.on('disconnect', function(){
    console.log('user disconnected');
  });
});

//Log sent messages to console

io.on('connection', function(socket){
  socket.on('chat message', function(msg){
    console.log('message: ' + msg);
  });
});

//Retreive messages and display them on webpage

io.on('connection', function(socket){
  socket.on('chat message', function(msg){
    io.emit('chat message', msg);
  });
});

//Log usernames to console

io.on('connection', function(socket){
  socket.on('username', function(use){
    console.log('username: ' + use);
  });
});

//Retreive usernames and display them on webpage

io.on('connection', function(socket){
  socket.on('username', function(use){
    io.emit('username', use);
  });
});
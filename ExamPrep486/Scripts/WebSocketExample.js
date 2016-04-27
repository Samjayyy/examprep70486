var socket;
function connect() {
    try {
        var name = prompt('what is your name?:');
        var host = "ws://localhost:56251/CapChat.ashx?name=" + name;
        var socket = new WebSocket(host);
        message('Socket Status: ' + socket.readyState);
        socket.onopen = function () {
            message('Socket Status: ' + socket.readyState + ' (open)');
        }
        socket.onmessage = function (msg) {
            message('Received: ' + msg.data);
        }
        socket.onclose = function () {
            message('Socket Status: ' + socket.readyState + ' (Closed)');
        }
        // some dumb code to illustrate events
        document.getElementById("clicker").onclick = function () {
            socket.send("clicking");
        };
        document.getElementById("closer").onclick = function () {
            socket.close();
        };
    } catch (exception) {
        message('<p>Error' + exception);
    }
}
function message(msg){
    var chat = document.getElementById("chat");
    var p = document.createElement("p");
    p.appendChild(document.createTextNode(msg));
    chat.appendChild(p);
}
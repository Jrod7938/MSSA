using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

public class Server : MonoBehaviour
{
    public const int PORT = 4793; // port for game to be played on

    private List<ServerClient> clients;
    private List<ServerClient> disconnectList;

    private TcpListener server;
    private bool serverStarted;

    /// <summary>
    /// Initializes the server by setting the GameObject to persist across scenes, creating 
    /// client lists, and starting the TCP listener on the designated port
    /// </summary>
    public void Init(){
        DontDestroyOnLoad(gameObject);
        clients = new List<ServerClient>();
        disconnectList = new List<ServerClient>();

        try {
                server = new TcpListener(IPAddress.Any, PORT); // accept connection from anyone from port 
                server.Start();

                StartListening();
                serverStarted = true;
        }catch(Exception exception){
            Debug.Log($"Socket error: {exception.Message}");
        }
    }

    /// <summary>
    /// Regularly checks for incoming data from connected clients, processes received messages,
    /// and handles client disconnections
    /// </summary>
    private void Update() {
        if (!serverStarted) return;
        foreach(ServerClient client in clients) {
            if (!IsConnected(client.tcp)) {
                client.tcp.Close();
                disconnectList.Add(client);
                continue;
            } else {
                NetworkStream stream = client.tcp.GetStream();
                if (stream.DataAvailable) {
                    StreamReader reader = new StreamReader(stream, true);

                    string data = reader.ReadLine();

                    if(data != null) {
                        OnInComingData(client, data);
                    }
                }
            }
        }

        for(int i = 0; i < disconnectList.Count - 1; i++) {
            // TODO: Let player know someone disconnected
            clients.Remove(disconnectList[i]);
            disconnectList.RemoveAt(i);
        }
    }

    /// <summary>
    /// Begins asynchronous listening for incoming TCP client connections
    /// </summary>
    private void StartListening(){
        server.BeginAcceptTcpClient(AcceptTcpClient, server);
    }

    /// <summary>
    /// Callback invoked when a new TCP client connects. It creates a new ServerClient,
    /// adds it to the clients list, and broadcasts the list of current users to the new client
    /// </summary>
    /// <param name="ar">The asynchronous result containing the listener state</param>
    private void AcceptTcpClient(IAsyncResult ar){
        TcpListener listener = (TcpListener)ar.AsyncState;

        string allUsers = "";
        foreach (ServerClient serverClient in clients) {
            allUsers += serverClient.clientName + '|';
        }

        ServerClient sc = new ServerClient(listener.EndAcceptTcpClient(ar));
        clients.Add(sc);
        
        StartListening(); // listen again after client connection

        BroadCast("SWHO|" + allUsers, clients[clients.Count - 1]);
    }

    /// <summary>
    /// Checks whether the specified TcpClient is still connected by polling its socket
    /// </summary>
    /// <param name="client">The TcpClient to check</param>
    /// <returns>True if the client is connected; else false</returns>
    private bool IsConnected(TcpClient client) {
        try {
            if(client != null && client.Client != null && client.Client.Connected) {
                if(client.Client.Poll(0, SelectMode.SelectRead)) {
                    return !(client.Client.Receive(new byte[1], SocketFlags.Peek) == 0);
                }
                return true;
            } else {
                return false;
            }
        } catch(Exception exception) {
            Debug.Log(exception.Message);
            return false;
        }
    }

    /// <summary>
    /// Broadcasts a message to a specified list of server clients
    /// </summary>
    /// <param name="data">The message to send</param>
    /// <param name="clientList">The list of clients to recieve the message</param>
    private void BroadCast(string data, List<ServerClient> clientList) { // Server Send
        foreach(ServerClient serverClient in clientList) {
            try {
                StreamWriter writer = new StreamWriter(serverClient.tcp.GetStream());
                writer.WriteLine(data);
                writer.Flush();
            } catch(Exception exception) {
                Debug.Log($"Write error: {exception.Message}");
            }
        }
    }

    /// <summary>
    /// Broadcasts a message to a single server client.
    /// </summary>
    /// <param name="data">The message to send</param>
    /// <param name="client">The target server client</param>
    private void BroadCast(string data, ServerClient client) { // Server Send
        List<ServerClient> serverClient = new List<ServerClient>() { client };
        BroadCast(data, serverClient);
    }

    /// <summary>
    /// Processes incoming data from a client by parsing the command and executing the 
    /// corresponding action, such as registering a new user or broadcasting a move
    /// </summary>
    /// <param name="serverClient">The client that sent the data</param>
    /// <param name="data">The received data string</param>
    private void OnInComingData(ServerClient serverClient, string data) { // Server Recieve
        Debug.Log("Server: " + data);
        string[] aData = data.Split('|');

        switch (aData[0]) {
            case "CWHO":
                serverClient.clientName = aData[1];
                serverClient.isHost = (aData[2] == "0") ? false : true;
                BroadCast("SCNN|" + serverClient.clientName, clients);
                break;
            case "CMOV":
                BroadCast("SMOV|" + aData[1] + "|" + aData[2] + "|" + aData[3] + "|" + aData[4], clients);
                break;
        }
    }

}

public class ServerClient{
    public string clientName;
    public TcpClient tcp;
    public bool isHost;

    /// <summary>
    /// Initializes a new instance of the ServerClient class with the specified TcpClient
    /// </summary>
    /// <param name="tcp">The TcpClient associated with this server client</param>
    public ServerClient(TcpClient tcp){
        this.tcp = tcp;
    }

}
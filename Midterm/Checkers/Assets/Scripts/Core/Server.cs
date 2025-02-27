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

    private void StartListening(){
        server.BeginAcceptTcpClient(AcceptTcpClient, server);
    }

    private void AcceptTcpClient(IAsyncResult ar){
        TcpListener listener = (TcpListener)ar.AsyncState;

        ServerClient sc = new ServerClient(listener.EndAcceptTcpClient(ar));
        clients.Add(sc);
        
        StartListening(); // listen again after client connection

        Debug.Log("Someone has connected!");
    }

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

    private void OnInComingData(ServerClient serverClient, string data) {
        Debug.Log($"{serverClient.clientName} : {data}");
    }
}

public class ServerClient{
    public string clientName;
    public TcpClient tcp;

    public ServerClient(TcpClient tcp){
        this.tcp = tcp;
    }
}
using System;
using System.IO;
using System.Net.Sockets;
using UnityEngine;

public class Client : MonoBehaviour
{

    public string clientName;
    private bool socketReady;
    private TcpClient socket;
    private NetworkStream stream;
    private StreamWriter writer;
    private StreamReader reader;

    private void Start() {
        DontDestroyOnLoad(gameObject);
    }

    public bool ConnectToServer(string host, int port) {
        if (socketReady) return false;

        try {
            socket = new TcpClient(host, port);
            stream = socket.GetStream();
            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);

            socketReady = true;
        } catch(Exception exception) {
            Debug.Log($"Socket Error: {exception.Message}");
        }

        return socketReady;
    }

    private void Update() {
        if (socketReady) {
            if (stream.DataAvailable) {
                string data = reader.ReadLine();
                if(data != null) {
                    OnIncomingData(data);
                }
            }
        }
    }

    private void OnIncomingData(string data) {
        Debug.Log(data);
    }

    private void OnApplicationQuit() {
        CloseSocket();
    }

    private void OnDisable() {
        CloseSocket();
    }

    public void Send(string data) {
        if (!socketReady) return;

        writer.WriteLine(data);
        writer.Flush();
    }
    
    private void CloseSocket() {
        if (!socketReady) return;
        writer.Close();
        reader.Close();
        socket.Close();
        socketReady = false;
    }
}

public class GameClient {
    public string name;
    public bool isHost;
}

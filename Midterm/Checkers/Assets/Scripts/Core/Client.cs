using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using UnityEngine;

public class Client : MonoBehaviour {
    public string clientName;
    public bool isHost;

    private bool socketReady;
    private TcpClient socket;
    private NetworkStream stream;
    private StreamWriter writer;
    private StreamReader reader;

    public List<GameClient> players = new List<GameClient>();

    /// <summary>
    /// Called when the client is initialized; prevents the GameObject 
    /// from being destroyed on scene load
    /// </summary>
    private void Start() {
        DontDestroyOnLoad(gameObject);
    }

    /// <summary>
    /// Monitors the network stream for incoming data and processes it if available
    /// </summary>
    private void Update() {
        if (socketReady) {
            if (stream.DataAvailable) {
                string data = reader.ReadLine();
                if (data != null) {
                    OnIncomingData(data);
                }
            }
        }
    }

    /// <summary>
    /// Attempts to establish a TCP connection to the specified server 
    /// host and port.
    /// </summary>
    /// <param name="host">The server hostname or IP address</param>
    /// <param name="port">The port number to connect to</param>
    /// <returns>True if the connection is successfully established; otherwise,
    /// false</returns>
    public bool ConnectToServer(string host, int port) {
        if (socketReady) return false;

        try {
            socket = new TcpClient(host, port);
            stream = socket.GetStream();
            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);

            socketReady = true;
        } catch (Exception exception) {
            Debug.Log($"Socket Error: {exception.Message}");
        }

        return socketReady;
    }

    /// <summary>
    /// Processes incoming data from the server and executes corresponding actions 
    /// based on the command prefix
    /// </summary>
    /// <param name="data">The raw data string received from the server</param>
    private void OnIncomingData(string data) {
        Debug.Log("Client: " + data);
        string[] aData = data.Split('|');

        switch (aData[0]) {
            case "SWHO":
                for (int i = 1; i < aData.Length - 1; i++) {
                    UserConnected(aData[i], false);
                }
                Send("CWHO|" + clientName + "|" + ((isHost) ? 1 : 0).ToString());
                break;
            case "SCNN":
                UserConnected(aData[1], false);
                break;
            case "SMOV":
                CheckersBoard.Instance.TryMove(int.Parse(aData[1]), int.Parse(aData[2]), int.Parse(aData[3]), int.Parse(aData[4]));
                break;
        }
    }

    /// <summary>
    /// Handles a new user connection by creating a new GameClient instance, adding 
    /// it to the players list, and starting the game if two players are connected
    /// <param name="name">The name of the connected user</param>
    /// <param name="isHost">Indicates if the user is the host</param>
    private void UserConnected(string name, bool isHost) {
        GameClient client = new GameClient();
        client.name = name;

        players.Add(client);

        if (players.Count == 2) {
            GameManager.Instance.StartGame();
        }
    }

    /// <summary>
    /// Closes the network connection when the application quits
    /// </summary>
    private void OnApplicationQuit() {
        CloseSocket();
    }

    /// <summary>
    /// Closes the network connection when the client is disabled
    /// </summary>
    private void OnDisable() {
        CloseSocket();
    }

    /// <summary>
    /// Sends a data string to the server via the established TCP connection, if the 
    /// socket is ready
    /// </summary>
    /// <param name="data">The data to send</param>
    public void Send(string data) {
        if (!socketReady) return;

        writer.WriteLine(data);
        writer.Flush();
    }

    /// <summary>
    /// Closes the network stream, writer, and socket connection to properly terminate 
    /// communication
    /// </summary>
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

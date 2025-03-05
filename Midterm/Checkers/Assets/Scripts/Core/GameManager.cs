using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager Instance { set; get; }
    public static bool VersusAI = false;

    public GameObject menu;
    public GameObject connectMenu;
    public GameObject hostMenu;

    public GameObject serverPrefab;
    public GameObject clientPrefab;

    public TMP_InputField nameInput;

    /// <summary>
    /// Initializes the GameManager instance, sets up the menu UI, and ensures persistence 
    /// across scenes
    /// </summary>
    private void Start() {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        menu.SetActive(true);
        connectMenu.SetActive(false);
        hostMenu.SetActive(false);
    }

    /// <summary>
    /// Activates the connection menu and hides the main menu when the Connect button is pressed
    /// </summary>
    public void ConnectButton() {
        Debug.Log("Connect Button");
        menu.SetActive(false);
        connectMenu.SetActive(true);
    }

    /// <summary>
    /// Instantiates the server and client for hosting a game, then switches to the host menu
    /// </summary>
    public void HostButton() {
        Debug.Log("Host Button");
        try {
            Server server = Instantiate(serverPrefab).GetComponent<Server>();
            server.Init();

            Client client = Instantiate(clientPrefab).GetComponent<Client>();
            client.clientName = nameInput.text;
            client.isHost = true;
            if (client.clientName == "") client.clientName = "Host";
            client.ConnectToServer("127.0.0.1", 4793); // connect to server self
        } catch (Exception exception) {
            Debug.Log(exception.Message);
        }
        menu.SetActive(false);
        hostMenu.SetActive(true);
    }

    /// <summary>
    /// Activates solo play mode versus AI and loads the Checkers game scene
    /// </summary>
    public void SoloButton() {
        Debug.Log("Solo Button - Versus AI Mode");
        VersusAI = true;
        SceneManager.LoadScene("CheckersGame");
    }

    /// <summary>
    /// Attempts to connect to a server using the provided host address and then hides the 
    /// connection menu
    /// </summary>
    public void ConnectToServerButton() {
        Debug.Log("Attempting to Connect to Server");
        string hostAddress = GameObject.Find("HostInput").GetComponent<TMP_InputField>().text;
        if (hostAddress == "") hostAddress = "127.0.0.1";

        try {
            Client client = Instantiate(clientPrefab).GetComponent<Client>();
            client.clientName = nameInput.text;
            if (client.clientName == "") client.clientName = "Client";
            client.ConnectToServer(hostAddress, 4793);
            connectMenu.SetActive(false);
        } catch (Exception exception) {
            Debug.Log(exception.Message);
        }
    }

    /// <summary>
    /// Returns to the main menu by deactivating connection/host menus and destroying any existing 
    /// server/client instances
    /// </summary>
    public void BackButton() {
        Debug.Log("Back Button");
        connectMenu.SetActive(false);
        hostMenu.SetActive(false);
        menu.SetActive(true);

        Server server = FindAnyObjectByType<Server>();
        if (server != null) Destroy(server.gameObject);

        Client client = FindAnyObjectByType<Client>();
        if (client != null) Destroy(client.gameObject);
    }

    /// <summary>
    /// Loads the Checkers game scene to start the game
    /// </summary>
    public void StartGame() {
        SceneManager.LoadScene("CheckersGame");
    }

}

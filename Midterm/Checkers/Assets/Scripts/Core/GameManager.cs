using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { set; get; }

    public GameObject menu;
    public GameObject connectMenu;
    public GameObject hostMenu;

    public GameObject serverPrefab;
    public GameObject clientPrefab;

    public TMP_InputField nameInput;

    private void Start() {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        menu.SetActive(true);
        connectMenu.SetActive(false);
        hostMenu.SetActive(false);
    }

    public void ConnectButton() {
        Debug.Log("Connect Button");
        menu.SetActive(false);
        connectMenu.SetActive(true);
    }

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
        }catch(Exception exception) {
            Debug.Log(exception.Message);
        }
    }

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

    public void StartGame() {
        SceneManager.LoadScene("CheckersGame");
    }
}

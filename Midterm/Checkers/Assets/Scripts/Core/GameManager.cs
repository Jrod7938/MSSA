using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { set; get; }

    public GameObject menu;
    public GameObject connectMenu;
    public GameObject hostMenu;

    private void Start() {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        menu.SetActive(true);
        connectMenu.SetActive(false);
        hostMenu.SetActive(false);
    }

    public void ConnectButton() {
        menu.SetActive(false);
        connectMenu.SetActive(true);
        Debug.Log("Connect");
    }

    public void HostButton() {
        menu.SetActive(false);
        hostMenu.SetActive(true);
        Debug.Log("Host");
    }

    public void ConnectToServerButton() {
        Debug.Log("Connect to Server");
    }

    public void BackButton() {
        Debug.Log("Back");
        connectMenu.SetActive(false);
        hostMenu.SetActive(false);
        menu.SetActive(true);
    }
}

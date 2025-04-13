using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NetworkManager : MonoBehaviourPunCallbacks
{
    public static NetworkManager inst;
    private bool isConnected = false;
    private void Awake()
    {
        if (inst == null) inst = this;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        isConnected = true;
        PhotonNetwork.JoinLobby(); 
    }
    public void Createroom(string roomName)
    {
        if (!isConnected) return;
        PhotonNetwork.CreateRoom(roomName, new RoomOptions { MaxPlayers = 2 });
    }
    public void Joinroom(string roomName)
    {
        if (!isConnected) return;
        PhotonNetwork.JoinRoom(roomName);
    }
    public override void OnJoinedRoom()
    {
        SceneManager.LoadScene("MainScene");
    }
}

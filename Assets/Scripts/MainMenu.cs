using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField roomName;

    public void OnCreateRoom()
    {
        NetworkManager.inst.Createroom(roomName.text);
    }

    public void OnJoinRoom()
    {
        NetworkManager.inst.Joinroom(roomName.text);
    }
}

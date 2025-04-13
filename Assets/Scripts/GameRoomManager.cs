using Photon.Pun;
using UnityEngine;
public class GameRoomManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public string prefabName = "SyncAvatar";
    void Start()
    {
        int i = PhotonNetwork.LocalPlayer.ActorNumber - 1; 
        i = Mathf.Clamp(i, 0, spawnPoints.Length - 1);
        Vector3 spawnPos = spawnPoints[i].transform.position;
        PhotonNetwork.Instantiate(prefabName, spawnPos, Quaternion.identity);
    }
}

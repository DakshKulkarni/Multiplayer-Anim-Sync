using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIControl : MonoBehaviour
{
    public TMP_Dropdown choose;
    public Slider playback;
    private PhotonView[] players;
    void Start()
    {
        if (!PhotonNetwork.IsMasterClient)
        {
            choose.gameObject.SetActive(false);
            playback.gameObject.SetActive(false);
            return;
        }
        choose.onValueChanged.AddListener(OnAnimationChanged);
        playback.onValueChanged.AddListener(OnTimelineChanged);
        players = FindObjectsOfType<PhotonView>();
    }
    void OnAnimationChanged(int index)
    {
        string animName = choose.options[index].text;
        foreach (var view in players)
        {
            view.RPC("RPC_PlayAnimation", RpcTarget.AllBuffered, animName);
        }
    }
    void OnTimelineChanged(float value)
    {
        foreach (var view in players)
        {
            view.RPC("RPC_SeekTo", RpcTarget.All, value);
        }
    }
}

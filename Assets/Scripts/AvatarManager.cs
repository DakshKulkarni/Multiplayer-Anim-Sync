using Photon.Pun;
using UnityEngine;
public class AvatarManager : MonoBehaviourPun
{
    public GameObject rig;       
    public Camera cam;        
    void Start()
    {
        if (!photonView.IsMine)
        {
            if (rig != null) 
            rig.SetActive(false);
            if (cam != null)
            {
                cam.enabled = false;
                AudioListener listener = cam.GetComponent<AudioListener>();
                if (listener != null) listener.enabled = false;
            }
        }
    }
}

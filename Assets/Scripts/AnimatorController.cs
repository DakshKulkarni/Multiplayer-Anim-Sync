using Photon.Pun;
using UnityEngine;
public class AnimatorController : MonoBehaviourPun
{
    public Animator animator;
    private string currentAnim = "Idle";
    private float currTime = 0f;
    void Update()
    {
        if (!photonView.IsMine || !PhotonNetwork.IsMasterClient) return;
        currTime += Time.deltaTime;
    }
    [PunRPC]
   public void RPC_PlayAnimation(string animName)
{
    if (animator.GetCurrentAnimatorStateInfo(0).IsName(animName))
    {
        animator.Play("Idle"); 
    }
    currentAnim = animName;
    currTime = 0f;
    animator.Play(currentAnim, 0, 0f);
}
    [PunRPC]
    public void RPC_SeekTo(float normalizedTime)
    {
        float length = animator.GetCurrentAnimatorStateInfo(0).length;
        animator.Play(currentAnim, 0, normalizedTime);
        currTime = normalizedTime * length;
    }
}

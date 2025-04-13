using UnityEngine;
using TMPro;
using Photon.Pun;
public class JointMovement : MonoBehaviourPunCallbacks
{
    public Transform leftUpperArm;
    public Transform leftArm;
    public Transform rightThigh;
    public Transform rightCalf;
    private TextMeshProUGUI jointText;
    private TextMeshProUGUI postureText;
    private TextMeshProUGUI animText;
    public Animator animator;
    void Start()
    {
        jointText = GameObject.FindWithTag("JointText")?.GetComponent<TextMeshProUGUI>();
        postureText = GameObject.FindWithTag("PostureText")?.GetComponent<TextMeshProUGUI>();
        animText = GameObject.FindWithTag("MotionText")?.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        float leftElbow = Vector3.Angle(leftUpperArm.forward, leftArm.forward);
        float rightKnee = Vector3.Angle(rightThigh.forward, rightCalf.forward);
        if (jointText != null)
            jointText.text = $"Left Elbow: {leftElbow:F1}°\nRight Knee: {rightKnee:F1}°";
        if (postureText != null)
            postureText.text = $"{Arm(leftElbow)}\n{Leg(rightKnee)}";
        if (animText != null)
        {
            AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
            animText.text = $"Current Anim: {animName(state)}";
        }
    }
    string Arm(float angle)
    {
        if (angle > 150f) return "Left Arm: Extended";
        else if (angle > 90f) return "Left Arm: Raised";
        else return "Left Arm: Bent";
    }
    string Leg(float angle)
    {
        if (angle < 70f) return "Right Leg: Stomping";
        else if (angle > 160f) return "Right Leg: Standing";
        else return "Right Leg: Moving";
    }
    string animName(AnimatorStateInfo state)
    {
        if (state.IsName("Idle")) return "Idle";
        if (state.IsName("Walk")) return "Walk";
        if (state.IsName("Run")) return "Run";
        if (state.IsName("Jump")) return "Jump";
        return "Unknown";
    }
}

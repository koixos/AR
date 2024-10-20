using UnityEngine;

public class AImageCheck : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ArriveScale()
    {
        animator.SetTrigger("ATrigger");
        animator.ResetTrigger("AReverse");
    }

    public void ArriveScaleDown()
    {
        animator.SetTrigger("AReverse");
        animator.ResetTrigger("ATrigger");
    }
}

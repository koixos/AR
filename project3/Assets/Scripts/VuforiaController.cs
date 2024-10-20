using UnityEngine;
using Vuforia;

public class VuforiaController : MonoBehaviour
{
    public void EnableVuforia()
    {
        VuforiaBehaviour.Instance.enabled = true;
    }

    public void DisableVuforia()
    {
        VuforiaBehaviour.Instance.enabled = false;
    }
}

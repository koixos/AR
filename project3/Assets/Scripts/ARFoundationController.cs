using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARFoundation;

public class ARFoundationController : MonoBehaviour
{
    public ARSession arSession;
    public XROrigin origin;

    public void EnableARFoundation()
    {
        arSession.enabled = true;
        origin.enabled = true;
    }

    public void DisableARFoundation()
    {
        arSession.enabled = false;
        origin.enabled = false;
    }
}

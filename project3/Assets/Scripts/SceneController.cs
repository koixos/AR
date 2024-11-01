using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using Vuforia;

public class SceneController : MonoBehaviour
{
    /*public ARSession arSession = null;
    public XROrigin origin = null;

    private bool isVuforiaActive = false;
    private bool isARFoundationActive = false;

    private void Awake()
    {
        ManageSDKs(SceneManager.GetActiveScene().name);
    }*/

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    /*private void ManageSDKs(string sceneName)
    {
        if (sceneName.Contains("Vuforia"))
        {
            EnableVuforia();
        }
        else if (sceneName.Contains("ARFoundation"))
        {
            EnableARFoundation();
        }
        else
        {
            DisableAll();
        }
    }

    private void EnableVuforia()
    {
        if (!isVuforiaActive)
        {
            if (VuforiaBehaviour.Instance != null)
            {
                VuforiaBehaviour.Instance.enabled = true;
                isVuforiaActive = true;
            }

            if (arSession != null)
            {
                arSession.enabled = false;
            }

            if (origin != null)
            {
                origin.enabled = false;
            }
        }
    }

    private void EnableARFoundation()
    {
        if (!isARFoundationActive)
        {
            if (VuforiaBehaviour.Instance != null)
            {
                VuforiaBehaviour.Instance.enabled = false;
            }

            if (arSession != null)
            {
                arSession.enabled = true;
            }

            if (origin != null)
            {
                origin.enabled = true;
            }

            isARFoundationActive = true;
        }
    }

    private void DisableAll()
    {
        if (VuforiaBehaviour.Instance != null)
        {
            VuforiaBehaviour.Instance.enabled = false; 
            isVuforiaActive = false; 
        }

        if (arSession != null)
        {
            arSession.enabled = false; 
        }

        if (origin != null)
        {
            origin.enabled = false; 
        }

        isARFoundationActive = false;
    }*/
}

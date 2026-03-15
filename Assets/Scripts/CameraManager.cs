using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [Header("Cameras")]
    public Camera playerCamera;
    public Camera overviewCamera;

    [Header("Settings")]
    public KeyCode switchKey = KeyCode.Tab;

    private bool isPlayerCamActive = false;

    void Start()
    {
        // Ensure correct camera is active at start
        playerCamera.gameObject.SetActive(false);
        overviewCamera.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            ToggleCamera();
        }
    }

    public void ToggleCamera()
    {
        isPlayerCamActive = !isPlayerCamActive;
        playerCamera.gameObject.SetActive(isPlayerCamActive);
        overviewCamera.gameObject.SetActive(!isPlayerCamActive);
    }

    // Call this from UI buttons or other scripts
    public void SetCamera(bool usePlayerCam)
    {
        isPlayerCamActive = usePlayerCam;
        playerCamera.gameObject.SetActive(isPlayerCamActive);
        overviewCamera.gameObject.SetActive(!isPlayerCamActive);
    }
}

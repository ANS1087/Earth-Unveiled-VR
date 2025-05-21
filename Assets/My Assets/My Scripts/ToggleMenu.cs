using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    public GameObject menuCanvas;  // Assign the Canvas in the Inspector

    public void ToggleMenuVisibility()
    {
        // Toggle the active state based on the current state
        bool newState = !menuCanvas.activeSelf;
        menuCanvas.SetActive(newState);
    }
}

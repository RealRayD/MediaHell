using UnityEngine;

public class CursorManager : MonoBehaviour
{
    void Start()
    {
        // Hide and lock the cursor at the start of the scene
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnEnable()
    {
        // Ensure the cursor remains hidden and locked when the object is enabled
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}

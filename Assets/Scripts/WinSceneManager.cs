using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Make the cursor visible and unlock it
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

}

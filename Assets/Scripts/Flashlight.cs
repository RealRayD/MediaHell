using UnityEngine;
using UnityEngine.InputSystem;

namespace StarterAssets
{
    public class Flashlight : MonoBehaviour
    {
        [SerializeField] private GameObject flashlightLight;
        private bool flashlightActive = false;

        private PlayerInput playerInput;

        private void Start()
        {
            // Ensure the flashlight starts turned off
            flashlightLight.SetActive(false);

            // Get reference to PlayerInput component
            playerInput = GetComponent<PlayerInput>();
        }

        private void Update()
        {
            // Check for input to toggle flashlight
            if (playerInput.actions["Flash"].triggered)
            {
                ToggleFlashlight();
            }
        }

        void ToggleFlashlight()
        {
            // Toggle the flashlight active state
            flashlightActive = !flashlightActive;

            // Activate/deactivate the spotlight accordingly
            flashlightLight.SetActive(flashlightActive);

            // Optionally, you can add more functionality here
            // For example, play sound effects, animations, etc.
        }
    }
}

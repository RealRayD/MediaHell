using UnityEngine;

public class GameEnd : MonoBehaviour
{
    private CollectibleCount collectibleCount;

    void Start()
    {
        // Find the CollectibleCount script in the scene
        collectibleCount = FindObjectOfType<CollectibleCount>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the player enters the room
        if (other.CompareTag("Player"))
        {
            // Check if the player has collected all the collectibles
            if (collectibleCount.Count == Collectible.total)
            {
                EndGame();
            }
        }
    }

    void EndGame()
    {
        Debug.Log("Game Ended! Congratulations, you've collected all the items.");
        // Add any additional logic for ending the game, such as displaying a UI message or transitioning to an end scene
        // Example: SceneManager.LoadScene("EndScene");
    }
}

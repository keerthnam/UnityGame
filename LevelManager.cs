using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Call this method to load the next level
    public void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Check if the next scene index exceeds the number of scenes in your build settings
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            // Optionally, load the first level or a specific scene like a main menu if there are no more levels
            Debug.Log("No more levels to load. Loading first level or main menu.");
            SceneManager.LoadScene(0); // Replace 0 with the index of your main menu or first level
        }
    }
}
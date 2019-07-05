using UnityEngine;

namespace Mantelabs.JackTheGiant.Controllers
{
    public class GameplayController : MonoBehaviour
    {
        public void PauseGame()
        {
            Debug.Log("Pause the game...");
        }


        public void ResumeGame()
        {
            Debug.Log("Resume the game...");
        }


        public void QuitGame()
        {
            Debug.Log("Go to Main menu...");
        }
    }
}

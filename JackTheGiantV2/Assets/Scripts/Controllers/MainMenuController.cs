using UnityEngine;

namespace Mantelabs.JackTheGiant.Controllers
{
    public class MainMenuController : MonoBehaviour
    {
        public void StartGame()
        {
            Debug.Log("Starting the game...");
        }


        public void Highscore()
        {
            Debug.Log("Launching the highscore screen...");
        }


        public void Options()
        {
            Debug.Log("Launching the options screen...");
        }


        public void QuitGame()
        {
            Debug.Log("Quitting the game...");
        }
    }
}

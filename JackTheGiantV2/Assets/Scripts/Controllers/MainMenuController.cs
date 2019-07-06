using UnityEngine;

namespace Mantelabs.JackTheGiant.Controllers
{
    public class MainMenuController : MonoBehaviour
    {
        public void StartGame()
        {
            SceneFaderController.instance.LoadScene("Gameplay");
        }


        public void Highscore()
        {
            SceneFaderController.instance.LoadScene("Highscore");
        }


        public void Options()
        {
            SceneFaderController.instance.LoadScene("Options");
        }


        public void QuitGame()
        {
            Application.Quit();
        }
    }
}

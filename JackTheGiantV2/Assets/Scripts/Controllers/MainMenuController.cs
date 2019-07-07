using UnityEngine;

namespace Mantelabs.JackTheGiant.Controllers
{
    public class MainMenuController : MonoBehaviour
    {
        public void StartGame()
        {
            SceneFaderController.instance.LoadScene(Utils.Tags.Scenes.Gameplay);
        }


        public void Highscore()
        {
            SceneFaderController.instance.LoadScene(Utils.Tags.Scenes.Highscore);
        }


        public void Options()
        {
            SceneFaderController.instance.LoadScene(Utils.Tags.Scenes.Options);
        }


        public void QuitGame()
        {
            Application.Quit();
        }
    }
}

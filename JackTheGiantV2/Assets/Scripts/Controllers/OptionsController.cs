using UnityEngine;

namespace Mantelabs.JackTheGiant.Controllers
{
    public class OptionsController : MonoBehaviour
    {
        public void SetEasyDifficulty()
        {
            Debug.Log("Easy difficulty set.");
        }


        public void SetMediumDifficulty()
        {
            Debug.Log("Medium difficulty set.");
        }


        public void SetHardDifficulty()
        {
            Debug.Log("Hard difficulty set.");
        }


        public void GoBackToMainMenu()
        {
            Debug.Log("Going back to main menu.");
        }
    }
}

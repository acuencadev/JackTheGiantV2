using UnityEngine;

namespace Mantelabs.JackTheGiant.Controllers
{
    public class OptionsController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _easySign, _mediumSign, _hardSign;


        private void Start()
        {
            //TODO: Pull the current difficulty from the PlayerPrefs.
            SetMediumDifficulty();
        }


        public void SetEasyDifficulty()
        {
            _easySign.SetActive(true);
            _mediumSign.SetActive(false);
            _hardSign.SetActive(false);
        }


        public void SetMediumDifficulty()
        {
            _easySign.SetActive(false);
            _mediumSign.SetActive(true);
            _hardSign.SetActive(false);
        }


        public void SetHardDifficulty()
        {
            _easySign.SetActive(false);
            _mediumSign.SetActive(false);
            _hardSign.SetActive(true);
        }


        public void GoBackToMainMenu()
        {
            SceneFaderController.instance.LoadScene(Utils.Tags.Scenes.MainMenu);
        }
    }
}

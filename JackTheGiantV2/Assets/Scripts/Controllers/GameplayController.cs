using UnityEngine;

namespace Mantelabs.JackTheGiant.Controllers
{
    public class GameplayController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _pauseButton, _pausePanel, _readyButton, _hud;


        public void StartGame()
        {
            _hud.SetActive(true);
            _pauseButton.SetActive(true);
            _readyButton.SetActive(false);
        }


        public void PauseGame()
        {
            _pauseButton.SetActive(false);
            _pausePanel.SetActive(true);

            Time.timeScale = 0f;
        }


        public void ResumeGame()
        {
            _pauseButton.SetActive(true);
            _pausePanel.SetActive(false);

            Time.timeScale = 1f;
        }


        public void QuitGame()
        {
            Debug.Log("Go to Main menu...");
        }
    }
}

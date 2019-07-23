using Mantelabs.JackTheGiant.Managers;
using Mantelabs.JackTheGiant.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mantelabs.JackTheGiant.Controllers
{
    public class GameplayController : MonoBehaviour
    {
        public static GameplayController instance;

        [SerializeField]
        private GameObject _pauseButton, _pausePanel, _readyButton, _hud;

        [SerializeField]
        private Text _lifeText, _coinText, scoreText;


        private void Awake()
        {
            if (instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                instance = this;
            }
        }


        public void StartGame()
        {
            _hud.SetActive(true);
            _pauseButton.SetActive(true);
            _readyButton.SetActive(false);
            GameManager.instance.gameStatus = GameStatus.Playing;
        }


        public void PauseGame()
        {
           _pauseButton.SetActive(false);
            _pausePanel.SetActive(true);

            GameManager.instance.gameStatus = GameStatus.Paused;
        }


        public void ResumeGame()
        {
            _pauseButton.SetActive(true);
            _pausePanel.SetActive(false);

            GameManager.instance.gameStatus = GameStatus.Playing;
        }


        public void QuitGame()
        {
            SceneFaderController.instance.LoadScene(Tags.Scenes.MainMenu);
        }
    }
}

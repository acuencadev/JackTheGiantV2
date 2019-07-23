using Mantelabs.JackTheGiant.Controllers;
using Mantelabs.JackTheGiant.Utils;
using UnityEngine;

namespace Mantelabs.JackTheGiant.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public GameStatus gameStatus;

        [HideInInspector]
        public int score;

        [HideInInspector]
        public int lives;

        [SerializeField]
        private int _initialLives;

        [SerializeField]
        private GameObject _playerPrefab;


        private void Awake()
        {
            MakeSingleton();
        }


        private void Start()
        {
            gameStatus = GameStatus.Paused;
        }


        private void MakeSingleton()
        {
            if (instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                instance = this;
                DontDestroyOnLoad(gameObject);

                lives = _initialLives;
            }
        }


        public void InstantiatePlayerAtPosition(Vector3 pos)
        {
            pos.y += 0.5f;
            Instantiate(_playerPrefab, pos, Quaternion.identity);
        }


        public void PlayerDie()
        {
            gameStatus = GameStatus.Paused;
            lives--;

            if (lives <= 0)
            {
                SceneFaderController.instance.LoadScene(Tags.Scenes.MainMenu);
            }
            else
            {
                SceneFaderController.instance.LoadScene(Tags.Scenes.Gameplay);
            }
        }
    }
}

using Mantelabs.JackTheGiant.Utils;
using UnityEngine;

namespace Mantelabs.JackTheGiant.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public GameStatus gameStatus;

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
            }
        }


        public void InstantiatePlayerAtPosition(Vector3 pos)
        {
            pos.y += 0.5f;
            Instantiate(_playerPrefab, pos, Quaternion.identity);
        }
    }
}

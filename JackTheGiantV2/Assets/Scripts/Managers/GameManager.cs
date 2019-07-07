using Mantelabs.JackTheGiant.Utils;
using UnityEngine;

namespace Mantelabs.JackTheGiant.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public GameStatus gameStatus;


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
    }
}

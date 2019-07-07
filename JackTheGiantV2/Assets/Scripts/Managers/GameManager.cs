using UnityEngine;

namespace Mantelabs.JackTheGiant.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public Utils.GameStatus gameStatus;


        private void Awake()
        {
            MakeSingleton();
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

using UnityEngine;

namespace Mantelabs.JackTheGiant.Managers
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicManager : MonoBehaviour
    {
        public static MusicManager instance;

        [SerializeField]
        private AudioSource _backgroundMusicSource;


        private void Awake()
        {
            MakeSingleton();
        }


        private void Start()
        {
            //TODO: Remove this, play music ONLY when the setting is ON.
            PlayBackgroundMusic();
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


        public void PlayBackgroundMusic()
        {
            _backgroundMusicSource.Play();
        }


        public void StopBackgroundMusic()
        {
            _backgroundMusicSource.Stop();
        }
    }
}

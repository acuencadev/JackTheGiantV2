using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mantelabs.JackTheGiant.Controllers
{
    [RequireComponent(typeof(Animator))]
    public class SceneFaderController : MonoBehaviour
    {
        public static SceneFaderController instance;

        [SerializeField]
        private GameObject _sceneFaderPanel;

        private Animator _animator;


        private void Awake()
        {
            MakeSingleton();
            _animator = _sceneFaderPanel.GetComponent<Animator>();
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


        private IEnumerator LoadSceneAsync(string scene)
        {
            _sceneFaderPanel.SetActive(true);
            _animator.Play("SceneFader_FadeIn");

            yield return new WaitForSeconds(1f);

            SceneManager.LoadScene(scene);

            _animator.Play("SceneFader_FadeOut");

            yield return new WaitForSeconds(1f);

            _sceneFaderPanel.SetActive(false);
        }


        public void LoadScene(string scene)
        {
            StartCoroutine(LoadSceneAsync(scene));
        }
    }
}

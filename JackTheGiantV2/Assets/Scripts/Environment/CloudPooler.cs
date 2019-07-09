using Mantelabs.JackTheGiant.Utils;
using UnityEngine;

namespace Mantelabs.JackTheGiant.Environment
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class CloudPooler : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] _cloudPrefabs;

        [SerializeField]
        [Range(1, 10)]
        private int _cloudPoolSize;

        [SerializeField]
        [Range(0.5f, 3f)]
        private float _distanceBetweenClouds;

        private float _lastY;


        private void Start()
        {
            InitializePool();
        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.GameObjects.Cloud) || other.CompareTag(Tags.GameObjects.DarkCloud))
            {
                //TODO: Collect the cloud.
            }
        }


        private void InitializePool()
        {
            GameObject initialCloud = Instantiate(_cloudPrefabs[0], Vector3.zero, Quaternion.identity);

            _lastY = initialCloud.transform.position.y;

            for (int i = 0; i < _cloudPoolSize; i++)
            {
                Vector3 newPos = new Vector3(0f, _lastY - _distanceBetweenClouds, 0f);
                int prefabIndex = Random.Range(0, _cloudPrefabs.Length);
                GameObject newCloud = Instantiate(_cloudPrefabs[prefabIndex], newPos, Quaternion.identity);

                _lastY = newPos.y;
            }
        }
    }
}

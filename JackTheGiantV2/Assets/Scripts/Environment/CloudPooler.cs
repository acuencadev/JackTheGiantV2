using Mantelabs.JackTheGiant.Utils;
using UnityEngine;

namespace Mantelabs.JackTheGiant.Environment
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class CloudPooler : MonoBehaviour
    {
        [Header("Cloud Prefabs")]
        [SerializeField]
        private GameObject[] _cloudPrefabs;

        [SerializeField]
        private GameObject _darkCloudPrefab;

        [Header("Pooling options")]
        [SerializeField]
        [Range(1, 10)]
        private int _cloudPoolSize;

        [SerializeField]
        [Range(0.5f, 5f)]
        private float _minDistanceBetweenClouds;

        [SerializeField]
        [Range(0.5f, 5f)]
        private float _maxDistanceBetweenClouds;

        [SerializeField]
        [Range(0f, 1f)]
        private float _darkCloudSpawnChance;


        private float _lastY;


        private void Start()
        {
            InitializePool();
        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag(Tags.GameObjects.Cloud) || other.CompareTag(Tags.GameObjects.DarkCloud))
            {
                if (other.transform.position.x == 0f)
                {
                    Destroy(other.gameObject);
                }
                else
                {
                    SetNewPosition(other.gameObject);
                }
            }
        }


        private void InitializePool()
        {
            GameObject initialCloud = Instantiate(_cloudPrefabs[0], Vector3.zero, Quaternion.identity);

            _lastY = initialCloud.transform.position.y;

            for (int i = 0; i < _cloudPoolSize; i++)
            {
                float distanceBetweenClouds = Random.Range(_minDistanceBetweenClouds, _maxDistanceBetweenClouds);
                float alternateXPosition = i % 2 == 0 ? 2.5f : -2.5f;

                Vector3 newPos = new Vector3(alternateXPosition, _lastY - distanceBetweenClouds, 0f);
                int prefabIndex = Random.Range(0, _cloudPrefabs.Length);

                GameObject newCloud = Instantiate(_cloudPrefabs[prefabIndex], newPos, Quaternion.identity);

                _lastY = newPos.y;
            }
        }


        private void SetNewPosition(GameObject cloud)
        {
            float distanceBetweenClouds = Random.Range(_minDistanceBetweenClouds, _maxDistanceBetweenClouds);
            Vector3 currentPos = cloud.transform.position;

            currentPos.y = _lastY - distanceBetweenClouds;
            _lastY = currentPos.y;

            cloud.transform.position = currentPos;
        }
    }
}

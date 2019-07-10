using Mantelabs.JackTheGiant.Utils;
using UnityEngine;

namespace Mantelabs.JackTheGiant.Environment
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class BGPooler : MonoBehaviour
    {
        private GameObject[] _backgrounds;

        private float _lastY;


        private void Awake()
        {
            _backgrounds = GameObject.FindGameObjectsWithTag(Tags.GameObjects.Background);
        }


        private void Start()
        {
            InitializeLastY();
        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.GameObjects.Background))
            {
                SetNewPosition(other);
            }
        }


        private void InitializeLastY()
        {
            for (int i = 0; i < _backgrounds.Length; i++)
            {
                if (_lastY > _backgrounds[i].transform.position.y)
                {
                    _lastY = _backgrounds[i].transform.position.y;
                }
            }
        }


        private void SetNewPosition(Collider2D collider)
        {
            Vector3 currentPos = collider.gameObject.transform.position;
            float height = collider.bounds.size.y;

            currentPos.y = _lastY - height;
            _lastY = currentPos.y;

            collider.gameObject.transform.position = currentPos;
        }
    }
}

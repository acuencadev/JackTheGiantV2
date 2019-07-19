using Mantelabs.JackTheGiant.Managers;
using Mantelabs.JackTheGiant.Utils;
using UnityEngine;

namespace Mantelabs.JackTheGiant.Environment
{
    public class DarkCloud : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 2f;

        [SerializeField]
        private float _minX, _maxX;

        private bool _movingLeft;


        private void Update()
        {
            if (_movingLeft)
            {
                transform.Translate(Vector3.left * _speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.right * _speed * Time.deltaTime);
            }

            if (transform.position.x <= _minX)
            {
                _movingLeft = false;
            }

            if (transform.position.x >= _maxX)
            {
                _movingLeft = true;
            }
        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.GameObjects.Player))
            {
                GameManager.instance.PlayerDie();
            }
        }
    }
}

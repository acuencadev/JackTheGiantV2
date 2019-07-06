using UnityEngine;

namespace Mantelabs.JackTheGiant.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private float _speed;

        private Rigidbody2D _rb2d;


        private void Awake()
        {
            _rb2d = GetComponent<Rigidbody2D>();
        }


        private void FixedUpdate()
        {
            float h = Input.GetAxis("Horizontal");

            if (h > 0f)
            {
                MovePlayer(Vector2.right);
            }
            else if (h < 0f)
            {
                MovePlayer(Vector2.left);
            }
        }


        private void MovePlayer(Vector2 direction)
        {
            _rb2d.AddForce(direction * _speed * Time.deltaTime);
        }
    }
}
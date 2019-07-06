using UnityEngine;

namespace Mantelabs.JackTheGiant.Player
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private float _speed;

        private Animator _animator;
        private Rigidbody2D _rb2d;


        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _rb2d = GetComponent<Rigidbody2D>();
        }


        private void FixedUpdate()
        {
            float h = Input.GetAxis("Horizontal");

            if (h > 0f)
            {
                MovePlayer(Vector2.right);
                Flip(1);
                _animator.SetBool("Moving", true);
            }
            else if (h < 0f)
            {
                MovePlayer(Vector2.left);
                Flip(-1);
                _animator.SetBool("Moving", true);
            }
            else
            {
                _animator.SetBool("Moving", false);
            }
        }


        private void MovePlayer(Vector2 direction)
        {
            _rb2d.AddForce(direction * _speed * Time.deltaTime);
        }


        private void Flip(int direction)
        {
            Vector3 theScale = transform.localScale;
            theScale.x = direction;
            transform.localScale = theScale;
        }
    }
}
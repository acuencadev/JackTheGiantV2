using UnityEngine;

namespace Mantelabs.JackTheGiant.Environment
{
    public class PlayerDeathZone : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                //TODO: Stop the game.
            }
        }
    }
}

using Mantelabs.JackTheGiant.Utils;
using UnityEngine;

namespace Mantelabs.JackTheGiant.Background
{
    public class BGCollector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.GameObjects.Background))
            {
                other.gameObject.SetActive(false);
            }
        }
    }
}

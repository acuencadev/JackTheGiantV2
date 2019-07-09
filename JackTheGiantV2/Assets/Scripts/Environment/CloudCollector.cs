using UnityEngine;

namespace Mantelabs.JackTheGiant.Environment
{
    public class CloudCollector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Cloud") || other.CompareTag("DarkCloud"))
            {
                //TODO: Collect the cloud.
            }
        }
    }
}

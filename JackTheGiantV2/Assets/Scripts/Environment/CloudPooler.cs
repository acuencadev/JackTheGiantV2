using Mantelabs.JackTheGiant.Utils;
using UnityEngine;

namespace Mantelabs.JackTheGiant.Environment
{
    public class CloudPooler : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.GameObjects.Cloud) || other.CompareTag(Tags.GameObjects.DarkCloud))
            {
                //TODO: Collect the cloud.
            }
        }
    }
}

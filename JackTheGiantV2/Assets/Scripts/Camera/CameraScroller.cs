using Mantelabs.JackTheGiant.Managers;
using Mantelabs.JackTheGiant.Utils;
using UnityEngine;

namespace Mantelabs.JackTheGiant.Camera
{
    public class CameraScroller : MonoBehaviour
    {
        [SerializeField]
        private float _speed;


        private void Update()
        {
            if (GameManager.instance.gameStatus == GameStatus.Playing)
            {
                ScrollCamera();
            }
        }


        private void ScrollCamera()
        {
            Vector3 cameraPos = transform.position;
            cameraPos.y -= (_speed * Time.deltaTime);
            transform.position = cameraPos;
        }
    }
}

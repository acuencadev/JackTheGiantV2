using Mantelabs.JackTheGiant.Utils;
using UnityEngine;

namespace Mantelabs.JackTheGiant.Background
{
    public class BGSpawner : MonoBehaviour
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
    }
}

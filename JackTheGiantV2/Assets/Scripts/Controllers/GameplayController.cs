﻿using UnityEngine;

namespace Mantelabs.JackTheGiant.Controllers
{
    public class GameplayController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _pauseButton, _pausePanel;


        public void PauseGame()
        {
            _pauseButton.SetActive(false);
            _pausePanel.SetActive(true);

            Time.timeScale = 0f;
        }


        public void ResumeGame()
        {
            _pauseButton.SetActive(true);
            _pausePanel.SetActive(false);

            Time.timeScale = 1f;
        }


        public void QuitGame()
        {
            Debug.Log("Go to Main menu...");
        }
    }
}
﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace BioPunk
{
    public class Menu : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene(1);
        }

        public void Credits()
        {
            SceneManager.LoadScene(5);
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}
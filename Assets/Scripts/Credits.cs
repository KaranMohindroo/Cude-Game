﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour {
    public void Quit()
    {
        Application.Quit();
    }
    public void Star()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}

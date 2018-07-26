using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    [SerializeField] float levelLoadDelay = 2f;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Use this for initialization
    void Start()
    {

        Invoke("LoadNextLevel", levelLoadDelay);


    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }

}

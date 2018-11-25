using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    [SerializeField]
    Scene Game;

    public Button StartButton;
    public Button Exit;

    // Use this for initialization
    void Start ()
    {
        StartButton.onClick.AddListener(StartGame);
        Exit.onClick.AddListener(QuitGame);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        SceneManager.LoadScene("Testi");
        Debug.Log("Started game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

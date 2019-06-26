using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour {

    public Transform player;
    public Text text;
    public bool pause = false;
    public GameObject pausemenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = (player.position.z + 5).ToString("0");	

        //pause
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Escape))
        {
            if (pause == false)
            {
                pause = true;
                Time.timeScale = 0f;
                pausemenu.SetActive(true);
            }
            else if (pause == true)
            {
                resume();
            }
        }
	}

    public void GoToMenu()
    {
        pause = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void resume()
    {
        pause = false;
        Time.timeScale = 1f;
        pausemenu.SetActive(false);
    }
}

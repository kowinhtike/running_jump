using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btn_StartGame()
    {
        SceneManager.LoadScene("PlayGame");

    }

    public void btn_QuitGame()
    {
        Application.Quit();
    }
}

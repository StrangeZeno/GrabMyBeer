using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject player;
    //public GameObject winConditionUI;

    public static GameManagerScript Instance {  get; private set; }

    ////private void Awake()
    ////{
    ////    if(Instance == null)
    ////    {

    ////    Instance = this;
    ////        DontDestroyOnLoad(gameObject);
    ////    }

    ////    else if (Instance != this)
    ////    {
    ////        Destroy(gameObject);
    ////        return;
    ////    }
    
    //}
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOverUI.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState= CursorLockMode.Locked;
        }

        if (Input.GetKeyUp(KeyCode.Escape)) 
        {
            Application.Quit();

        }

        //if (winConditionUI.activeInHierarchy)
        //{
        //    Cursor.visible = true;
        //    Cursor.lockState = CursorLockMode.None;
        //}
        //else
        //{
        //    Cursor.visible = false;
        //    Cursor.lockState =CursorLockMode.Locked;
        //}
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    //public void gotBeer()
    //{
    //    winConditionUI.SetActive(true);
    //}

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

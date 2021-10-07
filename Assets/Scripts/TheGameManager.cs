using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TheGameManager : MonoBehaviour


{
 public static TheGameManager instance = null;

    public GameObject win;
    public GameObject lose;
    public bool activate;
    public float resetdelay = 1f;
    public Animator transition;
    public float transitionTime = 1f;
   
    void Awake()


    {
        if (instance == null)
            instance = this;

        else if (instance != null)
            Destroy(gameObject);


    }





    public void Win()


    {
        Time.timeScale = .5f;
        win.SetActive(true);
        Invoke("Continue", resetdelay);
    }



    public void Lose()
    {
        Time.timeScale = .5f;
        lose.SetActive(true);
        Invoke("Continue", resetdelay);
    }


    public void LoadRandomScene()
    {
        int index = Random.Range(2, 10);
        SceneManager.LoadScene(index);
        Debug.Log("Scene Loaded");


        //PlayerPrefs.GetInt("playerLifes");


    }

    void Continue()


    {


        Time.timeScale = 1.0f;


        LoadRandomScene();
    }


    public void GameOver()
    {
        Debug.Log("GAME OVER");
    }


    IEnumerable LoadLevel(int levelIndex)


    {


        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);


        LoadRandomScene();


    }


}



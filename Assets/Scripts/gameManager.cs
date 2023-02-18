using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{


    private static gameManager self;
   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }

    private void Start()
    {

        if (!PlayerPrefs.HasKey("Volume"))
        {
            PlayerPrefs.SetFloat("Volume", 0.5f);
        }
        if (!PlayerPrefs.HasKey("sens"))
        {
            PlayerPrefs.SetFloat("sens", 0.5f);
        }

        DontDestroyOnLoad(gameObject);
        if (self == null)
        {
            self = gameObject.GetComponent<gameManager>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Quit()
    {
        Application.Quit();
    }

    public void loadMenu()
    {
        SceneManager.LoadScene(0);
    }


    public static void LoadRandomGen()
    {
        SceneManager.LoadScene(1);
    }

   public void ChangeVolume(float vol)
    {
        PlayerPrefs.SetFloat("Volume", vol);

    }

    public void ChangeSens(float sens)
    {
        PlayerPrefs.SetFloat("sens", sens);
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene(2);
    }
}

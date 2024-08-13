using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HomeMeny : MonoBehaviour
{
    public TMP_Text coinText;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            quit();
        }
    }
    private void Start()
    {
        coinText.text = PlayerPrefs.GetInt("Coinsave").ToString();
    }

    public void play()
    {
        int unlockedlevel = PlayerPrefs.GetInt("Unlocked_level",1);
        SceneManager.LoadScene(unlockedlevel);
    }

    public void levelselection()
    {
        SceneManager.LoadScene("Level Selection");
    }

    public void restart()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }

    public void quit()
    {
        Application.Quit(); 
    }

}

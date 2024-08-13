using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Levelmanager : MonoBehaviour
{
    public TMP_Text coinText;
    public TMP_Text levelNO;
    public GameObject coin;
    public Came CameraFollow;
    public int nextlevleToload;
    int coincounter;
    // Start is called before the first frame update
    void Start()
    {
        coincounter = 0;
        levelNO.text = "Level : " + SceneManager.GetActiveScene().buildIndex;
        nextlevleToload = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
    void reload()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   // For Current Scene
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 1f;
            
        if(other.gameObject.CompareTag("water"))
        {
            CameraFollow.enabled = false;
            Invoke("reload",0.5f);  
        }

        if(other.gameObject.CompareTag("finishline"))
        {
            
            if(nextlevleToload > PlayerPrefs.GetInt("Unlocked_level"))
            {
                PlayerPrefs.SetInt("Unlocked_level", nextlevleToload);
            }
            coincounter += PlayerPrefs.GetInt("Coinsave");
            PlayerPrefs.SetInt("Coinsave",coincounter);
            SceneManager.LoadScene(nextlevleToload);
        }

        if(other.gameObject.CompareTag("coin"))
        {
            Destroy(coin);
            coincounter++;
            coinText.text = coincounter.ToString();
        }
    }

}

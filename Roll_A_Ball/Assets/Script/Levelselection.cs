using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levelselection : MonoBehaviour
{
    public int levelno;
    // Start is called before the first frame update

    public void levelload()
    {
        SceneManager.LoadScene(levelno);
    }
    void Start()
    {
        if(levelno <= PlayerPrefs.GetInt("Unlocked_level",1))
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}

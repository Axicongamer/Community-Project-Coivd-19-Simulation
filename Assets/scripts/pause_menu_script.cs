using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_menu_script : MonoBehaviour
{
    public GameObject pause_menu_UI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameManager.Instance.game_is_paused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume ()
    {
        pause_menu_UI.SetActive(false);
        Time.timeScale = 10f;
        GameManager.Instance.game_is_paused = false;
    }

    public void Pause ()
    {
        pause_menu_UI.SetActive(true);
        Time.timeScale = 0f;
        GameManager.Instance.game_is_paused = true;
    }

    public void menu ()
    {
        Time.timeScale = 10f;
        SceneManager.LoadScene("title screen");
    }

    public void Quit ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Lockdown ()
    {
        GameManager.Instance.Is_there_lockdown = true;
    }

    public void Close_schools ()
    {
        GameManager.Instance.Is_children_disabled = true;
    }

    public void Distribute_facemask ()
    {
        GameManager.Instance.Is_there_face_masks = true;
        GameManager.Instance.infection_rate = 1;
    }

    public void Vaccine_distributed ()
    {
        GameManager.Instance.Is_vaccine_distributed = true;
    }
    public void Restart ()
    {
        SceneManager.LoadScene("game scene");
    }
}
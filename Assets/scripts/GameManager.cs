using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            //create logic to create instance
            if (_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }
            
            return _instance;
        }
    }

    public int score {get; set;}
    public bool isDead {get; set;}
    public float currentTimeOfDay = 0f;
    public float secondsInFullDay = 120f;
    [Range(0,1)]
    public float timeMultiplier = 1f;
    public int how_many_uninfected = 540;
    public int how_many_infected = 0;
    public int how_many_recoving = 0;
    public int how_many_dead = 0;
    public int day = 1;
    public bool game_is_paused = false;
    public int has_everyone_arrived_at_shop = 0;
    public int has_everyone_arrived_at_home = 0;
    public bool do_i_go_home = false;
    public int death_chance = 3;
    public bool Is_there_lockdown = false;
    public bool Is_there_face_masks = false;
    public bool Is_children_disabled = false; // aka the schools are closed
    public bool Is_vaccine_distributed = false;
    public bool Children_stop_moving = false;
    public int How_many_should_be_at_shop = 540;
    public int How_many_should_be_at_home = 540;
    public int broadcasted_message = 0;
    public int infection_rate = 2;

    void Awake()
    {
        _instance = this;
    }

    void start()
    {

    }
}
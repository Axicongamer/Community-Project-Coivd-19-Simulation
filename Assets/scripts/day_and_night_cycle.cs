using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day_and_night_cycle : MonoBehaviour 
{
    int who_is_not_home;
    int when_children_at_home;
    
    void Start() 
    {
        Time.timeScale = 10;
    }

    void Update()
    {
        Debug.Log(GameManager.Instance.has_everyone_arrived_at_home);
        Debug.Log(GameManager.Instance.has_everyone_arrived_at_shop);

        //checks if everyone has gone either home or to a outside place (shop or school) then makes it so they will go to the next place.
        if (GameManager.Instance.has_everyone_arrived_at_home == GameManager.Instance.How_many_should_be_at_home)
        {
            GameManager.Instance.has_everyone_arrived_at_home = 0;
            if (GameManager.Instance.do_i_go_home == false)
            {
                GameManager.Instance.do_i_go_home = true;
            }
            else
            {
                GameManager.Instance.do_i_go_home = false;
            }
            who_is_not_home = 0;
            Time.timeScale = 10;
        }
        if (GameManager.Instance.has_everyone_arrived_at_shop == GameManager.Instance.How_many_should_be_at_shop)
        {
            GameManager.Instance.has_everyone_arrived_at_shop = 0;
            if (GameManager.Instance.do_i_go_home == false)
            {
                GameManager.Instance.do_i_go_home = true;
            }
            else
            {
                GameManager.Instance.do_i_go_home = false;
            }
            who_is_not_home = 0;
            Time.timeScale = 10;
        }
        //slows down the game so all the codes that runs at that time does less lag.
        if (GameManager.Instance.has_everyone_arrived_at_home == (GameManager.Instance.How_many_should_be_at_home - 1) || GameManager.Instance.has_everyone_arrived_at_shop == (GameManager.Instance.How_many_should_be_at_shop - 1))
        {
            Time.timeScale = 0.5f;
        }

    }
}
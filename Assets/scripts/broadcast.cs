using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class broadcast : MonoBehaviour
{
    bool has_gone_home = false;
    bool has_gone_shop = false;
    bool shop_cycle_over = false;
    bool home_cycle_over = false;
    int new_day = 0;
    int what_day_was_it = 0;
    int How_long_have_you_had_vaccine_out = 0;
    
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Is_there_lockdown == false)
        {
            if (GameManager.Instance.has_everyone_arrived_at_shop == 0)
            {
                if (GameManager.Instance.do_i_go_home == false)
                {
                    if (has_gone_shop == false)
                    {
                        BroadcastMessage("go_to_shop");
                        BroadcastMessage("go_to_school");
                        has_gone_shop = true;
                    }
                }
            }
            if (GameManager.Instance.has_everyone_arrived_at_home == 0)
            {
                if (GameManager.Instance.do_i_go_home == true)    
                {
                    if (has_gone_home == false)
                    {
                        BroadcastMessage("go_home");
                        BroadcastMessage("go_home_child");
                        has_gone_home = true;
                    }
                }
            }
            if (GameManager.Instance.has_everyone_arrived_at_shop == GameManager.Instance.How_many_should_be_at_shop || GameManager.Instance.has_everyone_arrived_at_home == GameManager.Instance.How_many_should_be_at_home)
            {
                BroadcastMessage("reset");
            }
            if (GameManager.Instance.has_everyone_arrived_at_shop == GameManager.Instance.How_many_should_be_at_shop)
            {
                shop_cycle_over = true;
            }
            if (GameManager.Instance.has_everyone_arrived_at_home == GameManager.Instance.How_many_should_be_at_home)
            {
                home_cycle_over = true;
            }
            if (home_cycle_over == true)
            {
                if (shop_cycle_over == true)
                {
                    shop_cycle_over = false;
                    home_cycle_over = false;
                    has_gone_home = false;
                    has_gone_shop = false;
                    GameManager.Instance.day += 1;
                }
            }
        }
        else
        {
            GameManager.Instance.How_many_should_be_at_home = 1000;
            if (new_day == 540)
            {
                new_day = 0;
                GameManager.Instance.day += 1;
            }
            else
            {
                new_day += 1;
            }
        }
        if (GameManager.Instance.Is_vaccine_distributed == true)
        {
            if (GameManager.Instance.day == what_day_was_it)
            {}
            else
            {
                what_day_was_it = GameManager.Instance.day;
                How_long_have_you_had_vaccine_out += 1;
                if (How_long_have_you_had_vaccine_out == 6)
                {
                    BroadcastMessage("vaccinate");
                }
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text_changer : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.game_is_paused)
        {
            TextMeshProUGUI txt_uninfected_people = GameObject.Find("Canvas/information_menu/Susceptible").GetComponent<TextMeshProUGUI>();
            txt_uninfected_people.text = "Susceptible-" + GameManager.Instance.how_many_uninfected;

            TextMeshProUGUI txt_infected_people = GameObject.Find("Canvas/information_menu/infected").GetComponent<TextMeshProUGUI>();       
            txt_infected_people.text = "Infected-" + GameManager.Instance.how_many_infected;

            TextMeshProUGUI txt_recovered_people = GameObject.Find("Canvas/information_menu/recovered").GetComponent<TextMeshProUGUI>();       
            txt_recovered_people.text = "Recovered/Immune-" + GameManager.Instance.how_many_recoving;

            TextMeshProUGUI txt_dead_people = GameObject.Find("Canvas/information_menu/dead").GetComponent<TextMeshProUGUI>();       
            txt_dead_people.text = "Dead-" + GameManager.Instance.how_many_dead;

            TextMeshProUGUI txt_day_number = GameObject.Find("Canvas/information_menu/day").GetComponent<TextMeshProUGUI>();       
            txt_day_number.text = "Day-" + GameManager.Instance.day;
        }
    }
}

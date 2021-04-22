using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class collider_trigger_home : MonoBehaviour
{
    public Material infected;
    int people_in_the_building;
    int infected_people_in_the_building;
    int how_many_new_infected;
    public Transform inside_the_build;
    List <GameObject> people = new List<GameObject> ();
    
    void OnTriggerEnter(Collider targetObj)
    {
        if (GameManager.Instance.do_i_go_home == true)
        {
            if (people.Contains(targetObj.gameObject))
            {

            }
            else
            {
                targetObj.gameObject.GetComponent<MeshRenderer>().enabled = false;
                people_in_the_building += 1;
                targetObj.gameObject.GetComponent<NavMeshAgent>().isStopped = true;
                if (targetObj.gameObject.tag == "infected")
                {
                    infected_people_in_the_building += 1;
                }
                people.Add(targetObj.gameObject);
                GameManager.Instance.has_everyone_arrived_at_home += 1;
            }
        }
    }
    void Update()
    {
        if (GameManager.Instance.has_everyone_arrived_at_home == 0 && GameManager.Instance.do_i_go_home == true)
        {
            if (infected_people_in_the_building == people_in_the_building)
            {}
            else
            {
                how_many_new_infected = infected_people_in_the_building *= GameManager.Instance.infection_rate;
                for (int i = 0; i < how_many_new_infected; i += 1)
                {
                    int rand = Random.Range(0, people_in_the_building);
                    if (people[rand].tag == "recovered")
                    {

                    }
                    else
                    {
                        people[rand].tag = "infected";
                    }
                }
            }
            people.Clear();
            people_in_the_building = 0;
        }
    }
}
using UnityEngine;
using UnityEngine.AI;

public class player_controller_2 : MonoBehaviour
{
    public Camera cam;

    public UnityEngine.AI.NavMeshAgent agent;

    public Transform school_enterence;
    public Transform house_enterence;
    public Transform stay_home_spot;
    public Material infected;
    public Material uninfected;
    public Material recovered;
    
    public GameObject thePlayer;
    
    bool already_infected = false;
    bool already_recovered = false;
    bool moving = false;
    bool is_alive = true;

    int How_long_have_you_had_the_virus = 0;
    int what_day_was_it = 1;
    int infection_period = 6;

    // Update is called once per frame
    void Update()
    {      
        if (gameObject.tag == "infected")
        {
            if (GameManager.Instance.day == what_day_was_it)
            {}
            else
            {
                what_day_was_it = GameManager.Instance.day;
                How_long_have_you_had_the_virus += 1;
                if (How_long_have_you_had_the_virus == infection_period)
                {
                    int RandomNumber2 = Random.Range(1, 3);
                    if (RandomNumber2 == GameManager.Instance.death_chance)
                    {
                        gameObject.GetComponent<MeshRenderer>().enabled = false;
                        is_alive = false;
                        GameManager.Instance.how_many_dead += 1;
                        GameManager.Instance.how_many_infected -= 1;
                    }
                    else
                    {
                        GameManager.Instance.how_many_infected -= 1;
                        GameManager.Instance.how_many_recoving += 1;
                    }
                    gameObject.tag = "recovered";
                }
            }
        }
        
        if (gameObject.tag == "infected")
        {
            if (already_infected == true)
            {}
            else
            {
                GameManager.Instance.how_many_uninfected -= 1;
                GameManager.Instance.how_many_infected += 1;
                already_infected = true;
                already_recovered = false;
            }
        }

        //checks what state(tag) it has and changes it's apperence to match it.
        if (gameObject.tag == "infected")
        {
            gameObject.GetComponent<Renderer>().material = infected;
        }
        else
        {            
            if (gameObject.tag == "unifected")
            {
                gameObject.GetComponent<Renderer>().material = uninfected;
            }
            else
            {
                if (gameObject.tag == "recovered")
                {
                    gameObject.GetComponent<Renderer>().material = recovered;
                }
            }
        }
        if (moving == false)
        {
            if (agent.pathPending)
            {}
            else
            {
                if (GameManager.Instance.Is_children_disabled == false)
                {
                    gameObject.GetComponent<MeshRenderer>().enabled = is_alive;
                }
                gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                moving = true;
            }
        }
    }
    //the agents going out of the house
    void go_to_school()
    {
        agent.SetDestination(school_enterence.position);
        moving = false;
    }
    //the agents leaves the place they went(normally a community building) and goes back home
    void go_home_child()
    {
        agent.SetDestination(house_enterence.position);
        moving = false;
    }
    void reset()
    {
        gameObject.GetComponent<Collider>().isTrigger = true;
    }
    void go_home_child_2()
    {
        agent.SetDestination(house_enterence.position);
    }
    void vaccinate ()
    {
        if (gameObject.tag == "infected")
        {}
        else
        {            
            GameManager.Instance.how_many_uninfected -= 1;
            GameManager.Instance.how_many_recoving += 1;
            gameObject.tag = "recovered";
        }
    }
}
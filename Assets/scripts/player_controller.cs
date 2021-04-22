using UnityEngine;
using UnityEngine.AI;

public class player_controller : MonoBehaviour
{
    public Camera cam;

    public UnityEngine.AI.NavMeshAgent agent;

    public Transform shop_enterence_1;
    public Transform shop_enterence_2;
    public Transform shop_enterence_3;
    public Transform shop_enterence_4;
    public Transform shop_enterence_5;
    public Transform shop_enterence_6;
    public Transform shop_enterence_7;
    public Transform shop_enterence_8;
    public Transform shop_enterence_9;
    public Transform shop_enterence_10;
    public Transform shop_enterence_11;
    public Transform shop_enterence_12;
    public Transform shop_enterence_13;
    public Transform shop_enterence_14;
    public Transform shop_enterence_15;
    public Transform shop_enterence_16;
    public Transform shop_enterence_17;
    public Transform shop_enterence_18;
    public Transform shop_enterence_19;
    public Transform shop_enterence_20;
    public Transform shop_enterence_21;
    public Transform shop_enterence_22;
    public Transform shop_enterence_23;
    public Transform shop_enterence_24;
    public Transform shop_enterence_25;
    public Transform shop_enterence_26;
    public Transform shop_enterence_27;
    public Transform shop_enterence_28;
    public Transform shop_enterence_29;
    public Transform shop_enterence_30;
    public Transform shop_enterence_31;
    public Transform shop_enterence_32;
    public Transform shop_enterence_33;
    public Transform shop_enterence_34;
    public Transform shop_enterence_35;
    public Transform shop_enterence_36;
    public Transform shop_enterence_37;
    public Transform shop_enterence_38;
    public Transform shop_enterence_39;
    public Transform shop_enterence_40;
    public Transform shop_enterence_41;
    public Transform shop_enterence_42;
    public Transform shop_enterence_43;
    public Transform shop_enterence_44;
    public Transform shop_enterence_45;
    public Transform shop_enterence_46;
    public Transform shop_enterence_47;
    public Transform shop_enterence_48;
    public Transform house_enterence;
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
                gameObject.GetComponent<MeshRenderer>().enabled = is_alive;
                gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                moving = true;
            }
        }
    }
    //the agents going out of the house
    void go_to_shop()
    {
        int RandomNumber = Random.Range(1, 48);
        if (RandomNumber == 1) {
            agent.SetDestination(shop_enterence_1.position);
        }
        if (RandomNumber == 2) {
            agent.SetDestination(shop_enterence_2.position);
        }
        if (RandomNumber == 3) {
            agent.SetDestination(shop_enterence_3.position);
        }
        if (RandomNumber == 4) {
            agent.SetDestination(shop_enterence_4.position);
        }
        if (RandomNumber == 5) {
            agent.SetDestination(shop_enterence_5.position);
        }
        if (RandomNumber == 6) {
            agent.SetDestination(shop_enterence_6.position);
        }
        if (RandomNumber == 7) {
            agent.SetDestination(shop_enterence_7.position);
        }
        if (RandomNumber == 8) {
            agent.SetDestination(shop_enterence_8.position);
        }
        if (RandomNumber == 9) {
            agent.SetDestination(shop_enterence_9.position);
        }
        if (RandomNumber == 10) {
            agent.SetDestination(shop_enterence_10.position);
        }
        if (RandomNumber == 11) {
            agent.SetDestination(shop_enterence_11.position);
        }
        if (RandomNumber == 12) {
            agent.SetDestination(shop_enterence_12.position);
        }
        if (RandomNumber == 13) {
            agent.SetDestination(shop_enterence_13.position);
        }
        if (RandomNumber == 14) {
            agent.SetDestination(shop_enterence_14.position);
        }
        if (RandomNumber == 15) {
            agent.SetDestination(shop_enterence_15.position);
        }
        if (RandomNumber == 16) {
            agent.SetDestination(shop_enterence_16.position);
        }
        if (RandomNumber == 17) {
            agent.SetDestination(shop_enterence_17.position);
        }
        if (RandomNumber == 18) {
            agent.SetDestination(shop_enterence_18.position);
        }
        if (RandomNumber == 19) {
            agent.SetDestination(shop_enterence_19.position);
        }
        if (RandomNumber == 20) {
            agent.SetDestination(shop_enterence_20.position);
        }
        if (RandomNumber == 21) {
            agent.SetDestination(shop_enterence_21.position);
        }
        if (RandomNumber == 22) {
            agent.SetDestination(shop_enterence_22.position);
        }
        if (RandomNumber == 23) {
            agent.SetDestination(shop_enterence_23.position);
        }
        if (RandomNumber == 24) {
            agent.SetDestination(shop_enterence_24.position);
        }
        if (RandomNumber == 25) {
            agent.SetDestination(shop_enterence_25.position);
        }
        if (RandomNumber == 26) {
            agent.SetDestination(shop_enterence_26.position);
        }
        if (RandomNumber == 27) {
            agent.SetDestination(shop_enterence_27.position);
        }
        if (RandomNumber == 28) {
            agent.SetDestination(shop_enterence_28.position);
        }
        if (RandomNumber == 29) {
            agent.SetDestination(shop_enterence_29.position);
        }
        if (RandomNumber == 30) {
            agent.SetDestination(shop_enterence_30.position);
        }
        if (RandomNumber == 31) {
            agent.SetDestination(shop_enterence_31.position);
        }
        if (RandomNumber == 32) {
            agent.SetDestination(shop_enterence_32.position);
        }
        if (RandomNumber == 33) {
            agent.SetDestination(shop_enterence_33.position);
        }
        if (RandomNumber == 34) {
            agent.SetDestination(shop_enterence_34.position);
        }
        if (RandomNumber == 35) {
            agent.SetDestination(shop_enterence_35.position);
        }
        if (RandomNumber == 36) {
            agent.SetDestination(shop_enterence_36.position);
        }
        if (RandomNumber == 37) {
            agent.SetDestination(shop_enterence_37.position);
        }
        if (RandomNumber == 38) {
            agent.SetDestination(shop_enterence_38.position);
        }
        if (RandomNumber == 39) {
            agent.SetDestination(shop_enterence_39.position);
        }
        if (RandomNumber == 40) {
            agent.SetDestination(shop_enterence_40.position);
        }
        if (RandomNumber == 41) {
            agent.SetDestination(shop_enterence_41.position);
        }
        if (RandomNumber == 42) {
            agent.SetDestination(shop_enterence_42.position);
        }
        if (RandomNumber == 43) {
            agent.SetDestination(shop_enterence_43.position);
        }
        if (RandomNumber == 44) {
            agent.SetDestination(shop_enterence_44.position);
        }
        if (RandomNumber == 45) {
            agent.SetDestination(shop_enterence_45.position);
        }
        if (RandomNumber == 46) {
            agent.SetDestination(shop_enterence_46.position);
        }
        if (RandomNumber == 47) {
            agent.SetDestination(shop_enterence_47.position);
        }
        if (RandomNumber == 48) {
            agent.SetDestination(shop_enterence_48.position);
        }
        moving = false;
    }
    //the agents leaves the place they went(normally a community building) and goes back home
    void go_home()
    {
        agent.SetDestination(house_enterence.position);
        moving = false;
    }
    void reset()
    {
        gameObject.GetComponent<Collider>().isTrigger = true;

    }
    void go_home_2()
    {
        agent.SetDestination(house_enterence.position);
    }
    void vaccinate()
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
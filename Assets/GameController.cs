using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameDisplay gameDisplay;
    public GameObject[] player;
    int z;

    public int loadANewGame;

    public static int whereIsTheWaitress;

   
    void setFalse()
    {
        for (int i = 0; i < 5; i++)
        {
            player[i].SetActive(false);


        }
        player[0].SetActive(true);

    }


    void Start()
    {
        setFalse();
        z = 0;
    }
    void Update()
    {

            

        if (Input.GetKeyUp(KeyCode.A))
        {
            if (z < 0)
            {
                z = 0;
            }
            else if (z > 0)
            {
                z--;
                player[(z + 1)].SetActive(false);
            }
            player[z].SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            if (z > 4)
            {
                z = 4;
            }
            else if(z < 4)
            {
                z++;
                player[(z - 1)].SetActive(false);
            }

            player[z].SetActive(true);

        }
        whereIsTheWaitress = z;
        
    }
}

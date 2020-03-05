using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDisplay : MonoBehaviour
{

    public GameController gameController;
    
    public GameObject[] pancakes;

    public GameObject[] lifes;



    public bool[] lifeCounter = new bool[3];

    int lifeTracker = 2;

    public Text textScore;

    public static int megaScore = 0;

    public static float loadScore;


    int pP;
    
    int q;

    public int scoreDisplayWhenGameOver; 

 
    void setFalse()
    {
        for (int i = 0; i < 25; i++)
        {
            pancakes[i].SetActive(false);
        }

    }

    private int setPlayerPos()
    {
        pP = GameController.whereIsTheWaitress;
        return pP;
    }

    private void RandomZ()
    {
        int[] z = new int[] { 0, 5, 10, 15, 20, 25 };
        int randomZ = z[Random.Range(0, z.Length)];
        q = randomZ;
    }
    void Start()
    {
        setFalse();

        // 3 extra lives!
        for (int m = 0; m < 3; m++)
        {
            lifes[m].SetActive(true);
        }
        


        StartCoroutine(RandomFalling());
        megaScore = 0;

    }
   
 
    IEnumerator RandomFalling()
    {
        while (true)
        {
            RandomZ();
            

            

            if (q == 0 || q == 5 || q == 10 || q == 15 || q == 20)
            {
                for (int x = q; x < (q + 5); x++)
                {
                    
                    pancakes[x].SetActive(true);
                    yield return new WaitForSeconds(0.5f);

                    pancakes[x].SetActive(false);

                    setPlayerPos();
                    if (x == 4 && pP == 0 )
                    {
                        megaScore++;
                        textScore.text = megaScore.ToString();
                    }
                    if (x == 9 && pP == 1)
                        {
                            megaScore++;
                            textScore.text = megaScore.ToString();
                        }
                    if (x == 14 && pP == 2)
                    {
                        megaScore++;
                        textScore.text = megaScore.ToString();
                    }
                    if (x == 19 && pP == 3)
                    {
                        megaScore++;
                        textScore.text = megaScore.ToString();
                    }
                    if (x == 24 && pP == 4)
                    {
                        megaScore++;
                        textScore.text = megaScore.ToString();
                    }
                    //If player is really bad at games :P
                    if (x == 4 && pP != 0 || x == 9 && pP != 1 || x == 14 && pP != 2 || x == 19 && pP != 3 || x == 24 && pP != 4)
                    {

                        lifes[lifeTracker].SetActive(false);
                        --lifeTracker;

                        if(lifeTracker == -1)
                        {
                            loadScore = megaScore;
                            SceneManager.LoadScene(1);
                        }
                        
                    }

                }
            }  

        
        }
    }
}

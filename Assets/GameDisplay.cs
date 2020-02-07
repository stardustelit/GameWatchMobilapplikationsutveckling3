using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDisplay : MonoBehaviour
{

    public GameController gameController;
    
    public GameObject[] pancakes;

    public Text textScore;

    int megaScore = 0;

    int pP;
    

    int q;
 
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
     

        StartCoroutine(RandomFalling());


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

                }
            }  

        
        }
    }
}

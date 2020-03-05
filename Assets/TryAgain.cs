using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class TryAgain : MonoBehaviour
{


    public Text txt;
    
    string gameScore;

    private int loadANewGame = 0;


    public void setScore()
    {
        gameScore = GameDisplay.megaScore.ToString();

        
        txt.GetComponent<UnityEngine.UI.Text>().text = loadANewGame.ToString();
    }

    public void scoreAnnouncer()
    {
        
    }




   // SceneManager.LoadScene(loadANewGame);
   
}

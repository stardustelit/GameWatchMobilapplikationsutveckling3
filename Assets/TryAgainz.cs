using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TryAgainz : MonoBehaviour
{

    public Text txt;
  
    void Start()
    {
        txt.GetComponent<UnityEngine.UI.Text>().text = GameDisplay.megaScore.ToString();

    }

}

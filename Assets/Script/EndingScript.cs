using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingScript : MonoBehaviour
{   
    public TextMeshProUGUI endingText;
    // Start is called before the first frame update
    void Start()
    {
        if(ScoringScript.score1 > ScoringScript.score2){
            endingText.text = "Player 1 menang";
        } else if (ScoringScript.score1 < ScoringScript.score2){
            endingText.text = "Player 2 menang";
        }else{
            endingText.text = "Keduanya menang";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

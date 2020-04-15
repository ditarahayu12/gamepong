using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //tambahan ganti scene

public class TimerScript : MonoBehaviour
{
	public int counter =30;
	public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
       timerText.text = counter.ToString(); 
       StartCoroutine(hitungmundur());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator hitungmundur(){
    	while(counter > 0){
    	yield return new WaitForSeconds(1); //waktuberkurang 1 detik sampai lebih 0 sampai abis ganti game over
    	counter -= 1;
    	timerText.text = counter.ToString();
  		}

  		//timerText.text = "GAME OVER"; sebelumnya ini terus diubah ke scene
  		SceneManager.LoadScene("GameOverScene");
    }
}

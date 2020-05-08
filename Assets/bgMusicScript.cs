using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMusicScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //agar objeknya tidak pernah mati, membuat lagunya tidak dapat dihapus meskipun pindah scene
   
        
    }
}

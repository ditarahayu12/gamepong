using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    //public int speed = 30;
    public Rigidbody2D sesuatu;
    public Animator animtr;
    public GameObject masterScript;
    // Start is called before the first frame update
    void Start()
    {
        int x = Random.Range(0,2) * 2 - 1; // nilai x bisa bernilai -1 atau 1 
        int y = Random.Range(0,2) * 2 - 1; // nilai y bisa bernilai -1 atau 1
        int speed = Random.Range(10,14); // nilai speed antara 20-25
        sesuatu.velocity = new Vector2(x,y) * speed;
        sesuatu.GetComponent<Transform>().position = Vector2.zero;
        animtr.SetBool("IsMove", true);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(sesuatu.velocity.x > 0){ //bola bergerak ke kana
            sesuatu.GetComponent<Transform>().localScale = new Vector3(1,1,1);    
        }else {
            sesuatu.GetComponent<Transform>().localScale = new Vector3(-1,1,1);
        }
        
    }
    //mengecek apakah ada tabrakan
    void OnCollisionEnter2D(Collision2D other){
        if(other.collider.name=="Kanan" || other.collider.name=="Kiri"){
            masterScript.GetComponent<ScoringScript>().UpdateScore(other.collider.name);
            StartCoroutine(jeda()); // untuk pindah ketengah
        }
    }

    IEnumerator jeda(){
        sesuatu.velocity = Vector2.zero; // menghentikan bola
        animtr.SetBool("IsMove", false); // mengubah animasi ke api berhenti
        sesuatu.GetComponent<Transform>().position = Vector2.zero;

        yield return new WaitForSeconds(1);

        int x = Random.Range(0,2) * 2 - 1; // nilai x bisa bernilai -1 atau 1 
        int y = Random.Range(0,2) * 2 - 1; // nilai y bisa bernilai -1 atau 1
        int speed = Random.Range(10,14); 
        sesuatu.velocity = new Vector2(x,y ) * speed; // mengatur kecepatan
        animtr.SetBool("IsMove", true); // mengubah animasi ke api bergerak
    }
}
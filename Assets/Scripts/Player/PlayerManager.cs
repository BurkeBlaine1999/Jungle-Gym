using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton

    public static PlayerManager instance;

    void Awake(){
        instance = this;
    }

    #endregion

    public GameObject player;
    private int health = 100;
    void Start(){
        //AudioSource.Play();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet"){
            TakeDamage(35);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0){
            Death();
        }
        return;
    }

    private void Death(){
        Debug.Log("YOU ARE DEAD!");
        Destroy(player.gameObject);
    }

    private void changeAudio(){

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggRed : MonoBehaviour
{
    GameController gcl;

    private void Start()
    {
        gcl = FindObjectOfType<GameController>();
    }



    //OnCollision 2D // bat duoc va cham giua doi tuong nay voi doi tuong khac
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            gcl.IncrementScore();
            Destroy(gameObject);
            Debug.Log(" Qua trung da roi vao gio  ");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col. CompareTag("Deathzone"))
        {
            gcl.SetGameOverState(true);
            Destroy(gameObject);

            Debug.Log(" Death zone LOSE ");
        }
    }
}

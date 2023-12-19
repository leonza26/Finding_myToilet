using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehaviour : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision) //ketika kotak ini bersentuhan dengan
    {
        if (collision.gameObject.tag == "Player") //player, maka kotak menjadi dinamis (bisa didorong)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
        else if (collision.gameObject.tag == "Locked Door")
        {
            this.gameObject.SetActive(false); //awalnya script ini di BridgeScript, tapi gatau kenapa disana gak de-aktif, jadi dipindahin kesini ternyata bisa
        }
    }

    void OnCollisionExit2D(Collision2D colExt) //pas lepas dari collision
    {
        if (colExt.gameObject.tag == "Player") // player, 
        {
            rb.bodyType = RigidbodyType2D.Static; //kotak menjadi statis
        }
    }
}

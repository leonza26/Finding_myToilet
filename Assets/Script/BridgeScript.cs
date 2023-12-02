using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BridgeScript : MonoBehaviour
{

    [SerializeField] Animator BridgeAnim; //declare animator jembatan

    private void OnCollisionEnter2D(Collision2D collision) //kalo penghalang bersentuhan dengan objek
    {
        if (collision.gameObject.tag == "Box") //jika tag objeknya box, 
        {
            this.gameObject.SetActive(false); //maka bariernya akan tidak aktif/hilang
            BridgeAnim.SetBool("IsFixed", true); //mengubah animasi jembatannya
        }
    }
}

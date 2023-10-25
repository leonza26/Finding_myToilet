using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // inisisasi nilai 
    float horizontalAxis;
    float verticalAxis;
    Vector2 direction;
    Vector2 direction2;

    [SerializeField]
    private float speed;
    // [SerializeField] private float speeds; gak kepake
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementHorizontal();
        movementVertical();
    }

    private void movementHorizontal()
    {
        horizontalAxis = Input.GetAxis("Horizontal"); //untuk membuat perpindahan bisa menggunakan inputan 
        

        direction = new Vector2(horizontalAxis, 0); //titik kordinat untuk perpindahan horizontal dimulai dari center atau 0
        direction2 = new Vector2(0, verticalAxis);

        speed = 3; // kecepatan perpindahan 


        transform.Translate(direction * Time.deltaTime * speed); // code untuk mengeksekusi kecepatan yang dibuat, deltatime salah satu variabel untuk membuat perpindahan tisakmengikuti frame
        transform.Translate(direction2 * Time.deltaTime * speed);

    }

    private void movementVertical()
    {
        verticalAxis = Input.GetAxis("Vertical");
        direction2 = new Vector2(0, verticalAxis);

        speed = 3; // awalnya make var speeds
        // transform.Translate(direction2 * Time.deltaTime * speeds); gak kepake, kalo kepake jadi nambah kecepatan vertikalnya
    }
}

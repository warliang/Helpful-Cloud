using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public Animator animator;
    bool lightning = false;
    bool snow = false;
    bool windy = false;
    private Rigidbody2D rb2d;
   
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        


        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement* speed);

        if (Input.GetKeyDown(KeyCode.Z) == true){
            animator.SetBool("isLightning", true);
            lightning = true;

            FindObjectOfType<AudioManager>().Play("zap");
        }
        else if (Input.GetKeyUp(KeyCode.Z) == true)
        {
            animator.SetBool("isLightning", false);
            lightning = false;
        }

        if (Input.GetKeyDown(KeyCode.X) == true)
        {
            animator.SetBool("isSnow", true);
            snow = true;

            FindObjectOfType<AudioManager>().Play("sleigh_bells_short");
        }
        else if (Input.GetKeyUp(KeyCode.X) == true)
        {
            animator.SetBool("isSnow", false);
            snow = false;
        }

        if (Input.GetKeyDown(KeyCode.C) == true)
        {
            animator.SetBool("isWindy", true);
            windy = true;
        }
        else if (Input.GetKeyUp(KeyCode.C) == true)
        {
            animator.SetBool("isWindy", false);
            windy = false;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}

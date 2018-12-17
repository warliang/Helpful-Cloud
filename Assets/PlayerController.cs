using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float speed;
    public Animator animator;

    // public Transform PlayerTransformer;
    // public Transform OcatTransformer;
    // public Transform BcatTransformer;
    // public Transform CampfireTransformer;

    bool lightning = false;
    bool snow = false;
    bool windy = false;
    private Rigidbody2D rb2d;

    private int count;
    public Text countText;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        // setText();
    }

    void Update() {
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

    // bool isWithinCat(Transform transformer) {
    //   Vector3 playerPosition = PlayerTransformer.position;
    //   Vector3 objectPosition = transformer.position;
    //
    //     if (playerPosition.x < objectPosition.x + 1 &&
    //         playerPosition.x > objectPosition.x - 1 &&
    //         playerPosition.y < objectPosition.y + 3) {
    //           return true;
    //         } else {
    //             return false;
    //         }
    // }
    //
    // bool isWithinCamp(Transform tranformer) {
    //   Vector3 playerPosition = PlayerTransformer.position;
    //   Vector3 campPosition = tranformer.position;
    //
    //     if (playerPosition.x < campPosition.x + 2 &&
    //         playerPosition.x > campPosition.x + 1 &&
    //         playerPosition.y < campPosition.y + 1) {
    //           return true;
    //         } else {
    //             return false;
    //         }
    // }

    // void OnTriggerStay2D(Collider2D col) {
    //   if (col.gameObject.tag == "cat") {
    //     Debug.Log("I have collided with a cat");
    //     if (snow) {
    //       addPoints(1);
    //     }
    //   }
    //
    //   if (col.gameObject.tag == "camp") {
    //     campfire_sparker campScript = col.gameObject.GetComponent<campfire_sparker>();
    //     if(lightning && !campScript.lit) {
    //       Debug.Log("I have collided with a campfire");
    //       addPoints(10);
    //       campScript.isLit();
    //     }
    //   }
    // }
    //
    // void addPoints(int amt) {
    //   count = count + amt;
    //   setText();
    // }
    //
    // void setText() {
    //   countText.text = "Score: " + count.ToString();
    // }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class campfire_sparker : MonoBehaviour {
    public Animator PlayerAnimator;
    public Transform PlayerTransformer;
    public Animator CampfireAnimator;
    public Transform CampfireTransformer;

    private int count;
    public Text countText;
    private bool points;

    // Use this for initialization
    void Start () {
        count = 0;
        points = true;

    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerAnimator.GetBool("isLightning") == true 
            && PlayerTransformer.position.x < CampfireTransformer.position.x + 2
            && PlayerTransformer.position.x > CampfireTransformer.position.x + 1
            && PlayerTransformer.position.y < CampfireTransformer.position.y + 1){
            CampfireAnimator.SetBool("sparked", true);

            FindObjectOfType<AudioManager>().Play("fire_crackling_short");
            if (Random.Range(0, 20) < 1) {
                FindObjectOfType<AudioManager>().Play("THUNDER_short");
            }
        }

        
    }

  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatHappiness : MonoBehaviour
{
    public Animator PlayerAnimator;
    public Transform PlayerTransformer;

    public Animator OcatAnimator;
    public Transform OcatTransformer;
    public Renderer OcatRenderer;

    public Animator BcatAnimator;
    public Transform BcatTransformer;
    public Renderer BcatRenderer;

    public GameObject scoreManager;

    public GameObject lifeSystem;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (PlayerAnimator.GetBool("isLightning") == true
          && PlayerTransformer.position.x < OcatTransformer.position.x + 1
          && PlayerTransformer.position.x > OcatTransformer.position.x - 1
          && PlayerTransformer.position.y < OcatTransformer.position.y + 3) {
            if(!OcatAnimator.GetBool("zapped")) {
              lifeSystem.GetComponent<LIfeSystemScript>().loseHealth();
              OcatAnimator.SetBool("zapped", true);
            }

          }



          if (PlayerAnimator.GetBool("isLightning") == true
              && PlayerTransformer.position.x < BcatTransformer.position.x + 1
              && PlayerTransformer.position.x > BcatTransformer.position.x - 1
              && PlayerTransformer.position.y < BcatTransformer.position.y + 3) {
                if(!BcatAnimator.GetBool("zapped")) {
                  lifeSystem.GetComponent<LIfeSystemScript>().loseHealth();
                  BcatAnimator.SetBool("zapped", true);
                }
              }



        if (PlayerAnimator.GetBool("isSnow") == true
            && PlayerTransformer.position.x < OcatTransformer.position.x + 1
            && PlayerTransformer.position.x > OcatTransformer.position.x - 1
            && PlayerTransformer.position.y < OcatTransformer.position.y + 3)
        {
            OcatAnimator.SetBool("snowed", true);
            //OcatRenderer.sortingOrder += 1;
            OcatTransformer.localScale += new Vector3(0.001f, 0.001f, 0);
            scoreManager.GetComponent<ScoreManagerScript>().addPoints(1);

            FindObjectOfType<AudioManager>().Play("hooray");

        }

        if (PlayerAnimator.GetBool("isSnow") == true
            && PlayerTransformer.position.x < BcatTransformer.position.x + 1
            && PlayerTransformer.position.x > BcatTransformer.position.x - 1
            && PlayerTransformer.position.y < BcatTransformer.position.y + 3)
        {
            BcatAnimator.SetBool("snowed", true);
            //BcatRenderer.sortingOrder += 1;
            BcatTransformer.localScale += new Vector3(0.001f, 0.001f, 0);
            scoreManager.GetComponent<ScoreManagerScript>().addPoints(1);

            FindObjectOfType<AudioManager>().Play("hooray");
        }

    }


}

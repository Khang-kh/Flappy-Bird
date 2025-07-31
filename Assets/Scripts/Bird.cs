using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class Bird : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float jumpForce; 
    private bool levelStart; 
    public GameObject gameController;
    public GameObject message; 
    private int score; 
    public Text scoreText;

    private static bool isFirstTimeLoad = true;

    private void Awake()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        levelStart = false; 
        rigidbody.gravityScale = 0;
        score = 0; 
        scoreText.text = score.ToString();

        if (isFirstTimeLoad)
        {
            message.GetComponent<SpriteRenderer>().enabled = true;
            isFirstTimeLoad = false; 
        }
        else
        {
            message.GetComponent<SpriteRenderer>().enabled = false; 
        }
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            SoundController.instance.PlayThisSound("wing", 0.5f); 
            if (levelStart == false)
            {
                levelStart = true; 
                rigidbody.gravityScale = 6;
                gameController.GetComponent<PipeGenerator>().enableGenratePipe = true; 
                message.GetComponent<SpriteRenderer>().enabled = false; 
            }
            BirdMoveUp();   
        }
    }

    private void BirdMoveUp()
    {
        rigidbody.linearVelocity = Vector2.up * jumpForce; 
    } 
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundController.instance.PlayThisSound("hit", 0.5f);
        StartCoroutine(ReloadSceneAfterDelay(SoundController.instance.GetSoundDuration("hit")));
        score = 0;
        scoreText.text = score.ToString(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SoundController.instance.PlayThisSound("point", 0.5f);
        score += 1;
        scoreText.text = score.ToString();
    }

    IEnumerator ReloadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); 
        SceneManager.LoadScene("_gameplay");
    }

   
}

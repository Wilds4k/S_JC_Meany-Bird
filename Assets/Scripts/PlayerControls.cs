using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Game Controller object for controlling the player")]
    public GameController gameController;
    [Header("Default Velocity")]
    public float velocity = 1;
    private RigidBody2D rb;
    private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GetComponent<GameController>();
        Time.timeScale = 1;
        rb = GetComponent<RigidBody2D>();
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            rb.velocity = Vector2.up*velocity;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (colision.gameObject.tag == "HighSpike"
            || collision.gameObject.tag == "LowSpike"
            || collision == collision.gameObject.tag == "Ground"){
            GameObject.Find("GameController").GetComponent<GameController>().GameOver();
        }
    
    }
}

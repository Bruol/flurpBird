using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 3;
    public LogicScript logicScript;
    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.Find("LogicManager").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space) && !isDead)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        logicScript.gameOver();
        isDead = true;
    }
}

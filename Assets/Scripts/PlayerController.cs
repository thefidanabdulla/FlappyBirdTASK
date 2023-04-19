using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 10f;
    [SerializeField] private LayerMask ScoreLayerMask;
    [SerializeField] private LayerMask PipeLayerMask;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            //rb.AddForce(Vector3.up * Time.deltaTime * speed);
            rb.velocity = Vector2.up * speed * Time.deltaTime;
            
        }
    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if((ScoreLayerMask.value & (1 << collision.transform.gameObject.layer)) > 0)
        {
            GameManager.instance.ScoreE();
            
        }   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((PipeLayerMask.value & (1 << collision.transform.gameObject.layer)) > 0)
        {
            GameManager.instance.StopGame();
            GameManager.instance.GameOver();

        }
    }
}

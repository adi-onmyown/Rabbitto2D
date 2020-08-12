using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float RotationSpeed;
    public GameObject dust;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, RotationSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.GameOver();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Ground")
        {
            GameManager.instance.IncreamentScore();
            GameObject dustEffect =Instantiate(dust, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            Destroy(gameObject,3f);
            Destroy(dustEffect, 2F);
            
        }

    }
}

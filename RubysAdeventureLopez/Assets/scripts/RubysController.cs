using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubysController : MonoBehaviour
{
    public int maxHealth = 5;
    public int health { get { return currentHealth; } }
    int currentHealth;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        currentHealth = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Creating the two variables that use the pre built axes
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        //create the movment vector
        Vector2 position = transform.position;


        //changing the x and y position
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;


        //Set the upadte position
        transform.position = position;

        rigidbody2d.MovePosition(position);
    }
       
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}

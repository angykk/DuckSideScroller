using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer spriteRenderer;
    public float power = 20;
    bool jump;
    public Rigidbody2D rb;
    float horizontal;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = 0;
        if (Keyboard.current.rightArrowKey.isPressed){
            horizontal += 0.1f;
        }
        else if (Keyboard.current.leftArrowKey.isPressed){
            horizontal -= 0.1f;
        }

        if(transform.position.y < 0){
            jump = false;
        }
        if(rb.velocity.y >= 0)
        {
            rb.gravityScale = 1;
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = 3;
        }
       if (Keyboard.current.upArrowKey.isPressed && !jump)
        {
            rb.AddForce(Vector2.up * power, ForceMode2D.Impulse);
            jump = true;
        }
        else if (Keyboard.current.downArrowKey.isPressed){
            spriteRenderer.sprite = sprite2;
        }
        else{
            spriteRenderer.sprite = sprite1;
        }
         transform.position += Vector3.right * horizontal;

    }
}

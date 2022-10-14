using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public SpriteRenderer spriteRenderer;
    public List<Sprite> nsprites;
    public List<Sprite> nesprites;
    public List<Sprite> esprites;
    public List<Sprite> sesprites;
    public List<Sprite> ssprites;

    public float walkspeed;
    public float framerate;

    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;

        body.velocity = direction * walkspeed;
    }
}

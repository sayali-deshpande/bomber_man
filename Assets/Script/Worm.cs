using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("setDirection", 0, 0.5f);
    }

    Vector2 randomDirection()
    {
        int r = Random.Range(-1, 2);
        return (Random.value < 0.5) ? new Vector2(r, 0) : new Vector2(0, r);
    }

    bool isValidDirection(Vector2 dir)
    {
        Vector2 currentPos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(currentPos + dir, currentPos);
        return (hit.collider.gameObject == gameObject);
    }

    void setDirection()
    {
        Vector2 dir = randomDirection();
        if(isValidDirection(dir))
        {
            GetComponent<Rigidbody2D>().velocity = dir * speed;
            GetComponent<Animator>().SetInteger("X", (int)dir.x);
            GetComponent<Animator>().SetInteger("Y", (int)dir.y);
        }
    }
}

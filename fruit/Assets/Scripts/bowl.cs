using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowl : MonoBehaviour
{

    // Use this for initialization
    private float distanceFromOrigin;
    private float y;
    public float radius = 3f;
    private Vector2 min;
    private Vector2 max;

    void Start()
    {
        min = new Vector2(-2.5f, 0f);
        max = new Vector2(2.5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        distanceFromOrigin = this.transform.position.x;
        y = -Mathf.Pow((Mathf.Pow(radius, 2) - Mathf.Pow(distanceFromOrigin, 2)), 0.5f);
        
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        this.transform.position = new Vector2(mousePosition.x, y);
        this.transform.rotation = Quaternion.Euler(0, 0, distanceFromOrigin * 23f);

        float newX = Mathf.Clamp(transform.position.x, min.x, max.x);
        transform.position = new Vector2(newX, transform.position.y);
    }


    // maybe on safeZone trigger instead of here
    // void OnCollisionEnter2D(Collision2D col) {
    //     col.gameObject.GetComponent<Rigidbody2D>().transform.SetParent(transform);
    // }
}

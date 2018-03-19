using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safeZone : MonoBehaviour
{

    // Use this for initialization
    public static int amoutOfBananas;
    public static int amoutOfWatermelons;
    void Start()
    {
        amoutOfBananas = 0;
        amoutOfWatermelons = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
		// col.GetComponent<Collider2D>().transform.SetParent(transform);

		if(col.gameObject.tag == "banana") {
        amoutOfBananas += 1;
		
		}
		if(col.gameObject.tag == "watermelon") {
        amoutOfWatermelons += 1;
		
		}
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "banana") {
        amoutOfBananas -= 1;
		}
        if(col.gameObject.tag == "watermelon") {
        amoutOfWatermelons -= 1;
		}
    }
}

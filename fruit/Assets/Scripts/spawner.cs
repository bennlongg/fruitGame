using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    // Use this for initialization

    public GameObject[] fruit;
    private GameObject chosenFruit;
    public float spawnPerSecond = 0.2f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(spawnPerSecond);
        if(Score.score > 30) {
            spawnPerSecond = 0.3f;
        } if (Score.score > 60) {
             spawnPerSecond = 0.35f;
        } if (Score.score > 60) {
             spawnPerSecond = 0.4f;
        } if (Score.score > 100) {
             spawnPerSecond = 0.5f;
        } if (Score.score > 200) {
             spawnPerSecond = 0.6f;
        } 
        Spawn();
    }

    void Spawn()
    {
        // foreach (Transform child in transform)
        for (int i = 0; i <= transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            float probabilty = Time.deltaTime * spawnPerSecond;

            if (Random.value < probabilty)
            {
                int index = Random.Range (0, fruit.Length);
                    chosenFruit = Instantiate(fruit[index], child.transform.position, Quaternion.identity) as GameObject;
				chosenFruit.GetComponent<Rigidbody2D>().transform.rotation = Quaternion.Euler(0, 0, Random.Range(0f, 100f));
					if(i == 0) {
						 chosenFruit.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-10f, -7f), 0);
					}
					if(i == 1) {
						 chosenFruit.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-6f, -2f), 0);
					}
					if(i == 2) {
						 chosenFruit.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-2f, 2f), 0);
					}
					if(i == 3) {
						 chosenFruit.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(2f, 6f), 0);
					}
					if(i == 4) {
						 chosenFruit.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(7f, 10f), 0);
					}

                chosenFruit.transform.parent = child;
            }

        }
    }
}

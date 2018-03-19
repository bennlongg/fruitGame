using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitDestroyer : MonoBehaviour
{

    private int alpha;
    private float timer;
    public int scorePerFruit = 1;

    private Score score;
    // Use this for initialization
    void Start()
    {
        timer = 0f;
        score = GameObject.Find("score").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    void OnTriggerStay2D(Collider2D col)
    {

        if (col.gameObject.tag == "safeZone")
        {
            if (this.gameObject.tag == "apple")
            {
                if (timer > 2.0f)
                {
                    StartCoroutine(FadeOut(this.gameObject));
                    scorePerFruit = 1;
                    ResetTimer();
                }
            }
            if (this.gameObject.tag == "banana")
            {
                if (safeZone.amoutOfBananas == 4)
                {
                    if (timer > 1.0f)
                    {
                        StartCoroutine(FadeOut(this.gameObject));
                        scorePerFruit = 3;
                        ResetTimer();
                    }
                }
            }
            if (this.gameObject.tag == "watermelon")
            {
                if (safeZone.amoutOfWatermelons == 2)
                {
                    if (timer > 1.0f)
                    {
                        StartCoroutine(FadeOut(this.gameObject));
                        scorePerFruit = 10;
                        ResetTimer();
                    }
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        timer = 0.0f;
    }

    void ResetTimer()
    {
        timer = 0f;
    }

    IEnumerator FadeOut(GameObject obj)
    {
        yield return new WaitForSeconds(0.5f);
        alpha = 10;
        for (int i = 0; i <= 10; i++)
        {
            alpha -= 1;
            float alphaF = alpha / 10f;
            obj.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphaF);
            yield return 0;
        }

        if (alpha <= 0f)
        {
            
            Destroy(obj);
            score.Points(scorePerFruit);
        }


    }
}

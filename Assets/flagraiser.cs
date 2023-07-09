using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagraiser : MonoBehaviour
{
    float speed = 2;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            Debug.Log("hit the player");
            this.gameObject.GetComponent<Animator>().SetTrigger("Triggered");
            other.GetComponentInChildren<ScoreSystem>().increaseScore();
        }
    }
}

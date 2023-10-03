using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector2(transform.position.x - (3 * Time.deltaTime), transform.position.y);
        anim.SetBool("run", true);

    }
}

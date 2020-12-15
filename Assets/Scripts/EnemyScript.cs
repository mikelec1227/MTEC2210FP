using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour{
public float speed;
private Transform EnemyFleet;

    // Start is called before the first frame update
    void Start()
    {
      EnemyFleet = GetComponent<Transform>();
      InvokeRepeating ("Attack", 1.0f,1.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      float yValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
      Vector3 yMovement =  new Vector3(yValue,0,0);
      transform.position += yMovement;

    }

    /*void Attack ()
    {
      enemyship.position += Vector3.yMovement;

      foreach(Transform enemy in enemyship){
        if (enemy.position.x < -10.5 || enemy.position.x > 10.5)
      {
				speed = -speed;
				enemyship.position += Vector3.down * 0.5f;
				return;
      }
    }
}*/
}

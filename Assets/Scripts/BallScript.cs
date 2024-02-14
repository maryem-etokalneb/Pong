using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class BallScript : MonoBehaviour
{
    [SerializeField] private float initialVelocity =4f;
    [SerializeField] private float VelocityMultuple =1.1f;


    private Rigidbody2D ballRg;
    // Start is called before the first frame update
    void Start()
    {
        ballRg=GetComponent<Rigidbody2D>();
        Launch();
        
    }
    private void Launch(){
        float xVelocity =UnityEngine.Random.Range(0,2)==0?1:-1;
        float yVelocity =UnityEngine.Random.Range(0,2)==0?1:-1;
        ballRg.velocity=new Vector2(xVelocity,yVelocity)*initialVelocity;

    }
   private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player")){
           ballRg.velocity *= VelocityMultuple;
        }
   }
   public void OnTriggerEnter2D(Collider2D collider2d){
        if(collider2d.gameObject.CompareTag("goal1")){
           GameManager.Instance.Player2Scored();
           GameManager.Instance.Restart();
           Launch();

        }else{
           GameManager.Instance.Player1Scored();
           GameManager.Instance.Restart();
           Launch();


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

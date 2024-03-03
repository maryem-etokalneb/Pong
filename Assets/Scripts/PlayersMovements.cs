using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMovements : MonoBehaviour
{
    [SerializeField] private float speed =7f;
    [SerializeField] private bool isPlayer1;
    private float limitation =3.37f;

    // Update is called once per frame
    void Update()
    {
        float movement;
        if(isPlayer1)
        {
             movement = Input.GetAxisRaw("Vertical");
        }else{
             movement = Input.GetAxisRaw("Vertical2");
        }
        Vector2 PlayerPosition=transform.position;
        PlayerPosition.y=Mathf.Clamp(PlayerPosition.y + movement * speed * Time.deltaTime,-limitation,limitation);
        transform.position=PlayerPosition;
        //transform.position += new Vector3(0, movement * speed * Time.deltaTime,0);
    }
   
}

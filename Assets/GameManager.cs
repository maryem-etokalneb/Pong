using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class GameManager : MonoBehaviour
{
   [SerializeField] private TMP_Text Player1Score;
   [SerializeField] private TMP_Text Player2Score;
   [SerializeField] private Transform Player1Transform;
   [SerializeField] private Transform Player2Transform;
   [SerializeField] private Transform BallTransform;
   private int PlayerScore1;
   private int PlayerScore2;
   private static GameManager instance;
   public static GameManager Instance{
        get{
            if(instance==null)
            {
                instance=FindObjectOfType<GameManager>();

            }
            return instance;
        }
   }
   public void Player1Scored(){
        PlayerScore1++;
        Player1Score.text=PlayerScore1.ToString();
   }
    public void Player2Scored(){
        PlayerScore2++;
        Player2Score.text=PlayerScore2.ToString();
   }
    public void Restart(){
        Player1Transform.position=new Vector2(Player1Transform.position.x,0);
        Player2Transform.position=new Vector2(Player2Transform.position.x,0);


        BallTransform.position=new Vector2(0,0);
    }
    


}

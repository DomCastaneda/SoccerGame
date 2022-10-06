using UnityEngine;

public class BlockController : MonoBehaviour
{
   [SerializeField]
   private StatusController _statusController = null;

   //detect collisions between the GameObjects with Colliders attached
   void OnCollisionEnter(Collision collision)
   {
      if (_statusController.IsGamePlayActive() && collision.gameObject.name == "block")
      {
         Debug.Log("You Died!");
         
         //notify server that we have a block hit
         WebSocketService.Instance.BlockHit();
      }
   }
}

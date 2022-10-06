using UnityEngine;

public class BlockController : MonoBehaviour
{
   [SerializeField]
   private StatusController _statusController = null;

   //detect collisions between the GameObjects with Colliders attached
   void OnTriggerEnter(Collider collider)
   {
      if (_statusController.IsGamePlayActive() && collider.gameObject.name == "ball")
      {
         Debug.Log("You Died!");
         
         //notify server that we have a block hit
         WebSocketService.Instance.BlockHit();
      }
   }
}

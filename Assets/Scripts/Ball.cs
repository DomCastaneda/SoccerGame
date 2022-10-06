using UnityEngine;

public class BallActionHandler
{
   private Transform _playerCamera;
   private Rigidbody _ball;
   private float _baseBallThrust;
   private float _yAxisSpawnPointAdjustment = 2.0f;

   public BallActionHandler(Transform playerCamera, Rigidbody ball, float baseBallThrust)
   {
      _playerCamera = playerCamera;
      _ball = ball;
      _baseBallThrust = baseBallThrust;
   }

   // DEBUG: Use to debug what the object is overlapping with
   private void PrintOverlapShereObjects(Vector3 spawnPos)
   {
      Collider[] hitColliders = Physics.OverlapSphere(spawnPos, 0.5f);
      int i = 0;
      while (i < hitColliders.Length)
      {
         Debug.Log(hitColliders[i].name);
         i++;
      }
   }
}

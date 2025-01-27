using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
public class CameraController : MonoBehaviour 
{ 
[SerializeField] private Transform player; 
private void Update() 
{ 
float hyt = player.position.y + 1; 
transform.position=newVector3(player.position.x,hyt,transform.position.z); 
}
}
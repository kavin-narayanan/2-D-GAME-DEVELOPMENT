using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement; 
public class PlayerLife : MonoBehaviour 
{ 
private Rigidbody2D rb; 
private Animator anim; 
[SerializeField] private AudioSource deathSoundEffect; 
[SerializeField] private AudioSource bgm; 
// Start is called before the first frame update 
private void Start() 
{  
rb = GetComponent<Rigidbody2D>(); 
anim=GetComponent<Animator>(); 
}
private void OnCollisionEnter2D(Collision2D collision) 
{ 
if (collision.gameObject.CompareTag("Trap")) 
{ 
Die(); 
}
}
private void Die() 
{ 
bgm.Stop(); 
deathSoundEffect.Play(); 
rb.bodyType = RigidbodyType2D.Static; 
anim.SetTrigger("DEATH"); 
}
private void RestartLevel() 
{ 
SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
} 
} 
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Pellet : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public int points = 10;
     
    
    protected virtual void Eat()
    {
        audioSource.PlayOneShot(clip);
        FindObjectOfType<GameManager>().PelletEaten(this);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Pacman")) {

            Eat();
            
        }
    }

}

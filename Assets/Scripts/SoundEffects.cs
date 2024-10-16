using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    //Reference to Audio source
    public AudioSource audioSource;
    //Sound to play for collision
    public AudioClip collisionSound;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure AudioSource is set; if not, get the AudioSource from the same GameObject
        if (audioSource != null)
        {
            audioSource.GetComponent<AudioSource>();
        }
    }

    //Function is called when gameObject collides with another object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Play the sound only if there’s an audio source and sound clip assigned
        if (audioSource != null && collisionSound != null)
        {
            audioSource.PlayOneShot(collisionSound);
        }
    }



}

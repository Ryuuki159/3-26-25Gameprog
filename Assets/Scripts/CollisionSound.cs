using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioClip colSound;
    private AudioSource AudioSource;
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayOneShot(colSound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

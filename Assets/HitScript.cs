using UnityEngine;

public class HitScript : MonoBehaviour
{
    public GameObject[] filter;
    public ParticleSystem hitParticle;
    public GameObject hitpart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hitpart.transform.position = gameObject.transform.position;
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            hitParticle.Play();
           
        }
    }
}

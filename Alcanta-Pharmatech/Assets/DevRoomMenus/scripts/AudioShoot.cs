using UnityEngine;

public class AudioShoot : MonoBehaviour
{
    Turret tourelle;
    public AudioSource audiosource;
    public bool AlreadyPlayed;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = gameObject.GetComponent<AudioSource>();
        tourelle = GetComponent<Turret>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (tourelle.shoot && !AlreadyPlayed)
        {
            audiosource.Play();
            AlreadyPlayed = true;
        }
    }
}

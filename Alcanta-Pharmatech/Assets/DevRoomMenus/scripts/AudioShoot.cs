using UnityEngine;

public class AudioShoot : MonoBehaviour
{
    TurretMid tourelle;
    public AudioClip audiosound;
    public AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GameObject.Find("GameManager").GetComponent<AudioSource>();
        tourelle = GetComponent<TurretMid>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tourelle.shoot)
        {
            audiosource.Play();
        }
    }
}

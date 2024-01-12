using UnityEngine;

public class AudioShoot : MonoBehaviour
{
    TurretMid tourelle;
    public AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = gameObject.GetComponent<AudioSource>();
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

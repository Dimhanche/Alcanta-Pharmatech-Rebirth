using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    private AudioSource _audiosource;
    public AudioClip[] songs;
    public float volume;
    public Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        _audiosource = GetComponent<AudioSource>();
        volumeSlider.value = PlayerPrefs.GetFloat("volume",.5f);
        if (!_audiosource.isPlaying && Time.timeScale == 1)
            ChangeSong(Random.Range(0, songs.Length));
    }

    // Update is called once per frame
    void Update()
    {

        _audiosource.volume = volume;
        if (!_audiosource.isPlaying)
            ChangeSong(Random.Range(0, songs.Length));
    }

    public void ChangeSong(int songPicked)
    {
        _audiosource.clip = songs[songPicked];
        _audiosource.Play();
    }

    public void VolumeChange()
    {
        if (volume != volumeSlider.value)
        {
            volume = volumeSlider.value;
            PlayerPrefs.SetFloat("Volume", volume);
            PlayerPrefs.SetFloat("volume", volumeSlider.value);
        }
    }
}


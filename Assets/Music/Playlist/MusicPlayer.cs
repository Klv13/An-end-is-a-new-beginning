using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{

    private static MusicPlayer self;
    private int scene = 0;
    public List<AudioClip> Music;
    [SerializeField] AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if (self == null)
        {
            self = gameObject.GetComponent<MusicPlayer>();
        }
        else
        {
            Destroy(gameObject);
        }
        source = GetComponent<AudioSource>();
        source.clip = Music[Random.Range(0,Music.Count)];
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (scene != SceneManager.GetActiveScene().buildIndex)
        {
            scene = SceneManager.GetActiveScene().buildIndex;
            source.clip = Music[Random.Range(0, Music.Count)];
            source.Play();
        }
        source.volume = PlayerPrefs.GetFloat("Volume");
        
    }
}

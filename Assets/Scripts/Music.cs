using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{

    public Slider bGM;
    private AudioSource source;

    private float bgm_Vol = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.source = this.gameObject.GetComponent<AudioSource>();
        source.volume = bgm_Vol;
    }

    // Update is called once per frame
    void Update()
    {
        source.volume = bGM.value;
        bgm_Vol = bGM.value;
    }
}

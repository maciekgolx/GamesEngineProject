using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromClip : MonoBehaviour
{
    public AudioSource source;
    public Vector3 minScale;
    public Vector3 maxScale;
    public MicDetection micdetector;
    public float loudnessSensibility = 100;
    public float threshold = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = micdetector.GetLoudnessFromAudioClip(source.timeSamples,source.clip) ;

        if ( loudness<threshold)
            loudness =0;
        transform.localScale= Vector3.Lerp(minScale,maxScale,loudness);
    }
}

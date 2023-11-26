using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
[RequireComponent(typeof(AudioSource))]
public class AudioPeer : MonoBehaviour
{   


    AudioSource _audioSource;

    
    public AudioClip _audioClip;
    public bool _useMicrophone ;
    public string SeletedDevice;
    public AudioMixerGroup _mixerGroupMicrophone, _mixerGroupMaster;
    [SerializeField]
    public static float[] _samples = new float[512];
    public static float[] _freqBand = new float[8];
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        if (_useMicrophone)
        {
            if (Microphone.devices.Length > 0)
            {
                SeletedDevice = Microphone.devices[0].ToString();
                _audioSource.outputAudioMixerGroup = _mixerGroupMicrophone;
                _audioSource.clip = Microphone.Start(SeletedDevice, true, 200, AudioSettings.outputSampleRate);
                _audioSource.Play();
            }
            else
            {
                _useMicrophone = false;
            }
            
        }
        
        if (!_useMicrophone)
        {
            _audioSource.outputAudioMixerGroup = _mixerGroupMaster;
            _audioSource.clip = _audioClip;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
        MakeFreqBand();
    }
    void GetSpectrumAudioSource()
    {
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
    }
    void MakeFreqBand()
    {
        int count = 0;
        for(int i =0; i<8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;
            if (i == 7)
            {
                
                sampleCount += 2;

            }
            for(int j=0; j<sampleCount; j++)
            {
                average += _samples[count] * (count + 1);
                count++;
            }
            average /= count;
            _freqBand[i] = average * 10;
        }
    }
}

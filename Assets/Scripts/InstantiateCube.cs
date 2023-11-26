using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    public GameObject _samplecubeprefab;
    GameObject[] _samplecube = new GameObject[512];
    

    public float _maxScale;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<512; i++)
        {
            GameObject _instancesamplecube = (GameObject)Instantiate(_samplecubeprefab);
            _instancesamplecube.transform.position = this.transform.position;
            _instancesamplecube.transform.parent = this.transform;
            _instancesamplecube.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            _instancesamplecube.transform.position = Vector3.forward * 10;
            _samplecube[i] = _instancesamplecube;

        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<512; i++)
        {
            if (_samplecube != null)
            {
                _samplecube[i].transform.localScale = new Vector3(10, (AudioPeer._samples[i]*_maxScale)* 2, 10);
            }
        }
        
    }
}

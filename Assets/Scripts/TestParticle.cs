using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    private bool _isParticlePlaying = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!_isParticlePlaying)
            {
                _particleSystem.Play();
                _isParticlePlaying = true;
            }
            else
            {
                _particleSystem.Stop();
                _isParticlePlaying = false;
            }
        }
        
    }
}

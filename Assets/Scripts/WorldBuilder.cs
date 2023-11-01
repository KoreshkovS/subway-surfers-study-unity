using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBuilder : MonoBehaviour
{
    [SerializeField] private Transform _platformContainer;
    [SerializeField] private GameObject[] _freePlatforms;
    [SerializeField] private GameObject[] _obstaclePlatforms;

    private Transform _lastPlatform = null;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateFreePlatform();
        }
    }

    private void CreateFreePlatform()
    {
        Vector3 pos = (_lastPlatform == null) ?
            _platformContainer.position :
            _lastPlatform.position;

        int index = Random.Range(0, _freePlatforms.Length);
        GameObject res = Instantiate(_freePlatforms[index], pos, Quaternion.identity, _platformContainer);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject _downline;
    public GameObject _smallObject;
    public GameObject _upline;
    int _index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetActiveObjects()
    {
        _index += 1;
        if (_index == 1)
        {
            _downline.SetActive(true);
        }
        else if (_index == 2)
        {
            _smallObject.SetActive(true);
        }
        else if(_index == 3)
        {
            _upline.SetActive(true);
        }
    }
}

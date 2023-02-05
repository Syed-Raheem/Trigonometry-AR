using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    int _index = 0;
    // public GameObject _minar;
    // public GameObject _downline;
    // public GameObject _smallObject;
    // public GameObject _upline;
    public GameObject High_tower;
    private GameObject _downline;
    private GameObject _smallObject;
    private GameObject _upline;
    private GameObject _can;
    public Button _Explanation_button;
    public TMPro.TextMeshProUGUI _Explanation_Text;
    public Button _Equations_button;
    public TMPro.TextMeshProUGUI _Equations_Text;
    public Button _Previous_button;
    public Button _Next_button;

    private HighTower_script highTower_Script;
    void Start()
    {
        // _downline = Hi
        // _smallObject = GameObject.Find("smallObject");
        // _upline = GameObject.Find("upline");
        // _can = GameObject.Find("Canavs");
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    
    public void SetActiveObjects()
    {
        if(GameObject.FindGameObjectWithTag("High_tower")!=null)
        {
            _index += 1;
            if (_index == 1)
            {
                High_tower=GameObject.FindGameObjectWithTag("High_tower");
                highTower_Script=High_tower.GetComponent<HighTower_script>();
                _smallObject= highTower_Script._smallObject;
                _downline=highTower_Script._downline;
                _upline=highTower_Script._upline;
                _can=highTower_Script._can;
                _Previous_button.gameObject.SetActive(true);
                _Explanation_Text.text = "Observe the qutub minar";
            }
            else if (_index == 2)
            {
                _Explanation_Text.text = "Here we can see the qutub minar draw the line on the qutub minar shadow";
            }
            else if (_index == 3)
            {
                _downline.SetActive(true);
                _Explanation_Text.text = "The measurement of the shadow is 73m";
            }
            else if (_index == 4)
            {
                _Explanation_Text.text = "Now place the small object at distance of 1.5m from shadow";
            }
            else if (_index == 5)
            {
                _smallObject.SetActive(true);
                _Explanation_Text.text = "the height of the object also 1.5m";
            }
            else if (_index == 6)
            {
                _Explanation_Text.text = "Now draw the line from the top of the minar to the enbd of the shadow";
            }
            else if (_index == 7)
            {
                _upline.SetActive(true);
                _Explanation_Text.text = "The line passes touches the top of the smallobject";
            }
            else if (_index == 8)
            {
                _Explanation_Text.text = "Here we can observe that two triangles are formed";
            }
            else if(_index == 9)
            {
                _can.gameObject.SetActive(true);
                _Explanation_Text.text = "One triange is ABC and Another one is ADE";
            }
            else if (_index == 10)
            {
                _Explanation_Text.text = "";
                _Explanation_button.gameObject.SetActive(false);
                _Equations_button.gameObject.SetActive(true);
            }
            else if(_index == 11)
            {
                _Equations_Text.text = "For small trinagle tan(θ) = DE/AE";
            }
            else if(_index == 12)
            {
                _Equations_Text.text = "θ = tan -1(DE/AE)    ";
            }
            else if(_index == 13)
            {
                _Equations_Text.text = "As we already know that DE = AE = 1.5m";
            }
            else if(_index == 14)
            {
                _Equations_Text.text = "so, θ = tan -1(1.5/1.5)     ";
            }
            else if (_index == 15)
            {
                _Equations_Text.text = "θ = tan -1(1)";
            }
            else if (_index == 16)
            {
                _Equations_Text.text = "θ = 45";
            }
            else if (_index == 17)
            {
                _Equations_Text.text = "For big triangle, tan θ = BC/AC";
            }
            else if (_index == 18)
            {
                _Equations_Text.text = "since θ = 45, tan 45 = BC/AC";
            }
            else if (_index == 19)
            {
                _Equations_Text.text = "1 = BC/AC";
            }
            else if (_index == 19)
            {
                _Equations_Text.text = "BC = AC/1";
            }
            else if (_index == 20)
            {
                _Equations_Text.text = "As we already know AC = 73 so BC = 73/1";
            }
            else if (_index == 21)
            {
                _Equations_Text.text = "BC = 73 which is the height of the qutub minar";
            }
            else if(_index == 22)
            {
                _Equations_Text.text = "We have successfully found the height of qutub minar";
            }
            else if(_index == 23)
            {
                _Next_button.gameObject.SetActive(false);
                _Equations_Text.text = "Now you can close the application";
            }
       }
    }
    public void decreaseby1()
    {
        if(GameObject.FindGameObjectWithTag("High_tower")!=null)
        {
            _index -= 1;
            if(_index == 0)
            {
                High_tower=GameObject.FindGameObjectWithTag("High_tower");
                highTower_Script=High_tower.GetComponent<HighTower_script>();
                _smallObject= highTower_Script._smallObject;
                _downline=highTower_Script._downline;
                _upline=highTower_Script._upline;
                _can=highTower_Script._can;
                _Previous_button.gameObject.SetActive(false);
                _Explanation_Text.text = "Hai students today we are going measure the height of the qutub minar using trignometry.";
            }
            if (_index == 1)
            {
                _Explanation_Text.text = "Obsereve the qutub minar";
            }
            else if (_index == 2)
            {
                _Explanation_Text.text = "Here we can see the qutub minar draw the line on the qutub minar shadow";
                _downline.SetActive(false);
            }
            else if (_index == 3)
            {
                _downline.SetActive(true);
                _Explanation_Text.text = "The measurement of the shadow is 73m";
            }
            else if (_index == 4)
            {
                _Explanation_Text.text = "Now place the small object at distance of 1.5m from shadow";
                _smallObject.SetActive(false);
            }
            else if (_index == 5)
            {
                _smallObject.SetActive(true);
                _Explanation_Text.text = "the height of the object also 1.5m";
            }
            else if (_index == 6)
            {
                _Explanation_Text.text = "Now draw the line from the top of the minar to the enbd of the shadow";
                _upline.SetActive(false);
            }
            else if (_index == 7)
            {
                _upline.SetActive(true);
                _Explanation_Text.text = "The line passes touches the top of the smallobject";
            }
            else if(_index == 8)
            {
                _Explanation_Text.text = "Here we can observe that two triangles are formed";
                _can.gameObject.SetActive(false);
                _Explanation_Text.text = "One triange is ABC and Another one is ADE";
            }
            else if (_index == 9)
            {
                _can.gameObject.SetActive(true);
                _Explanation_Text.text = "One triange is ABC and Another one is ADE";
                _Explanation_button.gameObject.SetActive(true);
                _Equations_button.gameObject.SetActive(false);
            }
            else if(_index == 10)
            {
                _Explanation_Text.text = "";
                _Explanation_button.gameObject.SetActive(false);
                _Equations_button.gameObject.SetActive(true);
            }
            else if(_index == 11)
            {
                _Equations_Text.text = "For small trinagle tan(θ) = DE/AE";
            }
            else if(_index == 12)
            {
                _Equations_Text.text = "θ = tan -1(DE/AE)    ";
            }
            else if(_index == 13)
            {
                _Equations_Text.text = "As we already know that DE = AE = 1.5m";
            }
            else if(_index == 14)
            {
                _Equations_Text.text = "so, θ = tan -1(1.5/1.5)     ";
            }
            else if (_index == 15)
            {
                _Equations_Text.text = "θ = tan -1(1)";
            }
            else if (_index == 16)
            {
                _Equations_Text.text = "θ = 45";
            }
            else if (_index == 17)
            {
                _Equations_Text.text = "For big triangle, tan θ = BC/AC";
            }
            else if (_index == 18)
            {
                _Equations_Text.text = "since θ = 45, tan 45 = BC/AC";
            }
            else if (_index == 19)
            {
                _Equations_Text.text = "1 = BC/AC";
            }
            else if (_index == 19)
            {
                _Equations_Text.text = "BC = AC/1";
            }
            else if (_index == 20)
            {
                _Equations_Text.text = "As we already know AC = 73 so BC = 73/1";
            }
            else if (_index == 21)
            {
                _Equations_Text.text = "BC = 73 which is the height of the qutub minar";
            }
            else if(_index == 22)
            {
                _Next_button.gameObject.SetActive(true);
                _Equations_Text.text = "We have successfully found the height of qutub minar";
            }
        }
    }
}

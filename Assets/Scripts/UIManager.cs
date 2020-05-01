using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public GameObject PlayerState;
    public GameObject OptionState;

    public Text axText;
    public Text armorText;
    public Text helmetText;
    public Text MPText;
    public Text HpText;
    public Text ringText;

    int axState;
    int armorState;
    int helmetState;
    int mp;
    int hp;
    int ringState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void randinit() {
        axState = Random.Range(10, 30);
        armorState = Random.Range(20, 40);
        helmetState = Random.Range(10, 20);
        mp = Random.Range(50, 70);
        hp = Random.Range(90, 100);
        ringState = Random.Range(10, 40);


        axText.text = axState.ToString();
        armorText.text = armorState.ToString();
        helmetText.text = helmetState.ToString();
        MPText.text = mp.ToString();
        HpText.text = hp.ToString();
        ringText.text = ringState.ToString();
    }

    public void popState() {
        PlayerState.SetActive(true);
    }

    public void closeState() {
        PlayerState.SetActive(false);
    }

    public void popOption() {
        OptionState.SetActive(true);
    }

    public void closeOption() {
        OptionState.SetActive(false);
    }

}

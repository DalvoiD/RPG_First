using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Text Stran;
    public Text Agil;
    public Text Intel;
    public Text Prot;
    public Text Atak;

    private int _stran = 1;
    private int _agil = 1;
    private int _intel = 1;
    private int _prot = 1;
    private int _atak = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        Stran.text = _stran.ToString();
        Agil.text = _agil.ToString();
        Intel.text = _intel.ToString();
        Prot.text = _prot.ToString();
        Atak.text = _atak.ToString();
    }
}

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

    private int _stran;
    private int _agil;
    private int _intel;
    private int _prot;
    private int _atak;

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

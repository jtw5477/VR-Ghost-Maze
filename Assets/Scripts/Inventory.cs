using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Inventory : MonoBehaviour
{
    public Inventory instance;

    public TMP_Text text;

    private int med = 0; 
    private int flash = 0;
    private int pill = 0;
    private int walkie = 0;

    private void UpdateText(){
        text.text = "First Aid: " + med.ToString() + "\nFlashlight: " + flash.ToString() + "\nPill Bottle: " + pill.ToString() + "\nWalkieTalkie: " + walkie.ToString() ;
    }
    public void AddMed(){
        med++;
        UpdateText(); 
    }
    public void AddFlash() {
        flash++;
         UpdateText();
    }
    
    public void AddPill() {
        pill++;
         UpdateText();
    }
    public void AddWalkie(){
        walkie++;
         UpdateText();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{

    public Image icon;
    public Text text;
    public Image seta;

    private DialogData dialogData;
    private int actualText = 0;

    private AudioSource audioSource;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start() {
        
    }

    public void ShowDialog(DialogData dialog){
        gameObject.SetActive(true);
        this.dialogData = dialog;
        actualText = 0;
        audioSource.Play();
        Set(dialogData.talks[actualText].icon,dialogData.talks[actualText].text);
    }


    private void Update() {
        if(Input.GetButtonDown("Jump")){
            actualText++;
            if(actualText < dialogData.talks.Length){
                Set(dialogData.talks[actualText].icon,dialogData.talks[actualText].text);
            }else{
                CloseDialog();
            }
        }
    }

    private void Set(Sprite icon,string text){
        this.icon.sprite = icon;
        this.text.text = text;
        this.seta.gameObject.SetActive(actualText < dialogData.talks.Length-1); 
    }

    public void CloseDialog(){
        gameObject.SetActive(false);
    }
}

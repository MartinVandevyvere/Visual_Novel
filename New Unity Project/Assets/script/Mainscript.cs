using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mainscript : MonoBehaviour
{
    public Text TextDialog;
    public Text TextNameCharacter;
    public Image SpriteIA;
    public Image SpriteCharacter;
    public Dialogue[] Dialogs;
    int _sequenceNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateDialogSequence(Dialogs[0]);
    }

    // Update is called once per frame
    void UpdateDialogSequence( Dialogue sequence )
    {
        TextDialog.text = sequence.TextDialog;
        TextNameCharacter.text = sequence.TextNameCharacter;
        SpriteCharacter.sprite = sequence.SpriteCharacter;
        SpriteIA.sprite = sequence.SpriteIA;
    }

    public void OnClickNextDialog()
    {
        _sequenceNumber++;
        UpdateDialogSequence(Dialogs[_sequenceNumber]);
    }
}
